
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Font properties for the active/highlighted word.
    /// </summary>
    public sealed partial class RichCaptionActiveFont
    {
        /// <summary>
        /// The font family for the active word. Inherits from the base font.family when not set.<br/>
        /// Example: Roboto
        /// </summary>
        /// <example>Roboto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("family")]
        public string? Family { get; set; }

        /// <summary>
        /// The weight of the font for the active word. Can be a number (100-900) or a string. Inherits from the base font.weight when not set.<br/>
        /// Default Value: 400
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public object? Weight { get; set; }

        /// <summary>
        /// The active word color using hexadecimal color notation.<br/>
        /// Example: #C96741
        /// </summary>
        /// <example>#C96741</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// The background color behind the active word using hexadecimal color notation.<br/>
        /// Example: #000000
        /// </summary>
        /// <example>#000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public string? Background { get; set; }

        /// <summary>
        /// The opacity of the active word where 1 is opaque and 0 is transparent.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("opacity")]
        public double? Opacity { get; set; }

        /// <summary>
        /// The font size of the active word in pixels.<br/>
        /// Example: 120
        /// </summary>
        /// <example>120</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public double? Size { get; set; }

        /// <summary>
        /// Text decoration to apply to the active word.<br/>
        /// Default Value: none<br/>
        /// Example: underline
        /// </summary>
        /// <example>underline</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("textDecoration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.RichCaptionActiveFontTextDecorationJsonConverter))]
        public global::Shotstack.RichCaptionActiveFontTextDecoration? TextDecoration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RichCaptionActiveFont" /> class.
        /// </summary>
        /// <param name="family">
        /// The font family for the active word. Inherits from the base font.family when not set.<br/>
        /// Example: Roboto
        /// </param>
        /// <param name="weight">
        /// The weight of the font for the active word. Can be a number (100-900) or a string. Inherits from the base font.weight when not set.<br/>
        /// Default Value: 400
        /// </param>
        /// <param name="color">
        /// The active word color using hexadecimal color notation.<br/>
        /// Example: #C96741
        /// </param>
        /// <param name="background">
        /// The background color behind the active word using hexadecimal color notation.<br/>
        /// Example: #000000
        /// </param>
        /// <param name="opacity">
        /// The opacity of the active word where 1 is opaque and 0 is transparent.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="size">
        /// The font size of the active word in pixels.<br/>
        /// Example: 120
        /// </param>
        /// <param name="textDecoration">
        /// Text decoration to apply to the active word.<br/>
        /// Default Value: none<br/>
        /// Example: underline
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RichCaptionActiveFont(
            string? family,
            object? weight,
            string? color,
            string? background,
            double? opacity,
            double? size,
            global::Shotstack.RichCaptionActiveFontTextDecoration? textDecoration)
        {
            this.Family = family;
            this.Weight = weight;
            this.Color = color;
            this.Background = background;
            this.Opacity = opacity;
            this.Size = size;
            this.TextDecoration = textDecoration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RichCaptionActiveFont" /> class.
        /// </summary>
        public RichCaptionActiveFont()
        {
        }
    }
}