
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Animation properties for text entrance effects.
    /// </summary>
    public sealed partial class RichTextAnimation
    {
        /// <summary>
        /// The animation preset to apply. Every preset starts with the clip. Available presets: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`fadeIn` - fade in&lt;/li&gt;<br/>
        ///   &lt;li&gt;`slideIn` - fade in while sliding in `direction`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`typewriter` - type the text out behind a cursor&lt;/li&gt;<br/>
        ///   &lt;li&gt;`ascend` - each word rises (`up`) or drops (`down`) into place&lt;/li&gt;<br/>
        ///   &lt;li&gt;`shift` - fade in while shifting a short distance in `direction`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`movingLetters` - fade in, then ripple the letters along `direction` for the rest of the clip. Ignores `duration` and `style`.&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: shift
        /// </summary>
        /// <example>shift</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.RichTextAnimationPresetJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Shotstack.RichTextAnimationPreset Preset { get; set; }

        /// <summary>
        /// Override animation duration in seconds. Must be between 0.1 and 30 seconds. When omitted, the text animates at about 30 characters per second, taking at least 0.3 seconds and at most 90% of the clip.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Animate by character or by word. Applies to `fadeIn`, `slideIn`, `typewriter` and `shift`, where `shift` defaults to `character`. `ascend` always animates by word.<br/>
        /// Example: character
        /// </summary>
        /// <example>character</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.RichTextAnimationStyleJsonConverter))]
        public global::Shotstack.RichTextAnimationStyle? Style { get; set; }

        /// <summary>
        /// The direction the text travels. Defaults to `left` for `slideIn` and `shift`, and to `up` for `ascend` and `movingLetters`. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`ascend` - supports: up, down&lt;/li&gt;<br/>
        ///   &lt;li&gt;`shift` - supports: left, right, up, down&lt;/li&gt;<br/>
        ///   &lt;li&gt;`slideIn` - supports: left, right, up, down&lt;/li&gt;<br/>
        ///   &lt;li&gt;`movingLetters` - supports: left, right, up, down&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: up
        /// </summary>
        /// <example>up</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.RichTextAnimationDirectionJsonConverter))]
        public global::Shotstack.RichTextAnimationDirection? Direction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextAnimation" /> class.
        /// </summary>
        /// <param name="preset">
        /// The animation preset to apply. Every preset starts with the clip. Available presets: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`fadeIn` - fade in&lt;/li&gt;<br/>
        ///   &lt;li&gt;`slideIn` - fade in while sliding in `direction`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`typewriter` - type the text out behind a cursor&lt;/li&gt;<br/>
        ///   &lt;li&gt;`ascend` - each word rises (`up`) or drops (`down`) into place&lt;/li&gt;<br/>
        ///   &lt;li&gt;`shift` - fade in while shifting a short distance in `direction`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`movingLetters` - fade in, then ripple the letters along `direction` for the rest of the clip. Ignores `duration` and `style`.&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: shift
        /// </param>
        /// <param name="duration">
        /// Override animation duration in seconds. Must be between 0.1 and 30 seconds. When omitted, the text animates at about 30 characters per second, taking at least 0.3 seconds and at most 90% of the clip.<br/>
        /// Example: 2
        /// </param>
        /// <param name="style">
        /// Animate by character or by word. Applies to `fadeIn`, `slideIn`, `typewriter` and `shift`, where `shift` defaults to `character`. `ascend` always animates by word.<br/>
        /// Example: character
        /// </param>
        /// <param name="direction">
        /// The direction the text travels. Defaults to `left` for `slideIn` and `shift`, and to `up` for `ascend` and `movingLetters`. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`ascend` - supports: up, down&lt;/li&gt;<br/>
        ///   &lt;li&gt;`shift` - supports: left, right, up, down&lt;/li&gt;<br/>
        ///   &lt;li&gt;`slideIn` - supports: left, right, up, down&lt;/li&gt;<br/>
        ///   &lt;li&gt;`movingLetters` - supports: left, right, up, down&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: up
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RichTextAnimation(
            global::Shotstack.RichTextAnimationPreset preset,
            double? duration,
            global::Shotstack.RichTextAnimationStyle? style,
            global::Shotstack.RichTextAnimationDirection? direction)
        {
            this.Preset = preset;
            this.Duration = duration;
            this.Style = style;
            this.Direction = direction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextAnimation" /> class.
        /// </summary>
        public RichTextAnimation()
        {
        }

    }
}