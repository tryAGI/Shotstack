
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// How many units a generation consumes. Take the value `measure` names, or `default` when the request carries none, hold it within `min` and `max`, divide by `per`, and round up when `round` is `up`. Absent when one generation is one unit.
    /// </summary>
    public sealed partial class GenerationModelPricingQuantity
    {
        /// <summary>
        /// What the count is taken from, and the scale it is measured in.<br/>
        /// Example: clipSeconds
        /// </summary>
        /// <example>clipSeconds</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("measure")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.GenerationModelPricingQuantityMeasureJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Shotstack.GenerationModelPricingQuantityMeasure Measure { get; set; }

        /// <summary>
        /// How many of `measure` make one billable unit.<br/>
        /// Example: 60
        /// </summary>
        /// <example>60</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("per")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Per { get; set; }

        /// <summary>
        /// Fewest accepted. A smaller request is charged at this.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        public double? Min { get; set; }

        /// <summary>
        /// Most accepted. A larger request is charged at this.<br/>
        /// Example: 600
        /// </summary>
        /// <example>600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        public double? Max { get; set; }

        /// <summary>
        /// Assumed when the request carries no value.<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public double? Default { get; set; }

        /// <summary>
        /// Present when a partial unit is charged as a whole one. A 61 second track on a per-minute rate is charged as two minutes.<br/>
        /// Example: up
        /// </summary>
        /// <example>up</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("round")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.GenerationModelPricingQuantityRoundJsonConverter))]
        public global::Shotstack.GenerationModelPricingQuantityRound? Round { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationModelPricingQuantity" /> class.
        /// </summary>
        /// <param name="measure">
        /// What the count is taken from, and the scale it is measured in.<br/>
        /// Example: clipSeconds
        /// </param>
        /// <param name="per">
        /// How many of `measure` make one billable unit.<br/>
        /// Example: 60
        /// </param>
        /// <param name="min">
        /// Fewest accepted. A smaller request is charged at this.<br/>
        /// Example: 3
        /// </param>
        /// <param name="max">
        /// Most accepted. A larger request is charged at this.<br/>
        /// Example: 600
        /// </param>
        /// <param name="default">
        /// Assumed when the request carries no value.<br/>
        /// Example: 30
        /// </param>
        /// <param name="round">
        /// Present when a partial unit is charged as a whole one. A 61 second track on a per-minute rate is charged as two minutes.<br/>
        /// Example: up
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationModelPricingQuantity(
            global::Shotstack.GenerationModelPricingQuantityMeasure measure,
            double per,
            double? min,
            double? max,
            double? @default,
            global::Shotstack.GenerationModelPricingQuantityRound? round)
        {
            this.Measure = measure;
            this.Per = per;
            this.Min = min;
            this.Max = max;
            this.Default = @default;
            this.Round = round;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationModelPricingQuantity" /> class.
        /// </summary>
        public GenerationModelPricingQuantity()
        {
        }

    }
}