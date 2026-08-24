#nullable enable

namespace Shotstack
{
    public partial interface IEditClient
    {
        /// <summary>
        /// Get Generation Model<br/>
        /// Get one generation model, including the JSON Schema for the options it accepts and<br/>
        /// what it costs in credits.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/edit/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Shotstack.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Shotstack.GenerationModel> GetModelAsync(
            string id,
            global::Shotstack.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Generation Model<br/>
        /// Get one generation model, including the JSON Schema for the options it accepts and<br/>
        /// what it costs in credits.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/edit/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Shotstack.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Shotstack.AutoSDKHttpResponse<global::Shotstack.GenerationModel>> GetModelAsResponseAsync(
            string id,
            global::Shotstack.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}