
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The filter type - set to `hue`.
    /// </summary>
    public enum HueFilterType
    {
        /// <summary>
        ///
        /// </summary>
        Hue,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HueFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HueFilterType value)
        {
            return value switch
            {
                HueFilterType.Hue => "hue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HueFilterType? ToEnum(string value)
        {
            return value switch
            {
                "hue" => HueFilterType.Hue,
                _ => null,
            };
        }
    }
}