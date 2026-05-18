
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The Html5Asset renders full HTML5/CSS3/JS.
    /// </summary>
    public sealed partial class Html5Asset
    {
        /// <summary>
        /// The type of asset - set to `html5` for HTML5/CSS3/JS.<br/>
        /// Default Value: html5
        /// </summary>
        /// <default>global::Shotstack.Html5AssetType.Html5</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.Html5AssetTypeJsonConverter))]
        public global::Shotstack.Html5AssetType Type { get; set; } = global::Shotstack.Html5AssetType.Html5;

        /// <summary>
        /// The HTML markup for the asset. Max 1,000,000 characters.<br/>
        /// Example: &lt;div class='card'&gt;&lt;h1&gt;{{title}}&lt;/h1&gt;&lt;/div&gt;
        /// </summary>
        /// <example>&lt;div class='card'&gt;&lt;h1&gt;{{title}}&lt;/h1&gt;&lt;/div&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Html { get; set; }

        /// <summary>
        /// The CSS string applied to the HTML. Max 500,000 characters.<br/>
        /// Example: .card { font-family: 'Inter'; padding: 32px; }
        /// </summary>
        /// <example>.card { font-family: 'Inter'; padding: 32px; }</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("css")]
        public string? Css { get; set; }

        /// <summary>
        /// Optional JavaScript. Use for chart libraries, animations, or DOM manipulation. `gsap`, `d3`, `anime` and `lottie` are always available. CSS animations, transitions, and `Element.animate()` are also captured automatically. Max 500,000 characters.<br/>
        /// Example: gsap.to('.card', { x: 200, duration: 1 });
        /// </summary>
        /// <example>gsap.to('.card', { x: 200, duration: 1 });</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("js")]
        public string? Js { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Html5Asset" /> class.
        /// </summary>
        /// <param name="html">
        /// The HTML markup for the asset. Max 1,000,000 characters.<br/>
        /// Example: &lt;div class='card'&gt;&lt;h1&gt;{{title}}&lt;/h1&gt;&lt;/div&gt;
        /// </param>
        /// <param name="css">
        /// The CSS string applied to the HTML. Max 500,000 characters.<br/>
        /// Example: .card { font-family: 'Inter'; padding: 32px; }
        /// </param>
        /// <param name="js">
        /// Optional JavaScript. Use for chart libraries, animations, or DOM manipulation. `gsap`, `d3`, `anime` and `lottie` are always available. CSS animations, transitions, and `Element.animate()` are also captured automatically. Max 500,000 characters.<br/>
        /// Example: gsap.to('.card', { x: 200, duration: 1 });
        /// </param>
        /// <param name="type">
        /// The type of asset - set to `html5` for HTML5/CSS3/JS.<br/>
        /// Default Value: html5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Html5Asset(
            string html,
            string? css,
            string? js,
            global::Shotstack.Html5AssetType type = global::Shotstack.Html5AssetType.Html5)
        {
            this.Type = type;
            this.Html = html ?? throw new global::System.ArgumentNullException(nameof(html));
            this.Css = css;
            this.Js = js;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Html5Asset" /> class.
        /// </summary>
        public Html5Asset()
        {
        }

        /// <summary>
        /// Creates a new <see cref="Html5Asset"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static Html5Asset FromHtml(string html)
        {
            return new Html5Asset
            {
                Html = html,
            };
        }

    }
}