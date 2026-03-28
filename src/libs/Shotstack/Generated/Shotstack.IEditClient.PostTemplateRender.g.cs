#nullable enable

namespace Shotstack
{
    public partial interface IEditClient
    {
        /// <summary>
        /// Render Template<br/>
        /// Render an asset from a template id and optional merge fields. Merge fields can be used to replace placeholder<br/>
        /// variables within the [Edit](#tocs_edit).<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/edit/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Shotstack.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Shotstack.QueuedResponse> PostTemplateRenderAsync(

            global::Shotstack.TemplateRender request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Render Template<br/>
        /// Render an asset from a template id and optional merge fields. Merge fields can be used to replace placeholder<br/>
        /// variables within the [Edit](#tocs_edit).<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/edit/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="id">
        /// The id of the template to render in UUID format.<br/>
        /// Example: f5493c17-d01f-445c-bb49-535fae65f219
        /// </param>
        /// <param name="merge">
        /// An array of key/value pairs that provides an easy way to create templates with placeholders. The placeholders can be used to find and replace keys with values. For example you can search for the placeholder `{{NAME}}` and replace it with the value `Jane`. 
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Shotstack.QueuedResponse> PostTemplateRenderAsync(
            string id,
            global::System.Collections.Generic.IList<global::Shotstack.MergeField>? merge = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}