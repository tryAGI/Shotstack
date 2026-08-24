#nullable enable

namespace Shotstack
{
    public partial interface IEditClient
    {
        /// <summary>
        /// List Generation Models<br/>
        /// List the generation models available for `prompt`-bearing image, video and audio<br/>
        /// assets, with the options each accepts and what it costs in credits.<br/>
        /// Use this to populate a model picker and render its option fields, rather than<br/>
        /// hard coding a model list. A newly launched model appears here without any change<br/>
        /// on your side. Each entry carries the asset type it generates, so filter the list<br/>
        /// client side when a picker only needs one kind.<br/>
        /// Option schemas are omitted by default. Request them with `expand=options`.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/edit/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Shotstack.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Shotstack.GenerationModelListResponse> GetModelsAsync(
            global::Shotstack.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Generation Models<br/>
        /// List the generation models available for `prompt`-bearing image, video and audio<br/>
        /// assets, with the options each accepts and what it costs in credits.<br/>
        /// Use this to populate a model picker and render its option fields, rather than<br/>
        /// hard coding a model list. A newly launched model appears here without any change<br/>
        /// on your side. Each entry carries the asset type it generates, so filter the list<br/>
        /// client side when a picker only needs one kind.<br/>
        /// Option schemas are omitted by default. Request them with `expand=options`.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/edit/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Shotstack.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Shotstack.AutoSDKHttpResponse<global::Shotstack.GenerationModelListResponse>> GetModelsAsResponseAsync(
            global::Shotstack.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}