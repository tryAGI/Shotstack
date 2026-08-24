
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// What one generation costs, in credits. There is no formula to evaluate: multiply the rate by the number of units the generation consumes. Where a model charges differently per option value, `credits` is an object keyed by that value and `tieredBy` names the option that selects it.
    /// </summary>
    public sealed partial class GenerationModelPricing
    {
        /// <summary>
        /// What one unit is. `render` means the whole generation counts as one unit, whatever its size.<br/>
        /// Example: second
        /// </summary>
        /// <example>second</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.GenerationModelPricingUnitJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Shotstack.GenerationModelPricingUnit Unit { get; set; }

        /// <summary>
        /// Credits per unit. A number when the rate is flat, or an object keyed by the values of the options named in `tieredBy`.<br/>
        /// Example: {"480p":0.9375,"720p":1.8962,"1080p":4.2625}
        /// </summary>
        /// <example>{"480p":0.9375,"720p":1.8962,"1080p":4.2625}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<double?, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Shotstack.OneOf<double?, object> Credits { get; set; }

        /// <summary>
        /// The options whose values select the rate, outermost first. Absent when `credits` is a single number.<br/>
        /// Example: [resolution]
        /// </summary>
        /// <example>[resolution]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tieredBy")]
        public global::System.Collections.Generic.IList<string>? TieredBy { get; set; }

        /// <summary>
        /// The fewest units a generation is charged for, when a model has a minimum charge.<br/>
        /// Example: 0.1F
        /// </summary>
        /// <example>0.1F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("minUnits")]
        public double? MinUnits { get; set; }

        /// <summary>
        /// The date this rate took effect, or `legacy` for a rate that predates dated pricing.<br/>
        /// Example: 2026-08-13
        /// </summary>
        /// <example>2026-08-13</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("effectiveFrom")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EffectiveFrom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationModelPricing" /> class.
        /// </summary>
        /// <param name="unit">
        /// What one unit is. `render` means the whole generation counts as one unit, whatever its size.<br/>
        /// Example: second
        /// </param>
        /// <param name="credits">
        /// Credits per unit. A number when the rate is flat, or an object keyed by the values of the options named in `tieredBy`.<br/>
        /// Example: {"480p":0.9375,"720p":1.8962,"1080p":4.2625}
        /// </param>
        /// <param name="effectiveFrom">
        /// The date this rate took effect, or `legacy` for a rate that predates dated pricing.<br/>
        /// Example: 2026-08-13
        /// </param>
        /// <param name="tieredBy">
        /// The options whose values select the rate, outermost first. Absent when `credits` is a single number.<br/>
        /// Example: [resolution]
        /// </param>
        /// <param name="minUnits">
        /// The fewest units a generation is charged for, when a model has a minimum charge.<br/>
        /// Example: 0.1F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationModelPricing(
            global::Shotstack.GenerationModelPricingUnit unit,
            global::Shotstack.OneOf<double?, object> credits,
            string effectiveFrom,
            global::System.Collections.Generic.IList<string>? tieredBy,
            double? minUnits)
        {
            this.Unit = unit;
            this.Credits = credits;
            this.TieredBy = tieredBy;
            this.MinUnits = minUnits;
            this.EffectiveFrom = effectiveFrom ?? throw new global::System.ArgumentNullException(nameof(effectiveFrom));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationModelPricing" /> class.
        /// </summary>
        public GenerationModelPricing()
        {
        }

    }
}