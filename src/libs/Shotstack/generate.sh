dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated

# Step 1: Clone the Shotstack OpenAPI repo (has external $refs across files)
TMPDIR=$(mktemp -d)
git clone --depth 1 https://github.com/shotstack/oas-api-definition.git "$TMPDIR/oas" 2>/dev/null

# Step 2: Bundle all external $refs into single YAML using redocly
npx @redocly/cli@latest bundle "$TMPDIR/oas/api.oas3.yaml" -o "$TMPDIR/bundled.yaml" --force 2>/dev/null

# Step 3: Transform spec for AutoSDK:
# - Merge 4 servers (edit/serve/ingest/create) into single base URL with path prefixes
# - Convert apiKey auth to http/bearer
# - Add top-level security array
# - Remove external $ref in examples
python3 transform_spec.py "$TMPDIR/bundled.yaml" openapi.json

# Cleanup
rm -rf "$TMPDIR"

# Step 4: Generate SDK
autosdk generate openapi.json \
  --namespace Shotstack \
  --clientClassName ShotstackClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
