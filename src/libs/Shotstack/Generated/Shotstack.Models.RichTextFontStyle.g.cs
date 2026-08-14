
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The font style.<br/>
    /// Default Value: normal<br/>
    /// Example: italic
    /// </summary>
    public enum RichTextFontStyle
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
    public static class RichTextFontStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RichTextFontStyle value)
        {
            return value switch
            {
                RichTextFontStyle.Italic => "italic",
                RichTextFontStyle.Normal => "normal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RichTextFontStyle? ToEnum(string value)
        {
            return value switch
            {
                "italic" => RichTextFontStyle.Italic,
                "normal" => RichTextFontStyle.Normal,
                _ => null,
            };
        }
    }
}