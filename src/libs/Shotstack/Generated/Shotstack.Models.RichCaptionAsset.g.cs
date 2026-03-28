
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The RichCaptionAsset provides word-level caption animations with rich-text styling. It supports<br/>
    /// karaoke-style highlighting, word-by-word animations, and advanced typography. Use with SRT/VTT<br/>
    /// files or auto-transcription via aliases.
    /// </summary>
    public sealed partial class RichCaptionAsset
    {
        /// <summary>
        /// The type of asset - set to `rich-caption` for rich captions.<br/>
        /// Default Value: rich-caption
        /// </summary>
        /// <default>global::Shotstack.RichCaptionAssetType.RichCaption</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.RichCaptionAssetTypeJsonConverter))]
        public global::Shotstack.RichCaptionAssetType Type { get; set; } = global::Shotstack.RichCaptionAssetType.RichCaption;

        /// <summary>
        /// The URL to an SRT or VTT subtitles file, or an alias reference to auto-generate captions from an audio or video clip. For file URLs, the URL must be publicly accessible or include credentials. For auto-captioning, use the format `alias://clip-name` where clip-name is the alias of an audio, video, or text-to-speech clip.<br/>
        /// Example: alias://audio
        /// </summary>
        /// <example>alias://audio</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Src { get; set; }

        /// <summary>
        /// Font properties for rich captions. Defaults to Roboto.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font")]
        public global::Shotstack.RichCaptionFont? Font { get; set; }

        /// <summary>
        /// Text style properties for rich captions. Same as RichTextStyle but without wordSpacing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public global::Shotstack.RichCaptionStyle? Style { get; set; }

        /// <summary>
        /// Text stroke (outline) properties.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stroke")]
        public global::Shotstack.RichTextStroke? Stroke { get; set; }

        /// <summary>
        /// Text shadow properties.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shadow")]
        public global::Shotstack.RichTextShadow? Shadow { get; set; }

        /// <summary>
        /// Background styling properties for the text bounding box.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public global::Shotstack.RichTextBackground? Background { get; set; }

        /// <summary>
        /// Border styling properties for the text bounding box.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("border")]
        public global::Shotstack.RichTextBorder? Border { get; set; }

        /// <summary>
        /// Padding inside the caption bounding box. Can be a single number (applied to all sides) or an object with individual sides.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("padding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<double?, global::Shotstack.RichTextPadding>))]
        public global::Shotstack.OneOf<double?, global::Shotstack.RichTextPadding>? Padding { get; set; }

        /// <summary>
        /// Text alignment properties (horizontal and vertical).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("align")]
        public global::Shotstack.RichTextAlignment? Align { get; set; }

        /// <summary>
        /// Styling properties for the active/highlighted word.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public global::Shotstack.RichCaptionActive? Active { get; set; }

        /// <summary>
        /// Word-level animation properties for caption effects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("animation")]
        public global::Shotstack.RichCaptionAnimation? Animation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RichCaptionAsset" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of asset - set to `rich-caption` for rich captions.<br/>
        /// Default Value: rich-caption
        /// </param>
        /// <param name="src">
        /// The URL to an SRT or VTT subtitles file, or an alias reference to auto-generate captions from an audio or video clip. For file URLs, the URL must be publicly accessible or include credentials. For auto-captioning, use the format `alias://clip-name` where clip-name is the alias of an audio, video, or text-to-speech clip.<br/>
        /// Example: alias://audio
        /// </param>
        /// <param name="font">
        /// Font properties for rich captions. Defaults to Roboto.
        /// </param>
        /// <param name="style">
        /// Text style properties for rich captions. Same as RichTextStyle but without wordSpacing.
        /// </param>
        /// <param name="stroke">
        /// Text stroke (outline) properties.
        /// </param>
        /// <param name="shadow">
        /// Text shadow properties.
        /// </param>
        /// <param name="background">
        /// Background styling properties for the text bounding box.
        /// </param>
        /// <param name="border">
        /// Border styling properties for the text bounding box.
        /// </param>
        /// <param name="padding">
        /// Padding inside the caption bounding box. Can be a single number (applied to all sides) or an object with individual sides.
        /// </param>
        /// <param name="align">
        /// Text alignment properties (horizontal and vertical).
        /// </param>
        /// <param name="active">
        /// Styling properties for the active/highlighted word.
        /// </param>
        /// <param name="animation">
        /// Word-level animation properties for caption effects.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RichCaptionAsset(
            string src,
            global::Shotstack.RichCaptionFont? font,
            global::Shotstack.RichCaptionStyle? style,
            global::Shotstack.RichTextStroke? stroke,
            global::Shotstack.RichTextShadow? shadow,
            global::Shotstack.RichTextBackground? background,
            global::Shotstack.RichTextBorder? border,
            global::Shotstack.OneOf<double?, global::Shotstack.RichTextPadding>? padding,
            global::Shotstack.RichTextAlignment? align,
            global::Shotstack.RichCaptionActive? active,
            global::Shotstack.RichCaptionAnimation? animation,
            global::Shotstack.RichCaptionAssetType type = global::Shotstack.RichCaptionAssetType.RichCaption)
        {
            this.Src = src ?? throw new global::System.ArgumentNullException(nameof(src));
            this.Type = type;
            this.Font = font;
            this.Style = style;
            this.Stroke = stroke;
            this.Shadow = shadow;
            this.Background = background;
            this.Border = border;
            this.Padding = padding;
            this.Align = align;
            this.Active = active;
            this.Animation = animation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RichCaptionAsset" /> class.
        /// </summary>
        public RichCaptionAsset()
        {
        }
    }
}