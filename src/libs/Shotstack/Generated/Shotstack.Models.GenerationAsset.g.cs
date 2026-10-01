
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// An image, video or audio asset to generate from a text prompt.
    /// </summary>
    public sealed partial class GenerationAsset
    {
        /// <summary>
        /// The kind of asset to generate.<br/>
        /// Example: image
        /// </summary>
        /// <example>image</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.GenerationAssetTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Shotstack.GenerationAssetType Type { get; set; }

        /// <summary>
        /// A description of the asset to generate. For text-to-speech models it is the text spoken.<br/>
        /// Example: A lighthouse on a rocky coast at sunset, cinematic lighting
        /// </summary>
        /// <example>A lighthouse on a rocky coast at sunset, cinematic lighting</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The generation model. Defaults to `nano-banana-2` for images, `seedance-2.0-text-to-video` for video and `elevenlabs-multilingual-v2` for audio. `GET /models` lists the models for each type.<br/>
        /// Example: nano-banana-2
        /// </summary>
        /// <example>nano-banana-2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Settings for the chosen `model`. `GET /models` lists the options each model accepts; omitted options use the model's defaults and unknown or invalid options are rejected. A starting image for video goes in `startSrc` (`inputSrc` on the original image-to-video models) and a speech voice in `voice`.<br/>
        /// Example: {"aspectRatio":"16:9"}
        /// </summary>
        /// <example>{"aspectRatio":"16:9"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public object? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationAsset" /> class.
        /// </summary>
        /// <param name="type">
        /// The kind of asset to generate.<br/>
        /// Example: image
        /// </param>
        /// <param name="prompt">
        /// A description of the asset to generate. For text-to-speech models it is the text spoken.<br/>
        /// Example: A lighthouse on a rocky coast at sunset, cinematic lighting
        /// </param>
        /// <param name="model">
        /// The generation model. Defaults to `nano-banana-2` for images, `seedance-2.0-text-to-video` for video and `elevenlabs-multilingual-v2` for audio. `GET /models` lists the models for each type.<br/>
        /// Example: nano-banana-2
        /// </param>
        /// <param name="options">
        /// Settings for the chosen `model`. `GET /models` lists the options each model accepts; omitted options use the model's defaults and unknown or invalid options are rejected. A starting image for video goes in `startSrc` (`inputSrc` on the original image-to-video models) and a speech voice in `voice`.<br/>
        /// Example: {"aspectRatio":"16:9"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationAsset(
            global::Shotstack.GenerationAssetType type,
            string prompt,
            string? model,
            object? options)
        {
            this.Type = type;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Model = model;
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationAsset" /> class.
        /// </summary>
        public GenerationAsset()
        {
        }

    }
}