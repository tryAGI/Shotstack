
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Generate assets using HeyGen. HeyGen provide a text-to-avatar service.  The HeyGen provider works on a bring-your-own-key basis, credentials are required and must be added via the  [dashboard](https://dashboard.shotstack.io/integrations/heygen), not in the request.
    /// </summary>
    public sealed partial class HeyGenGeneratedAsset
    {
        /// <summary>
        /// The name of the provider - set to `heygen` for HeyGen.<br/>
        /// Default Value: heygen
        /// </summary>
        /// <default>global::Shotstack.HeyGenGeneratedAssetProvider.Heygen</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.HeyGenGeneratedAssetProviderJsonConverter))]
        public global::Shotstack.HeyGenGeneratedAssetProvider Provider { get; set; } = global::Shotstack.HeyGenGeneratedAssetProvider.Heygen;

        /// <summary>
        /// Generate assets using the third party HeyGen provider AI services.<br/>
        /// The following AI generation services are available: &lt;ul&gt;<br/>
        ///   &lt;li&gt;&lt;a href="#tocs_heygentexttoavataroptions"&gt;HeyGenTextToAvatarOptions&lt;/a&gt;&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Shotstack.HeyGenTextToAvatarOptions Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeyGenGeneratedAsset" /> class.
        /// </summary>
        /// <param name="options">
        /// Generate assets using the third party HeyGen provider AI services.<br/>
        /// The following AI generation services are available: &lt;ul&gt;<br/>
        ///   &lt;li&gt;&lt;a href="#tocs_heygentexttoavataroptions"&gt;HeyGenTextToAvatarOptions&lt;/a&gt;&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </param>
        /// <param name="provider">
        /// The name of the provider - set to `heygen` for HeyGen.<br/>
        /// Default Value: heygen
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeyGenGeneratedAsset(
            global::Shotstack.HeyGenTextToAvatarOptions options,
            global::Shotstack.HeyGenGeneratedAssetProvider provider = global::Shotstack.HeyGenGeneratedAssetProvider.Heygen)
        {
            this.Provider = provider;
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeyGenGeneratedAsset" /> class.
        /// </summary>
        public HeyGenGeneratedAsset()
        {
        }
    }
}