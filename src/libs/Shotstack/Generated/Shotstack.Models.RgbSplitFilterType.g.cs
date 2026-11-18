
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The filter type - set to `rgbSplit`.
    /// </summary>
    public enum RgbSplitFilterType
    {
        /// <summary>
        ///
        /// </summary>
        RgbSplit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RgbSplitFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RgbSplitFilterType value)
        {
            return value switch
            {
                RgbSplitFilterType.RgbSplit => "rgbSplit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RgbSplitFilterType? ToEnum(string value)
        {
            return value switch
            {
                "rgbSplit" => RgbSplitFilterType.RgbSplit,
                _ => null,
            };
        }
    }
}