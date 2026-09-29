
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Why a generation request was not accepted or a job could not be found.
    /// </summary>
    public sealed partial class GenerationErrorResponse
    {
        /// <summary>
        /// A human readable error message.<br/>
        /// Example: Insufficient generation credits.
        /// </summary>
        /// <example>Insufficient generation credits.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// Why access to AI generation was refused. `AiCapabilityNotIncluded`: the account's plan does not include this kind of generation. `FeatureNotIncluded`: the plan does not include a feature the asset uses. `AiDisabled`: AI generation is turned off for the account. `AiAccessUnavailable`: access could not be confirmed; try again later.<br/>
        /// Example: AiCapabilityNotIncluded
        /// </summary>
        /// <example>AiCapabilityNotIncluded</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// The credits the account has available. Present when it has too few.<br/>
        /// Example: 1.5F
        /// </summary>
        /// <example>1.5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("available")]
        public double? Available { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationErrorResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// A human readable error message.<br/>
        /// Example: Insufficient generation credits.
        /// </param>
        /// <param name="code">
        /// Why access to AI generation was refused. `AiCapabilityNotIncluded`: the account's plan does not include this kind of generation. `FeatureNotIncluded`: the plan does not include a feature the asset uses. `AiDisabled`: AI generation is turned off for the account. `AiAccessUnavailable`: access could not be confirmed; try again later.<br/>
        /// Example: AiCapabilityNotIncluded
        /// </param>
        /// <param name="available">
        /// The credits the account has available. Present when it has too few.<br/>
        /// Example: 1.5F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationErrorResponse(
            string error,
            string? code,
            double? available)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Code = code;
            this.Available = available;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationErrorResponse" /> class.
        /// </summary>
        public GenerationErrorResponse()
        {
        }

    }
}