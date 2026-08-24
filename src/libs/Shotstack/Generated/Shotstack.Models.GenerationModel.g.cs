
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// A generation model available to `prompt`-bearing image, video and audio assets, with the options it accepts and what it costs. Render a model picker and its option fields from this rather than hard coding a model list, so a newly launched model is available without a client release.
    /// </summary>
    public sealed partial class GenerationModel
    {
        /// <summary>
        /// The identifier to set as the asset `model`. Carries no provider name, so routing can change without a public rename.<br/>
        /// Example: seedance-2.0
        /// </summary>
        /// <example>seedance-2.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The asset type this model generates.<br/>
        /// Example: video
        /// </summary>
        /// <example>video</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.GenerationModelTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Shotstack.GenerationModelType Type { get; set; }

        /// <summary>
        /// What one generation costs, in credits. There is no formula to evaluate: multiply the rate by the number of units the generation consumes. Where a model charges differently per option value, `credits` is an object keyed by that value and `tieredBy` names the option that selects it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        public global::Shotstack.GenerationModelPricing? Pricing { get; set; }

        /// <summary>
        /// JSON Schema for the model's `options` object. Only returned for a single model, or for a list requested with `expand=options`. Values outside this schema are rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public object? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationModel" /> class.
        /// </summary>
        /// <param name="model">
        /// The identifier to set as the asset `model`. Carries no provider name, so routing can change without a public rename.<br/>
        /// Example: seedance-2.0
        /// </param>
        /// <param name="type">
        /// The asset type this model generates.<br/>
        /// Example: video
        /// </param>
        /// <param name="pricing">
        /// What one generation costs, in credits. There is no formula to evaluate: multiply the rate by the number of units the generation consumes. Where a model charges differently per option value, `credits` is an object keyed by that value and `tieredBy` names the option that selects it.
        /// </param>
        /// <param name="options">
        /// JSON Schema for the model's `options` object. Only returned for a single model, or for a list requested with `expand=options`. Values outside this schema are rejected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationModel(
            string model,
            global::Shotstack.GenerationModelType type,
            global::Shotstack.GenerationModelPricing? pricing,
            object? options)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Type = type;
            this.Pricing = pricing;
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationModel" /> class.
        /// </summary>
        public GenerationModel()
        {
        }

    }
}