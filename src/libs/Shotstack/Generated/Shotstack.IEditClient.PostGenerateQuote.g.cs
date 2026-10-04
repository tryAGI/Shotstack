#nullable enable

namespace Shotstack
{
    public partial interface IEditClient
    {
        /// <summary>
        /// Quote Generation<br/>
        /// Estimate credits for the same asset and clip length accepted by `POST /generate`.<br/>
        /// Requires an API key and the same model access as generation. Invalid options and<br/>
        /// disallowed source URLs are rejected. No provider request, job, quota usage or credit<br/>
        /// reservation is created. A quote does not guarantee an available balance or quota.<br/>
        /// Prices are evaluated at request time. Request another quote when settings change;<br/>
        /// generation uses the current price when submitted.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/edit/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Shotstack.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Shotstack.GenerationQuote> PostGenerateQuoteAsync(

            global::Shotstack.GenerationRequest request,
            global::Shotstack.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Quote Generation<br/>
        /// Estimate credits for the same asset and clip length accepted by `POST /generate`.<br/>
        /// Requires an API key and the same model access as generation. Invalid options and<br/>
        /// disallowed source URLs are rejected. No provider request, job, quota usage or credit<br/>
        /// reservation is created. A quote does not guarantee an available balance or quota.<br/>
        /// Prices are evaluated at request time. Request another quote when settings change;<br/>
        /// generation uses the current price when submitted.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/edit/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Shotstack.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Shotstack.AutoSDKHttpResponse<global::Shotstack.GenerationQuote>> PostGenerateQuoteAsResponseAsync(

            global::Shotstack.GenerationRequest request,
            global::Shotstack.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Quote Generation<br/>
        /// Estimate credits for the same asset and clip length accepted by `POST /generate`.<br/>
        /// Requires an API key and the same model access as generation. Invalid options and<br/>
        /// disallowed source URLs are rejected. No provider request, job, quota usage or credit<br/>
        /// reservation is created. A quote does not guarantee an available balance or quota.<br/>
        /// Prices are evaluated at request time. Request another quote when settings change;<br/>
        /// generation uses the current price when submitted.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/edit/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="asset">
        /// An image, video or audio asset to generate from a text prompt.
        /// </param>
        /// <param name="length">
        /// The length, in seconds, of the clip the asset fills. A model that generates to a duration takes it from this value in place of its own duration option. Other models ignore it.<br/>
        /// Example: 5
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Shotstack.GenerationQuote> PostGenerateQuoteAsync(
            global::Shotstack.GenerationAsset asset,
            double? length = default,
            global::Shotstack.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}