#nullable enable

namespace Shotstack;

public partial class ShotstackClient
{
    /// <summary>
    /// After Bearer auth is set, convert to x-api-key header on the HttpClient.
    /// Shotstack uses x-api-key header instead of Authorization: Bearer.
    /// </summary>
    partial void Authorized(System.Net.Http.HttpClient client)
    {
        var apiKey = Authorizations.FirstOrDefault()?.Value;
        if (apiKey is { Length: > 0 })
        {
            client.DefaultRequestHeaders.TryAddWithoutValidation("x-api-key", apiKey);
        }
    }
}
