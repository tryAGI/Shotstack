
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The filter type - set to `brightness`.
    /// </summary>
    public enum BrightnessFilterType
    {
        /// <summary>
        ///
        /// </summary>
        Brightness,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BrightnessFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BrightnessFilterType value)
        {
            return value switch
            {
                BrightnessFilterType.Brightness => "brightness",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BrightnessFilterType? ToEnum(string value)
        {
            return value switch
            {
                "brightness" => BrightnessFilterType.Brightness,
                _ => null,
            };
        }
    }
}