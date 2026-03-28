
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Generate assets using Stability AI. Stability AI provide a text-to-image service using Stable Diffusion. The Stability AI provider works on a bring-your-own-key basis, credentials are required and must be added via the  [dashboard](https://dashboard.shotstack.io/integrations/stability-ai), not in the request.
    /// </summary>
    public sealed partial class StabilityAiGeneratedAsset
    {
        /// <summary>
        /// The name of the provider - set to `stability-ai` for Stability AI.<br/>
        /// Default Value: stability-ai
        /// </summary>
        /// <default>global::Shotstack.StabilityAiGeneratedAssetProvider.StabilityAi</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.StabilityAiGeneratedAssetProviderJsonConverter))]
        public global::Shotstack.StabilityAiGeneratedAssetProvider Provider { get; set; } = global::Shotstack.StabilityAiGeneratedAssetProvider.StabilityAi;

        /// <summary>
        /// Generate assets using Stability AI provider AI services.<br/>
        /// The following AI generation services are available: &lt;ul&gt;<br/>
        ///   &lt;li&gt;&lt;a href="#tocs_stabilityaitexttoimageoptions"&gt;StabilityAiTextToImageOptions&lt;/a&gt;&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Shotstack.StabilityAiTextToImageOptions Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StabilityAiGeneratedAsset" /> class.
        /// </summary>
        /// <param name="provider">
        /// The name of the provider - set to `stability-ai` for Stability AI.<br/>
        /// Default Value: stability-ai
        /// </param>
        /// <param name="options">
        /// Generate assets using Stability AI provider AI services.<br/>
        /// The following AI generation services are available: &lt;ul&gt;<br/>
        ///   &lt;li&gt;&lt;a href="#tocs_stabilityaitexttoimageoptions"&gt;StabilityAiTextToImageOptions&lt;/a&gt;&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StabilityAiGeneratedAsset(
            global::Shotstack.StabilityAiTextToImageOptions options,
            global::Shotstack.StabilityAiGeneratedAssetProvider provider = global::Shotstack.StabilityAiGeneratedAssetProvider.StabilityAi)
        {
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StabilityAiGeneratedAsset" /> class.
        /// </summary>
        public StabilityAiGeneratedAsset()
        {
        }
    }
}