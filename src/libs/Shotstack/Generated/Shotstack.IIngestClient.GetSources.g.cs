#nullable enable

namespace Shotstack
{
    public partial interface IIngestClient
    {
        /// <summary>
        /// List Sources<br/>
        /// Retrieve a list of ingested source files stored against a users account and stage.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/ingest/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Shotstack.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Shotstack.SourceListResponse> GetSourcesAsync(
            global::Shotstack.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}