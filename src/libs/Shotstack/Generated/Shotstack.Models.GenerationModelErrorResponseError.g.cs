
#nullable enable

namespace Shotstack
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GenerationModelErrorResponseError
    {
        /// <summary>
        /// `UnknownGenerationModel`: no model has this identifier. `WithdrawnGenerationModel`: the model is no longer listed, but edits that already use it still validate, bill and render.<br/>
        /// Example: UnknownGenerationModel
        /// </summary>
        /// <example>UnknownGenerationModel</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.GenerationModelErrorResponseErrorNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Shotstack.GenerationModelErrorResponseErrorName Name { get; set; }

        /// <summary>
        /// A human readable error message.<br/>
        /// Example: Unknown generation model "seedance-9".
        /// </summary>
        /// <example>Unknown generation model "seedance-9".</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationModelErrorResponseError" /> class.
        /// </summary>
        /// <param name="name">
        /// `UnknownGenerationModel`: no model has this identifier. `WithdrawnGenerationModel`: the model is no longer listed, but edits that already use it still validate, bill and render.<br/>
        /// Example: UnknownGenerationModel
        /// </param>
        /// <param name="message">
        /// A human readable error message.<br/>
        /// Example: Unknown generation model "seedance-9".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationModelErrorResponseError(
            global::Shotstack.GenerationModelErrorResponseErrorName name,
            string message)
        {
            this.Name = name;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationModelErrorResponseError" /> class.
        /// </summary>
        public GenerationModelErrorResponseError()
        {
        }

    }
}