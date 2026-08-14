
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The font style.<br/>
    /// Default Value: normal<br/>
    /// Example: italic
    /// </summary>
    public enum RichCaptionFontStyle
    {
        /// <summary>
        /// 
        /// </summary>
        Italic,
        /// <summary>
        /// 
        /// </summary>
        Normal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RichCaptionFontStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RichCaptionFontStyle value)
        {
            return value switch
            {
                RichCaptionFontStyle.Italic => "italic",
                RichCaptionFontStyle.Normal => "normal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RichCaptionFontStyle? ToEnum(string value)
        {
            return value switch
            {
                "italic" => RichCaptionFontStyle.Italic,
                "normal" => RichCaptionFontStyle.Normal,
                _ => null,
            };
        }
    }
}