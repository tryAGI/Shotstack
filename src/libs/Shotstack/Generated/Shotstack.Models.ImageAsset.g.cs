
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The ImageAsset adds an image to a Clip. The image can be sourced from a URL<br/>
    /// (`src`), generated from a text prompt (`prompt`), or both. At least one of<br/>
    /// `src` or `prompt` must be provided.<br/>
    /// - **Source URL:** set `src` to the publicly accessible URL of a jpg or png file.<br/>
    /// - **Generated:** set `prompt` to describe the image. Choose a generator with<br/>
    ///   `model` and configure it with model-specific `options`; the engine fills<br/>
    ///   `src` in automatically.<br/>
    /// - **Both:** `src` acts as a preview placeholder while `prompt` drives<br/>
    ///   generation — the image is regenerated from the prompt at render time.<br/>
    ///   Unchanged prompts and options resolve from the generation cache.
    /// </summary>
    public sealed partial class ImageAsset
    {
        /// <summary>
        /// The type of asset - set to `image` for images.<br/>
        /// Default Value: image
        /// </summary>
        /// <default>global::Shotstack.ImageAssetType.Image</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.ImageAssetTypeJsonConverter))]
        public global::Shotstack.ImageAssetType Type { get; set; } = global::Shotstack.ImageAssetType.Image;

        /// <summary>
        /// The image source URL. The URL must be publicly accessible or include credentials. When `prompt` is also set, `src` serves as a preview placeholder and the image is regenerated from the prompt at render time.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/image.jpg
        /// </summary>
        /// <example>https://s3-ap-northeast-1.amazonaws.com/my-bucket/image.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        public string? Src { get; set; }

        /// <summary>
        /// A text prompt to generate the image from. The engine generates an image at render time and fills `src` automatically; an existing `src` is treated as a preview placeholder and replaced. Use `model` to choose the generator and `options` to configure it.<br/>
        /// Example: A serene landscape with a crystal-clear mountain lake at sunrise.
        /// </summary>
        /// <example>A serene landscape with a crystal-clear mountain lake at sunrise.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The generation model to use when `prompt` is set (e.g. `flux-schnell`, `nano-banana-2`). Defaults to `nano-banana-2` if omitted. Each model's available options are defined by the model registry.<br/>
        /// Example: flux-schnell
        /// </summary>
        /// <example>flux-schnell</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Model-specific generation settings. Valid keys and values depend on the chosen `model` and are defined by the model registry. Omitted options use the model's defaults. Unknown or invalid options are rejected.<br/>
        /// Example: {"resolution":"1K","aspectRatio":"16:9"}
        /// </summary>
        /// <example>{"resolution":"1K","aspectRatio":"16:9"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public object? Options { get; set; }

        /// <summary>
        /// Crop the sides of an asset by a relative amount. The size of the crop is specified using a scale between 0 and 1, relative to the screen width - i.e a left crop of 0.5 will crop half of the asset from the left, a top crop  of 0.25 will crop the top by quarter of the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crop")]
        public global::Shotstack.Crop? Crop { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageAsset" /> class.
        /// </summary>
        /// <param name="src">
        /// The image source URL. The URL must be publicly accessible or include credentials. When `prompt` is also set, `src` serves as a preview placeholder and the image is regenerated from the prompt at render time.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/image.jpg
        /// </param>
        /// <param name="prompt">
        /// A text prompt to generate the image from. The engine generates an image at render time and fills `src` automatically; an existing `src` is treated as a preview placeholder and replaced. Use `model` to choose the generator and `options` to configure it.<br/>
        /// Example: A serene landscape with a crystal-clear mountain lake at sunrise.
        /// </param>
        /// <param name="model">
        /// The generation model to use when `prompt` is set (e.g. `flux-schnell`, `nano-banana-2`). Defaults to `nano-banana-2` if omitted. Each model's available options are defined by the model registry.<br/>
        /// Example: flux-schnell
        /// </param>
        /// <param name="options">
        /// Model-specific generation settings. Valid keys and values depend on the chosen `model` and are defined by the model registry. Omitted options use the model's defaults. Unknown or invalid options are rejected.<br/>
        /// Example: {"resolution":"1K","aspectRatio":"16:9"}
        /// </param>
        /// <param name="crop">
        /// Crop the sides of an asset by a relative amount. The size of the crop is specified using a scale between 0 and 1, relative to the screen width - i.e a left crop of 0.5 will crop half of the asset from the left, a top crop  of 0.25 will crop the top by quarter of the asset.
        /// </param>
        /// <param name="type">
        /// The type of asset - set to `image` for images.<br/>
        /// Default Value: image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageAsset(
            string? src,
            string? prompt,
            string? model,
            object? options,
            global::Shotstack.Crop? crop,
            global::Shotstack.ImageAssetType type = global::Shotstack.ImageAssetType.Image)
        {
            this.Type = type;
            this.Src = src;
            this.Prompt = prompt;
            this.Model = model;
            this.Options = options;
            this.Crop = crop;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageAsset" /> class.
        /// </summary>
        public ImageAsset()
        {
        }

    }
}