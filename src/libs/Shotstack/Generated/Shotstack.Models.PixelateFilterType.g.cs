
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The filter type - set to `pixelate`.
    /// </summary>
    public enum PixelateFilterType
    {
        /// <summary>
        ///
        /// </summary>
        Pixelate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PixelateFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PixelateFilterType value)
        {
            return value switch
            {
                PixelateFilterType.Pixelate => "pixelate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PixelateFilterType? ToEnum(string value)
        {
            return value switch
            {
                "pixelate" => PixelateFilterType.Pixelate,
                _ => null,
            };
        }
    }
}