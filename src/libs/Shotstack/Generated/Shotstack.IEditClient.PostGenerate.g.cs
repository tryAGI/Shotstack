#nullable enable

namespace Shotstack
{
    public partial interface IEditClient
    {
        /// <summary>
        /// Generate Asset<br/>
        /// Generate a single image, video or audio asset from a text prompt without<br/>
        /// rendering a full edit. Submit a prompt-bearing asset; the response is<br/>
        /// immediate when an identical asset has been generated before (results are<br/>
        /// cached by prompt, model and options), otherwise the job is queued and can<br/>
        /// be polled via the status endpoint.<br/>
        /// Generation is billed in credits per asset. Identical repeat requests<br/>
        /// resolve from the cache at no charge.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/edit/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Shotstack.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Shotstack.GenerationResponse> PostGenerateAsync(

            global::Shotstack.PostGenerateRequest request,
            string? idempotencyKey = default,
            global::Shotstack.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Asset<br/>
        /// Generate a single image, video or audio asset from a text prompt without<br/>
        /// rendering a full edit. Submit a prompt-bearing asset; the response is<br/>
        /// immediate when an identical asset has been generated before (results are<br/>
        /// cached by prompt, model and options), otherwise the job is queued and can<br/>
        /// be polled via the status endpoint.<br/>
        /// Generation is billed in credits per asset. Identical repeat requests<br/>
        /// resolve from the cache at no charge.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/edit/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Shotstack.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Shotstack.AutoSDKHttpResponse<global::Shotstack.GenerationResponse>> PostGenerateAsResponseAsync(

            global::Shotstack.PostGenerateRequest request,
            string? idempotencyKey = default,
            global::Shotstack.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Asset<br/>
        /// Generate a single image, video or audio asset from a text prompt without<br/>
        /// rendering a full edit. Submit a prompt-bearing asset; the response is<br/>
        /// immediate when an identical asset has been generated before (results are<br/>
        /// cached by prompt, model and options), otherwise the job is queued and can<br/>
        /// be polled via the status endpoint.<br/>
        /// Generation is billed in credits per asset. Identical repeat requests<br/>
        /// resolve from the cache at no charge.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/edit/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key. When omitted, the SDK generates one for this request.
        /// </param>
        /// <param name="asset"></param>
        /// <param name="length">
        /// The length, in seconds, of the clip the asset fills. A model that generates to a duration takes it from this value in place of its own duration option. Other models ignore it.<br/>
        /// Example: 5
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Shotstack.GenerationResponse> PostGenerateAsync(
            global::Shotstack.OneOf<global::Shotstack.ImageAsset, global::Shotstack.VideoAsset, global::Shotstack.AudioAsset> asset,
            string? idempotencyKey = default,
            double? length = default,
            global::Shotstack.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}