
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Settings for the chosen `model`. `GET /models` lists the options each model accepts; omitted options use the model's defaults and unknown or invalid options are rejected. A starting image for video goes in `startSrc` (`inputSrc` on the original image-to-video models) and a speech voice in `voice`.<br/>
    /// Example: {"aspectRatio":"16:9"}
    /// </summary>
    public sealed partial class GenerationAssetOptions
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}