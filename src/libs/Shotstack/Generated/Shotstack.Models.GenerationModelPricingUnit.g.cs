
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// What one unit is. `render` means the whole generation counts as one unit, whatever its size.<br/>
    /// Example: second
    /// </summary>
    public enum GenerationModelPricingUnit
    {
        /// <summary>
        /// 
        /// </summary>
        Minute,
        /// <summary>
        /// 
        /// </summary>
        Render,
        /// <summary>
        /// 
        /// </summary>
        Second,
        /// <summary>
        /// 
        /// </summary>
        ThousandCharacters,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationModelPricingUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationModelPricingUnit value)
        {
            return value switch
            {
                GenerationModelPricingUnit.Minute => "minute",
                GenerationModelPricingUnit.Render => "render",
                GenerationModelPricingUnit.Second => "second",
                GenerationModelPricingUnit.ThousandCharacters => "thousandCharacters",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationModelPricingUnit? ToEnum(string value)
        {
            return value switch
            {
                "minute" => GenerationModelPricingUnit.Minute,
                "render" => GenerationModelPricingUnit.Render,
                "second" => GenerationModelPricingUnit.Second,
                "thousandCharacters" => GenerationModelPricingUnit.ThousandCharacters,
                _ => null,
            };
        }
    }
}