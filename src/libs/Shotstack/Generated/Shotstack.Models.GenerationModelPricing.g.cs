
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// What one generation costs, in credits: the rate multiplied by the units consumed. `quantity` says how to count the units, and is absent when one generation is one unit. Where a model charges differently per option value, `credits` is an object keyed by that value and `tieredBy` names the option that selects it.
    /// </summary>
    public sealed partial class GenerationModelPricing
    {
        /// <summary>
        /// Credits per unit. A number when the rate is flat, or an object keyed by the values of the option named in `tieredBy`.<br/>
        /// Example: {"480p":0.9375,"720p":1.8962,"1080p":4.2625}
        /// </summary>
        /// <example>{"480p":0.9375,"720p":1.8962,"1080p":4.2625}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<double?, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Shotstack.OneOf<double?, object> Credits { get; set; }

        /// <summary>
        /// The option whose value selects the rate, and the value assumed when the option is absent. Present only when `credits` is keyed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tieredBy")]
        public global::Shotstack.GenerationModelPricingTieredBy? TieredBy { get; set; }

        /// <summary>
        /// How many units a generation consumes. Take the value `measure` names, or `default` when the request carries none, hold it within `min` and `max`, divide by `per`, and round up when `round` is `up`. Absent when one generation is one unit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public global::Shotstack.GenerationModelPricingQuantity? Quantity { get; set; }

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
        /// <param name="credits">
        /// Credits per unit. A number when the rate is flat, or an object keyed by the values of the option named in `tieredBy`.<br/>
        /// Example: {"480p":0.9375,"720p":1.8962,"1080p":4.2625}
        /// </param>
        /// <param name="effectiveFrom">
        /// The date this rate took effect, or `legacy` for a rate that predates dated pricing.<br/>
        /// Example: 2026-08-13
        /// </param>
        /// <param name="tieredBy">
        /// The option whose value selects the rate, and the value assumed when the option is absent. Present only when `credits` is keyed.
        /// </param>
        /// <param name="quantity">
        /// How many units a generation consumes. Take the value `measure` names, or `default` when the request carries none, hold it within `min` and `max`, divide by `per`, and round up when `round` is `up`. Absent when one generation is one unit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationModelPricing(
            global::Shotstack.OneOf<double?, object> credits,
            string effectiveFrom,
            global::Shotstack.GenerationModelPricingTieredBy? tieredBy,
            global::Shotstack.GenerationModelPricingQuantity? quantity)
        {
            this.Credits = credits;
            this.TieredBy = tieredBy;
            this.Quantity = quantity;
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