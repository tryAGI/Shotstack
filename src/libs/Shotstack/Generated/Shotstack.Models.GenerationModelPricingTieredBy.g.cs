
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The option whose value selects the rate, and the value assumed when the option is absent. Present only when `credits` is keyed.
    /// </summary>
    public sealed partial class GenerationModelPricingTieredBy
    {
        /// <summary>
        /// Example: resolution
        /// </summary>
        /// <example>resolution</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("option")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Option { get; set; }

        /// <summary>
        /// Example: 720p
        /// </summary>
        /// <example>720p</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Default { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationModelPricingTieredBy" /> class.
        /// </summary>
        /// <param name="option">
        /// Example: resolution
        /// </param>
        /// <param name="default">
        /// Example: 720p
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationModelPricingTieredBy(
            string option,
            string @default)
        {
            this.Option = option ?? throw new global::System.ArgumentNullException(nameof(option));
            this.Default = @default ?? throw new global::System.ArgumentNullException(nameof(@default));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationModelPricingTieredBy" /> class.
        /// </summary>
        public GenerationModelPricingTieredBy()
        {
        }

    }
}