
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The ImageAsset adds an image to a Clip. The image can be sourced from a URL<br/>
    /// (`src`) or generated from a text prompt (`prompt`). Exactly one of `src` or<br/>
    /// `prompt` must be provided.<br/>
    /// - **Source URL:** set `src` to the publicly accessible URL of a jpg or png file.<br/>
    /// - **Generated:** set `prompt` to describe the image; the engine generates it<br/>
    ///   using the provider chosen by `model` and fills `src` in automatically.
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
        /// The image source URL. The URL must be publicly accessible or include credentials. Provide either `src` or `prompt`, not both.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/image.jpg
        /// </summary>
        /// <example>https://s3-ap-northeast-1.amazonaws.com/my-bucket/image.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        public string? Src { get; set; }

        /// <summary>
        /// A text prompt to generate the image from. When set without `src`, the engine generates an image and fills `src` automatically. Use `model` to choose the generator.<br/>
        /// Example: A serene landscape with a crystal-clear mountain lake at sunrise.
        /// </summary>
        /// <example>A serene landscape with a crystal-clear mountain lake at sunrise.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The generation model to use when `prompt` is set (e.g. `flux-schnell`). Defaults to the platform's preferred generator if omitted.<br/>
        /// Example: flux-schnell
        /// </summary>
        /// <example>flux-schnell</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

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
        /// The image source URL. The URL must be publicly accessible or include credentials. Provide either `src` or `prompt`, not both.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/image.jpg
        /// </param>
        /// <param name="prompt">
        /// A text prompt to generate the image from. When set without `src`, the engine generates an image and fills `src` automatically. Use `model` to choose the generator.<br/>
        /// Example: A serene landscape with a crystal-clear mountain lake at sunrise.
        /// </param>
        /// <param name="model">
        /// The generation model to use when `prompt` is set (e.g. `flux-schnell`). Defaults to the platform's preferred generator if omitted.<br/>
        /// Example: flux-schnell
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
            global::Shotstack.Crop? crop,
            global::Shotstack.ImageAssetType type = global::Shotstack.ImageAssetType.Image)
        {
            this.Type = type;
            this.Src = src;
            this.Prompt = prompt;
            this.Model = model;
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