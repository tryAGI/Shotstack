#nullable enable

namespace Shotstack
{
    public partial interface ICreateClient
    {
        /// <summary>
        /// Get Generated Asset<br/>
        /// Get the generated assets status, url and details by ID.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/create/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Shotstack.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Shotstack.GeneratedAssetResponse> GetGeneratedAssetAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}