
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The filter type - set to `sharpen`.
    /// </summary>
    public enum SharpenFilterType
    {
        /// <summary>
        ///
        /// </summary>
        Sharpen,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SharpenFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SharpenFilterType value)
        {
            return value switch
            {
                SharpenFilterType.Sharpen => "sharpen",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SharpenFilterType? ToEnum(string value)
        {
            return value switch
            {
                "sharpen" => SharpenFilterType.Sharpen,
                _ => null,
            };
        }
    }
}