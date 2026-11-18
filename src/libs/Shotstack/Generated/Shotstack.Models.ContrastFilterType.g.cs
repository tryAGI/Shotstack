
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The filter type - set to `contrast`.
    /// </summary>
    public enum ContrastFilterType
    {
        /// <summary>
        ///
        /// </summary>
        Contrast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContrastFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContrastFilterType value)
        {
            return value switch
            {
                ContrastFilterType.Contrast => "contrast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContrastFilterType? ToEnum(string value)
        {
            return value switch
            {
                "contrast" => ContrastFilterType.Contrast,
                _ => null,
            };
        }
    }
}