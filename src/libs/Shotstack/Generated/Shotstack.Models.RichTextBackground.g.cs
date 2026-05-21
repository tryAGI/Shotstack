
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Background styling properties for the text bounding box.
    /// </summary>
    public sealed partial class RichTextBackground
    {
        /// <summary>
        /// The background color using hexadecimal color notation.<br/>
        /// Example: #000000
        /// </summary>
        /// <example>#000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// The opacity of the background where 1 is opaque and 0 is transparent.<br/>
        /// Default Value: 1<br/>
        /// Example: 0.5F
        /// </summary>
        /// <example>0.5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("opacity")]
        public double? Opacity { get; set; }

        /// <summary>
        /// The border radius of the background box in pixels. Must be 0 or greater.<br/>
        /// Default Value: 0<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("borderRadius")]
        public double? BorderRadius { get; set; }

        /// <summary>
        /// When true, the background pill shrinks to fit the rendered text bounding box plus the<br/>
        /// asset's padding (and stroke width, if present), producing a pill or badge effect. When<br/>
        /// false (default), the background fills the full asset content area. Available on<br/>
        /// rich-text and rich-caption assets only; not supported on legacy `type: text`.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("wrap")]
        public bool? Wrap { get; set; }

        /// <summary>
        /// Inner padding in pixels between the wrap pill edge and the rendered text. Only takes<br/>
        /// effect when `wrap: true`. When omitted, the renderer applies a sensible default<br/>
        /// proportional to the font size (approximately 12% of the active page font size on<br/>
        /// rich-caption assets). Set to 0 for a pill that hugs the text exactly. Available on<br/>
        /// rich-text and rich-caption assets only.<br/>
        /// Example: 12
        /// </summary>
        /// <example>12</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("padding")]
        public int? Padding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextBackground" /> class.
        /// </summary>
        /// <param name="color">
        /// The background color using hexadecimal color notation.<br/>
        /// Example: #000000
        /// </param>
        /// <param name="opacity">
        /// The opacity of the background where 1 is opaque and 0 is transparent.<br/>
        /// Default Value: 1<br/>
        /// Example: 0.5F
        /// </param>
        /// <param name="borderRadius">
        /// The border radius of the background box in pixels. Must be 0 or greater.<br/>
        /// Default Value: 0<br/>
        /// Example: 10
        /// </param>
        /// <param name="wrap">
        /// When true, the background pill shrinks to fit the rendered text bounding box plus the<br/>
        /// asset's padding (and stroke width, if present), producing a pill or badge effect. When<br/>
        /// false (default), the background fills the full asset content area. Available on<br/>
        /// rich-text and rich-caption assets only; not supported on legacy `type: text`.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="padding">
        /// Inner padding in pixels between the wrap pill edge and the rendered text. Only takes<br/>
        /// effect when `wrap: true`. When omitted, the renderer applies a sensible default<br/>
        /// proportional to the font size (approximately 12% of the active page font size on<br/>
        /// rich-caption assets). Set to 0 for a pill that hugs the text exactly. Available on<br/>
        /// rich-text and rich-caption assets only.<br/>
        /// Example: 12
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RichTextBackground(
            string? color,
            double? opacity,
            double? borderRadius,
            bool? wrap,
            int? padding)
        {
            this.Color = color;
            this.Opacity = opacity;
            this.BorderRadius = borderRadius;
            this.Wrap = wrap;
            this.Padding = padding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextBackground" /> class.
        /// </summary>
        public RichTextBackground()
        {
        }

    }
}