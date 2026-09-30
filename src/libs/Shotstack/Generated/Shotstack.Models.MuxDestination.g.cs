
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Shotstack
{
    /// <summary>
    /// **Notice: The Mux destination is deprecated.** It continues to work, with no behaviour change for existing integrations.<br/>
    /// Send videos to the [Mux](https://www.mux.com/docs) video hosting and streaming service. Mux credentials are required and added via the [dashboard](https://dashboard.shotstack.io/integrations/mux), not in the request.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class MuxDestination
    {
        /// <summary>
        /// The destination to send video to - set to `mux` for Mux.<br/>
        /// Default Value: mux<br/>
        /// Example: mux
        /// </summary>
        /// <default>"mux"</default>
        /// <example>mux</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required string Provider { get; set; } = "mux";

        /// <summary>
        /// **Notice: MuxDestinationOptions, like the Mux destination, is deprecated.** It continues to work, with no behaviour change for existing integrations.<br/>
        /// Pass additional options to control how Mux processes video. Currently supports playback_policy and passthrough options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Shotstack.MuxDestinationOptions? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MuxDestination" /> class.
        /// </summary>
        /// <param name="provider">
        /// The destination to send video to - set to `mux` for Mux.<br/>
        /// Default Value: mux<br/>
        /// Example: mux
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MuxDestination(
            string provider)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MuxDestination" /> class.
        /// </summary>
        public MuxDestination()
        {
        }

    }
}