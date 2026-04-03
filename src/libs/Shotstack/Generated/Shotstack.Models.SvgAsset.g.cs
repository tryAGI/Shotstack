
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The SvgAsset is used to add scalable vector graphics (SVG) to a video using raw SVG markup.<br/>
    /// **Supported elements:** `&lt;path&gt;`, `&lt;rect&gt;`, `&lt;circle&gt;`, `&lt;ellipse&gt;`,<br/>
    /// `&lt;line&gt;`, `&lt;polygon&gt;`, `&lt;polyline&gt;`<br/>
    /// **Automatically extracted from SVG markup:**<br/>
    /// - Path data (converted to a single combined path)<br/>
    /// - Fill color (from `fill` attribute or `style`)<br/>
    /// - Stroke color and width (from attributes or `style`)<br/>
    /// - Dimensions (from `width`/`height` or `viewBox`)<br/>
    /// - Opacity (from `opacity` attribute)<br/>
    /// See [W3C SVG 2 Specification](https://www.w3.org/TR/SVG2/) for path data syntax.<br/>
    /// Example: {"type":"svg","src":"\u003Csvg width=\u0022100\u0022 height=\u0022100\u0022\u003E\u003Ccircle cx=\u002250\u0022 cy=\u002250\u0022 r=\u002240\u0022 fill=\u0022#3498db\u0022/\u003E\u003C/svg\u003E"}
    /// </summary>
    public sealed partial class SvgAsset
    {
        /// <summary>
        /// The asset type - set to `svg` for SVG assets.<br/>
        /// Default Value: svg<br/>
        /// Example: svg
        /// </summary>
        /// <default>global::Shotstack.SvgAssetType.Svg</default>
        /// <example>svg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.SvgAssetTypeJsonConverter))]
        public global::Shotstack.SvgAssetType Type { get; set; } = global::Shotstack.SvgAssetType.Svg;

        /// <summary>
        /// Raw SVG markup string. The SVG must contain valid SVG elements. The shape,<br/>
        /// fill, stroke, dimensions and opacity are automatically extracted from the<br/>
        /// SVG content.<br/>
        /// Example: &lt;svg width="100" height="100"&gt;&lt;circle cx="50" cy="50" r="40" fill="#3498db"/&gt;&lt;/svg&gt;
        /// </summary>
        /// <example>&lt;svg width="100" height="100"&gt;&lt;circle cx="50" cy="50" r="40" fill="#3498db"/&gt;&lt;/svg&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Src { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgAsset" /> class.
        /// </summary>
        /// <param name="src">
        /// Raw SVG markup string. The SVG must contain valid SVG elements. The shape,<br/>
        /// fill, stroke, dimensions and opacity are automatically extracted from the<br/>
        /// SVG content.<br/>
        /// Example: &lt;svg width="100" height="100"&gt;&lt;circle cx="50" cy="50" r="40" fill="#3498db"/&gt;&lt;/svg&gt;
        /// </param>
        /// <param name="type">
        /// The asset type - set to `svg` for SVG assets.<br/>
        /// Default Value: svg<br/>
        /// Example: svg
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SvgAsset(
            string src,
            global::Shotstack.SvgAssetType type = global::Shotstack.SvgAssetType.Svg)
        {
            this.Type = type;
            this.Src = src ?? throw new global::System.ArgumentNullException(nameof(src));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgAsset" /> class.
        /// </summary>
        public SvgAsset()
        {
        }
    }
}