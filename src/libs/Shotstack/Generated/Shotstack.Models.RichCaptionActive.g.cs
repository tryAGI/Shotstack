
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Styling properties for the active/highlighted word.
    /// </summary>
    public sealed partial class RichCaptionActive
    {
        /// <summary>
        /// Font properties for the active/highlighted word.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font")]
        public global::Shotstack.RichCaptionActiveFont? Font { get; set; }

        /// <summary>
        /// Stroke properties for the active word. Set to "none" to explicitly remove the base stroke on the active word.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stroke")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<global::Shotstack.RichTextStroke, global::Shotstack.RichCaptionActiveStroke?>))]
        public global::Shotstack.OneOf<global::Shotstack.RichTextStroke, global::Shotstack.RichCaptionActiveStroke?>? Stroke { get; set; }

        /// <summary>
        /// Shadow properties for the active word. Set to "none" to explicitly remove the base shadow on the active word.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shadow")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<global::Shotstack.RichTextShadow, global::Shotstack.RichCaptionActiveShadow?>))]
        public global::Shotstack.OneOf<global::Shotstack.RichTextShadow, global::Shotstack.RichCaptionActiveShadow?>? Shadow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RichCaptionActive" /> class.
        /// </summary>
        /// <param name="font">
        /// Font properties for the active/highlighted word.
        /// </param>
        /// <param name="stroke">
        /// Stroke properties for the active word. Set to "none" to explicitly remove the base stroke on the active word.
        /// </param>
        /// <param name="shadow">
        /// Shadow properties for the active word. Set to "none" to explicitly remove the base shadow on the active word.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RichCaptionActive(
            global::Shotstack.RichCaptionActiveFont? font,
            global::Shotstack.OneOf<global::Shotstack.RichTextStroke, global::Shotstack.RichCaptionActiveStroke?>? stroke,
            global::Shotstack.OneOf<global::Shotstack.RichTextShadow, global::Shotstack.RichCaptionActiveShadow?>? shadow)
        {
            this.Font = font;
            this.Stroke = stroke;
            this.Shadow = shadow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RichCaptionActive" /> class.
        /// </summary>
        public RichCaptionActive()
        {
        }
    }
}