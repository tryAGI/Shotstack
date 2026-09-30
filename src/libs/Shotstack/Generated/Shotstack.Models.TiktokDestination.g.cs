
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Shotstack
{
    /// <summary>
    /// **Notice: The TikTok destination is deprecated.** It continues to work, with no behaviour change for existing integrations.<br/>
    /// Send videos to TikTok. TikTok credentials are required and added via the [dashboard](https://dashboard.shotstack.io/integrations/tiktok), not in the request.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class TiktokDestination
    {
        /// <summary>
        /// The destination to send video to - set to `tiktok` for TikTok.<br/>
        /// Default Value: tiktok<br/>
        /// Example: tiktok
        /// </summary>
        /// <default>"tiktok"</default>
        /// <example>tiktok</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required string Provider { get; set; } = "tiktok";

        /// <summary>
        /// **Notice: TiktokDestinationOptions, like the TikTok destination, is deprecated.** It continues to work, with no behaviour change for existing integrations.<br/>
        /// Pass additional options to control how TikTok publishes video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Shotstack.TiktokDestinationOptions? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TiktokDestination" /> class.
        /// </summary>
        /// <param name="provider">
        /// The destination to send video to - set to `tiktok` for TikTok.<br/>
        /// Default Value: tiktok<br/>
        /// Example: tiktok
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TiktokDestination(
            string provider)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TiktokDestination" /> class.
        /// </summary>
        public TiktokDestination()
        {
        }

    }
}