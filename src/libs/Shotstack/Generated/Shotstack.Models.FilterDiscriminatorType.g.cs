
#nullable enable

namespace Shotstack
{
    /// <summary>
    ///
    /// </summary>
    public enum FilterDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Blur,
        /// <summary>
        ///
        /// </summary>
        Brightness,
        /// <summary>
        ///
        /// </summary>
        Contrast,
        /// <summary>
        ///
        /// </summary>
        Grade,
        /// <summary>
        ///
        /// </summary>
        Hue,
        /// <summary>
        ///
        /// </summary>
        Negative,
        /// <summary>
        ///
        /// </summary>
        Pixelate,
        /// <summary>
        ///
        /// </summary>
        RgbSplit,
        /// <summary>
        ///
        /// </summary>
        Saturation,
        /// <summary>
        ///
        /// </summary>
        Sharpen,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterDiscriminatorType value)
        {
            return value switch
            {
                FilterDiscriminatorType.Blur => "blur",
                FilterDiscriminatorType.Brightness => "brightness",
                FilterDiscriminatorType.Contrast => "contrast",
                FilterDiscriminatorType.Grade => "grade",
                FilterDiscriminatorType.Hue => "hue",
                FilterDiscriminatorType.Negative => "negative",
                FilterDiscriminatorType.Pixelate => "pixelate",
                FilterDiscriminatorType.RgbSplit => "rgbSplit",
                FilterDiscriminatorType.Saturation => "saturation",
                FilterDiscriminatorType.Sharpen => "sharpen",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "blur" => FilterDiscriminatorType.Blur,
                "brightness" => FilterDiscriminatorType.Brightness,
                "contrast" => FilterDiscriminatorType.Contrast,
                "grade" => FilterDiscriminatorType.Grade,
                "hue" => FilterDiscriminatorType.Hue,
                "negative" => FilterDiscriminatorType.Negative,
                "pixelate" => FilterDiscriminatorType.Pixelate,
                "rgbSplit" => FilterDiscriminatorType.RgbSplit,
                "saturation" => FilterDiscriminatorType.Saturation,
                "sharpen" => FilterDiscriminatorType.Sharpen,
                _ => null,
            };
        }
    }
}