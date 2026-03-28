
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Error response data for validation and other errors returned by the Ingest API.
    /// </summary>
    public sealed partial class IngestErrorResponse
    {
        /// <summary>
        /// An array of errors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Shotstack.IngestErrorResponseData> Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestErrorResponse" /> class.
        /// </summary>
        /// <param name="errors">
        /// An array of errors.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IngestErrorResponse(
            global::System.Collections.Generic.IList<global::Shotstack.IngestErrorResponseData> errors)
        {
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestErrorResponse" /> class.
        /// </summary>
        public IngestErrorResponse()
        {
        }
    }
}