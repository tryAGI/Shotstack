/* order: 10, title: Video Editing, slug: video-editing */

namespace Shotstack.IntegrationTests.Examples;

[TestClass]
public class VideoEditing
{
    //// Shotstack provides programmatic video editing via the Edit API.
    //// Create a client, probe media files, and render videos.

    [TestMethod]
    public void CreateClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("SHOTSTACK_API_KEY") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException("SHOTSTACK_API_KEY environment variable is not found.");

        using var client = new ShotstackClient(apiKey);

        //// The client has 4 sub-clients for different APIs.
        Assert.IsNotNull(client.Edit);
        Assert.IsNotNull(client.Serve);
        Assert.IsNotNull(client.Ingest);
        Assert.IsNotNull(client.Create);
    }
}
