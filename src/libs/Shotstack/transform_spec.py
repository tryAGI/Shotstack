#!/usr/bin/env python3
"""
Transform Shotstack OpenAPI spec for AutoSDK generation.

1. Resolves external $ref examples (removes them)
2. Merges multiple servers into single base URL with path prefixes per tag
3. Converts apiKey auth to http/bearer
4. Adds top-level security array
"""
import yaml
import json
import sys


def transform_spec(input_path, output_path):
    with open(input_path) as f:
        spec = yaml.safe_load(f)

    # --- 1. Fix servers: use single base URL ---
    # Shotstack servers:
    #   https://api.shotstack.io/edit/{version}
    #   https://api.shotstack.io/serve/{version}
    #   https://api.shotstack.io/ingest/{version}
    #   https://api.shotstack.io/create/{version}
    #
    # Strategy: Use base URL https://api.shotstack.io
    # Prefix paths with /edit/v1, /serve/v1, /ingest/v1, /create/v1 based on tag

    tag_to_prefix = {
        'Edit': '/edit',
        'Serve': '/serve',
        'Ingest': '/ingest',
        'Create': '/create',
    }

    spec['servers'] = [{'url': 'https://api.shotstack.io'}]

    # --- 2. Prefix paths based on operation tags ---
    new_paths = {}
    for path, path_item in spec.get('paths', {}).items():
        # Determine prefix from the first operation's tag
        prefix = ''
        for method in ['get', 'post', 'put', 'patch', 'delete', 'head', 'options']:
            if method in path_item:
                tags = path_item[method].get('tags', [])
                if tags and tags[0] in tag_to_prefix:
                    prefix = tag_to_prefix[tags[0]]
                break

        # Handle path_alias_createassets -> create/assets
        if path.startswith('/path_alias_createassets'):
            new_path = path.replace('/path_alias_createassets', '/create/v1/assets')
        else:
            new_path = f'{prefix}/v1{path}'

        new_paths[new_path] = path_item

    spec['paths'] = new_paths

    # --- 3. Convert auth: apiKey -> http/bearer ---
    if 'components' not in spec:
        spec['components'] = {}
    spec['components']['securitySchemes'] = {
        'BearerAuth': {
            'type': 'http',
            'scheme': 'bearer',
        }
    }

    # --- 4. Add top-level security ---
    spec['security'] = [{'BearerAuth': []}]

    # --- 5. Remove external $ref in examples ---
    def remove_external_refs(obj):
        if isinstance(obj, dict):
            if '$ref' in obj and not obj['$ref'].startswith('#/'):
                del obj['$ref']
                return obj
            for k, v in list(obj.items()):
                obj[k] = remove_external_refs(v)
        elif isinstance(obj, list):
            for i in range(len(obj)):
                obj[i] = remove_external_refs(obj[i])
        return obj

    spec = remove_external_refs(spec)

    # --- 6. Write output as JSON ---
    with open(output_path, 'w') as f:
        json.dump(spec, f, indent=2)

    # Count operations
    op_count = 0
    for path, item in spec['paths'].items():
        for method in ['get', 'post', 'put', 'patch', 'delete']:
            if method in item:
                op_count += 1

    print(f"Transformed spec: {len(spec['paths'])} paths, {op_count} operations, {len(spec.get('components', {}).get('schemas', {}))} schemas")


if __name__ == '__main__':
    input_path = sys.argv[1] if len(sys.argv) > 1 else 'openapi-bundled.yaml'
    output_path = sys.argv[2] if len(sys.argv) > 2 else 'openapi.json'
    transform_spec(input_path, output_path)
