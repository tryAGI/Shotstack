
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The filter type - set to `blur`.
    /// </summary>
    public enum BlurFilterType
    {
        /// <summary>
        ///
        /// </summary>
        Blur,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BlurFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BlurFilterType value)
        {
            return value switch
            {
                BlurFilterType.Blur => "blur",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BlurFilterType? ToEnum(string value)
        {
            return value switch
            {
                "blur" => BlurFilterType.Blur,
                _ => null,
            };
        }
    }
}