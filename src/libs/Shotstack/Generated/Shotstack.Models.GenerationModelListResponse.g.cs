
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The generation models available to this account.
    /// </summary>
    public sealed partial class GenerationModelListResponse
    {
        /// <summary>
        /// The available models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Shotstack.GenerationModel> Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationModelListResponse" /> class.
        /// </summary>
        /// <param name="models">
        /// The available models.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationModelListResponse(
            global::System.Collections.Generic.IList<global::Shotstack.GenerationModel> models)
        {
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationModelListResponse" /> class.
        /// </summary>
        public GenerationModelListResponse()
        {
        }

    }
}