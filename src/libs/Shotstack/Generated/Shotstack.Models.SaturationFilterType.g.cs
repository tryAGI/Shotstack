
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The filter type - set to `saturation`.
    /// </summary>
    public enum SaturationFilterType
    {
        /// <summary>
        ///
        /// </summary>
        Saturation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SaturationFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SaturationFilterType value)
        {
            return value switch
            {
                SaturationFilterType.Saturation => "saturation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SaturationFilterType? ToEnum(string value)
        {
            return value switch
            {
                "saturation" => SaturationFilterType.Saturation,
                _ => null,
            };
        }
    }
}