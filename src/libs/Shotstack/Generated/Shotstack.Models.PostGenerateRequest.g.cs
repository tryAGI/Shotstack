
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostGenerateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<global::Shotstack.ImageAsset, global::Shotstack.VideoAsset, global::Shotstack.AudioAsset>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Shotstack.OneOf<global::Shotstack.ImageAsset, global::Shotstack.VideoAsset, global::Shotstack.AudioAsset> Asset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostGenerateRequest" /> class.
        /// </summary>
        /// <param name="asset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostGenerateRequest(
            global::Shotstack.OneOf<global::Shotstack.ImageAsset, global::Shotstack.VideoAsset, global::Shotstack.AudioAsset> asset)
        {
            this.Asset = asset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostGenerateRequest" /> class.
        /// </summary>
        public PostGenerateRequest()
        {
        }

    }
}