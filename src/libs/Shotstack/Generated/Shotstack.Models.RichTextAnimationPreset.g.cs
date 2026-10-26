
#nullable enable

namespace Shotstack
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
    public enum RichTextAnimationPreset
    {
        /// <summary>
        ///
        /// </summary>
        Ascend,
        /// <summary>
        ///
        /// </summary>
        FadeIn,
        /// <summary>
        ///
        /// </summary>
        MovingLetters,
        /// <summary>
        ///
        /// </summary>
        Shift,
        /// <summary>
        ///
        /// </summary>
        SlideIn,
        /// <summary>
        ///
        /// </summary>
        Typewriter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RichTextAnimationPresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RichTextAnimationPreset value)
        {
            return value switch
            {
                RichTextAnimationPreset.Ascend => "ascend",
                RichTextAnimationPreset.FadeIn => "fadeIn",
                RichTextAnimationPreset.MovingLetters => "movingLetters",
                RichTextAnimationPreset.Shift => "shift",
                RichTextAnimationPreset.SlideIn => "slideIn",
                RichTextAnimationPreset.Typewriter => "typewriter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RichTextAnimationPreset? ToEnum(string value)
        {
            return value switch
            {
                "ascend" => RichTextAnimationPreset.Ascend,
                "fadeIn" => RichTextAnimationPreset.FadeIn,
                "movingLetters" => RichTextAnimationPreset.MovingLetters,
                "shift" => RichTextAnimationPreset.Shift,
                "slideIn" => RichTextAnimationPreset.SlideIn,
                "typewriter" => RichTextAnimationPreset.Typewriter,
                _ => null,
            };
        }
    }
}