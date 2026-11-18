
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The filter type - set to `grade`.
    /// </summary>
    public enum GradeFilterType
    {
        /// <summary>
        ///
        /// </summary>
        Grade,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GradeFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GradeFilterType value)
        {
            return value switch
            {
                GradeFilterType.Grade => "grade",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GradeFilterType? ToEnum(string value)
        {
            return value switch
            {
                "grade" => GradeFilterType.Grade,
                _ => null,
            };
        }
    }
}