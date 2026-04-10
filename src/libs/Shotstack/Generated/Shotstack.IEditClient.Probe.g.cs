#nullable enable

namespace Shotstack
{
    public partial interface IEditClient
    {
        /// <summary>
        /// Inspect Media<br/>
        /// Inspects any media asset (image, video, audio) on the internet using a hosted version<br/>
        /// of [FFprobe](https://ffmpeg.org/ffprobe.html). The probe endpoint returns useful information<br/>
        /// about an asset such as width, height, duration, rotation, framerate, etc...<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/edit/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="url"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Shotstack.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Shotstack.ProbeResponse> ProbeAsync(
            string url,
            global::Shotstack.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}