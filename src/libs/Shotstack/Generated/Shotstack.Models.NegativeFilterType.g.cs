
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The filter type - set to `negative`.
    /// </summary>
    public enum NegativeFilterType
    {
        /// <summary>
        ///
        /// </summary>
        Negative,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NegativeFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NegativeFilterType value)
        {
            return value switch
            {
                NegativeFilterType.Negative => "negative",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NegativeFilterType? ToEnum(string value)
        {
            return value switch
            {
                "negative" => NegativeFilterType.Negative,
                _ => null,
            };
        }
    }
}