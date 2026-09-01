
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// What the count is taken from, and the scale it is measured in.<br/>
    /// Example: clipSeconds
    /// </summary>
    public enum GenerationModelPricingQuantityMeasure
    {
        /// <summary>
        ///
        /// </summary>
        ClipSeconds,
        /// <summary>
        ///
        /// </summary>
        PromptCharacters,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationModelPricingQuantityMeasureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationModelPricingQuantityMeasure value)
        {
            return value switch
            {
                GenerationModelPricingQuantityMeasure.ClipSeconds => "clipSeconds",
                GenerationModelPricingQuantityMeasure.PromptCharacters => "promptCharacters",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationModelPricingQuantityMeasure? ToEnum(string value)
        {
            return value switch
            {
                "clipSeconds" => GenerationModelPricingQuantityMeasure.ClipSeconds,
                "promptCharacters" => GenerationModelPricingQuantityMeasure.PromptCharacters,
                _ => null,
            };
        }
    }
}