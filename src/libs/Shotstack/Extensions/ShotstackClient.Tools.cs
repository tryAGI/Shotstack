#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace Shotstack;

public static class ShotstackClientTools
{
    /// <summary>
    /// Creates an AIFunction tool that gets the status and details of a render job.
    /// </summary>
    public static AIFunction AsGetRenderStatusTool(this ShotstackClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The render job ID to check status for")] string renderId,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Edit.GetRenderAsync(
                    id: renderId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Response?.Id,
                    Status = response.Response?.Status,
                    Url = response.Response?.Url,
                    response.Response?.Duration,
                    response.Response?.Created,
                };
            },
            name: "Shotstack_GetRenderStatus",
            description: "Get the status and details of a Shotstack video/image render job including the output URL when complete.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists templates.
    /// </summary>
    public static AIFunction AsListTemplatesTool(this ShotstackClient client)
    {
        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Edit.GetTemplatesAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Shotstack_ListTemplates",
            description: "List all available Shotstack video/image templates.");
    }

    /// <summary>
    /// Creates an AIFunction tool that probes a media file for metadata.
    /// </summary>
    public static AIFunction AsProbeTool(this ShotstackClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The URL of the media file to probe for metadata")] string url,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Edit.ProbeAsync(
                    url: url,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Shotstack_Probe",
            description: "Probe a media file URL for metadata including duration, resolution, codec, and format information.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists hosted assets.
    /// </summary>
    public static AIFunction AsListAssetsTool(this ShotstackClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The render ID to get hosted assets for")] string renderId,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Serve.GetAssetByRenderIdAsync(
                    id: renderId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Shotstack_ListAssets",
            description: "List hosted assets for a given render ID from the Shotstack Serve API.");
    }
}
