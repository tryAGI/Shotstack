
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Current credit estimate for a generation, calculated with the same rules as submission. Does not reserve credits or lock a price. A cached result costs nothing; final duration-based charges can be lower. Submit the same asset and length to generate it.
    /// </summary>
    public sealed partial class GenerationQuote
    {
        /// <summary>
        /// Estimated generation credits, rounded to four decimal places.<br/>
        /// Example: 0.6038F
        /// </summary>
        /// <example>0.6038F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Credits { get; set; }

        /// <summary>
        /// True when an unresolved duration uses the model's reservation allowance.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ceiling")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Ceiling { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationQuote" /> class.
        /// </summary>
        /// <param name="credits">
        /// Estimated generation credits, rounded to four decimal places.<br/>
        /// Example: 0.6038F
        /// </param>
        /// <param name="ceiling">
        /// True when an unresolved duration uses the model's reservation allowance.<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationQuote(
            double credits,
            bool ceiling)
        {
            this.Credits = credits;
            this.Ceiling = ceiling;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationQuote" /> class.
        /// </summary>
        public GenerationQuote()
        {
        }

    }
}