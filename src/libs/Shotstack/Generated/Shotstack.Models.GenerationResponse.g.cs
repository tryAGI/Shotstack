
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The status of an on-demand asset generation job. Completed jobs include the public URL of the generated asset.
    /// </summary>
    public sealed partial class GenerationResponse
    {
        /// <summary>
        /// The generation job id. Deterministic for a given owner and asset payload (or idempotency key), so identical requests return the same job and cached result.<br/>
        /// Example: 8a1f2c3d-4e5b-5a6c-9d7e-1f2a3b4c5d6e
        /// </summary>
        /// <example>8a1f2c3d-4e5b-5a6c-9d7e-1f2a3b4c5d6e</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The status of the generation job.<br/>
        /// Example: done
        /// </summary>
        /// <example>done</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.GenerationResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Shotstack.GenerationResponseStatus Status { get; set; }

        /// <summary>
        /// The public URL of the generated asset. Present only when `status` is `done`.<br/>
        /// Example: https://shotstack-api-v1-output.s3-ap-southeast-2.amazonaws.com/owner/8a1f2c3d.png
        /// </summary>
        /// <example>https://shotstack-api-v1-output.s3-ap-southeast-2.amazonaws.com/owner/8a1f2c3d.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// A human readable error message. Present only when `status` is `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The generation job id. Deterministic for a given owner and asset payload (or idempotency key), so identical requests return the same job and cached result.<br/>
        /// Example: 8a1f2c3d-4e5b-5a6c-9d7e-1f2a3b4c5d6e
        /// </param>
        /// <param name="status">
        /// The status of the generation job.<br/>
        /// Example: done
        /// </param>
        /// <param name="url">
        /// The public URL of the generated asset. Present only when `status` is `done`.<br/>
        /// Example: https://shotstack-api-v1-output.s3-ap-southeast-2.amazonaws.com/owner/8a1f2c3d.png
        /// </param>
        /// <param name="error">
        /// A human readable error message. Present only when `status` is `failed`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationResponse(
            string id,
            global::Shotstack.GenerationResponseStatus status,
            string? url,
            string? error)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Url = url;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationResponse" /> class.
        /// </summary>
        public GenerationResponse()
        {
        }

    }
}