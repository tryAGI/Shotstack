
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Present when a partial unit is charged as a whole one. A 61 second track on a per-minute rate is charged as two minutes.<br/>
    /// Example: up
    /// </summary>
    public enum GenerationModelPricingQuantityRound
    {
        /// <summary>
        ///
        /// </summary>
        Up,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationModelPricingQuantityRoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationModelPricingQuantityRound value)
        {
            return value switch
            {
                GenerationModelPricingQuantityRound.Up => "up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationModelPricingQuantityRound? ToEnum(string value)
        {
            return value switch
            {
                "up" => GenerationModelPricingQuantityRound.Up,
                _ => null,
            };
        }
    }
}