# CLAUDE.md — Shotstack SDK

## Overview

Auto-generated C# SDK for [Shotstack](https://shotstack.io/) — programmatic video, image, and audio editing with 4 APIs: Edit (render), Serve (hosting), Ingest (upload), Create (AI generation).
OpenAPI spec from `https://raw.githubusercontent.com/shotstack/oas-api-definition/main/api.oas3.yaml` (multi-server spec bundled and transformed).

## Build & Test

```bash
dotnet build Shotstack.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

API key via `x-api-key` header. Constructor uses Bearer internally, converted via `Authorized` hook:

```csharp
var client = new ShotstackClient(apiKey); // SHOTSTACK_API_KEY env var
```

## Key Files

- `src/libs/Shotstack/openapi.yaml` — Bundled and transformed OpenAPI 3 spec
- `src/libs/Shotstack/generate.sh` — Clones repo, bundles with redocly, transforms with Python, runs autosdk
- `src/libs/Shotstack/Generated/` — **Never edit** — auto-generated code
- `src/libs/Shotstack/Extensions/ShotstackClient.PrepareRequest.cs` — Auth hook (Bearer → x-api-key)
- `src/libs/Shotstack/Extensions/ShotstackClient.Tools.cs` — MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Sub-client Pattern

```csharp
var client = new ShotstackClient(apiKey);

// Edit API — render videos/images, manage templates, probe media
client.Edit.PostRenderAsync(edit)           // Submit render job
client.Edit.GetRenderAsync(id)              // Get render status
client.Edit.GetTemplatesAsync()             // List templates
client.Edit.PostTemplateAsync(template)     // Create template
client.Edit.ProbeAsync(url)                 // Probe media file

// Serve API — manage hosted assets
client.Serve.GetAssetByRenderIdAsync(id)    // Get assets by render ID
client.Serve.GetAssetAsync(id)              // Get specific asset
client.Serve.DeleteAssetAsync(id)           // Delete asset

// Ingest API — upload and manage source files
client.Ingest.PostSourceAsync(source)       // Upload source
client.Ingest.GetSourcesAsync()             // List sources
client.Ingest.GetSourceAsync(id)            // Get source details

// Create API — AI-powered asset generation
client.Create.PostGenerateAssetAsync(...)   // Generate asset (TTS, avatar)
client.Create.GetGeneratedAssetAsync(id)    // Get generated asset status
```

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsGetRenderStatusTool()` — Get video/image render job status and output URL
- `AsListTemplatesTool()` — List available video/image templates
- `AsProbeTool()` — Probe a media file URL for metadata
- `AsListAssetsTool()` — List hosted assets for a render ID

## Spec Notes

- Base URL: `https://api.shotstack.io`
- Multi-server spec: 4 APIs (Edit, Serve, Ingest, Create) merged with path prefixes
- Spec uses external `$ref` across many YAML files — `redocly bundle` required
- Auth: `x-api-key` header — `Authorized` hook sets header on HttpClient.DefaultRequestHeaders
- Generated code doesn't apply Authorizations per-request (no foreach loop)
