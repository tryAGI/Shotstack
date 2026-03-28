/* order: 20, title: MEAI Tools, slug: meai-tools */

namespace Shotstack.IntegrationTests.Examples;

[TestClass]
public class MeaiTools
{
    //// Shotstack provides `AIFunction` tools that can be used with any `IChatClient`
    //// for function/tool calling scenarios.

    [TestMethod]
    public void CreateTools()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("SHOTSTACK_API_KEY") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException("SHOTSTACK_API_KEY environment variable is not found.");

        using var client = new ShotstackClient(apiKey);

        //// Create tools for render status, templates, probing, and assets.
        var getRenderStatusTool = client.AsGetRenderStatusTool();
        var listTemplatesTool = client.AsListTemplatesTool();
        var probeTool = client.AsProbeTool();
        var listAssetsTool = client.AsListAssetsTool();

        Assert.AreEqual("Shotstack_GetRenderStatus", getRenderStatusTool.Name);
        Assert.AreEqual("Shotstack_ListTemplates", listTemplatesTool.Name);
        Assert.AreEqual("Shotstack_Probe", probeTool.Name);
        Assert.AreEqual("Shotstack_ListAssets", listAssetsTool.Name);

        //// These tools can be passed to any IChatClient that supports function calling.
        var tools = new[] { getRenderStatusTool, listTemplatesTool, probeTool, listAssetsTool };
        Assert.AreEqual(4, tools.Length);
    }
}
