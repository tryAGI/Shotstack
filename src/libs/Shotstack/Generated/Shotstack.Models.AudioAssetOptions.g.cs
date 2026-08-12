
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Model-specific generation settings. Valid keys and values depend on the chosen `model` and are defined by the model registry. Omitted options use the model's defaults. Unknown or invalid options are rejected.<br/>
    /// Example: {"voice":"Matthew","language":"en-US"}
    /// </summary>
    public sealed partial class AudioAssetOptions
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}