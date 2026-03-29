# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Shotstack SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to Shotstack's video rendering status, template listing, media probing, and asset management.

## Installation

```bash
dotnet add package tryAGI.Shotstack
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsGetRenderStatusTool()` | `Shotstack_GetRenderStatus` | Get render job status and output URL |
| `AsListTemplatesTool()` | `Shotstack_ListTemplates` | List video/image templates |
| `AsProbeTool()` | `Shotstack_Probe` | Probe media file for metadata |
| `AsListAssetsTool()` | `Shotstack_ListAssets` | List hosted assets for a render |

## Usage

```csharp
using Microsoft.Extensions.AI;
using Shotstack;

var client = new ShotstackClient(
    apiKey: Environment.GetEnvironmentVariable("SHOTSTACK_API_KEY")!);

var options = new ChatOptions
{
    Tools = [client.AsGetRenderStatusTool()],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "Check the status of render job abc-123"),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```
