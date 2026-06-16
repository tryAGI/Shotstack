
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The VideoAsset adds a video to a Clip. The video can be sourced from a URL<br/>
    /// (`src`) or generated from a text prompt (`prompt`), optionally from a<br/>
    /// starting image (`inputSrc`). Exactly one of `src` or `prompt` must be provided.<br/>
    /// - **Source URL:** set `src` to the URL of an mp4 (or compatible) video file.<br/>
    /// - **Generated:** set `prompt` to describe the motion. Optionally set `inputSrc`<br/>
    ///   to a starting image URL (image-to-video). Use `model` to choose the generator<br/>
    ///   (e.g. `luma-ray-3`, `runpod-itv-mini`). The generated `src` is filled in<br/>
    ///   automatically.
    /// </summary>
    public sealed partial class VideoAsset
    {
        /// <summary>
        /// The type of asset - set to `video` for videos.<br/>
        /// Default Value: video
        /// </summary>
        /// <default>global::Shotstack.VideoAssetType.Video</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.VideoAssetTypeJsonConverter))]
        public global::Shotstack.VideoAssetType Type { get; set; } = global::Shotstack.VideoAssetType.Video;

        /// <summary>
        /// The video source URL. The URL must be publicly accessible or include credentials. Provide either `src` or `prompt`, not both.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/video.mp4
        /// </summary>
        /// <example>https://s3-ap-northeast-1.amazonaws.com/my-bucket/video.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        public string? Src { get; set; }

        /// <summary>
        /// A text prompt to generate the video from. When set without `src`, the engine generates a video and fills `src` automatically. Optionally pair with `inputSrc` for image-to-video. Use `model` to choose the generator.<br/>
        /// Example: Slowly zoom out and orbit left around the object.
        /// </summary>
        /// <example>Slowly zoom out and orbit left around the object.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Input image URL for image-to-video generation. The image is used as the starting frame; `prompt` describes the motion. Has no effect unless `prompt` is set.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/input-image.jpg
        /// </summary>
        /// <example>https://s3-ap-northeast-1.amazonaws.com/my-bucket/input-image.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputSrc")]
        public string? InputSrc { get; set; }

        /// <summary>
        /// **Deprecated — use `inputSrc`.** Legacy alias for the image-to-video input image URL, accepted and normalised to `inputSrc` on ingest. The name is misleading — industry-wide `seed` means an integer RNG sampling seed — and will be removed in a future major version.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/seed-image.jpg
        /// </summary>
        /// <example>https://s3-ap-northeast-1.amazonaws.com/my-bucket/seed-image.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Seed { get; set; }

        /// <summary>
        /// The generation model to use when `prompt` is set (e.g. `luma-ray-3`, `runpod-itv-mini`). Defaults to the platform's preferred generator if omitted.<br/>
        /// Example: luma-ray-3
        /// </summary>
        /// <example>luma-ray-3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Set to `true` to force re-encoding of the video during preprocessing. This can help resolve compatibility issues, fix rotation problems, synchronize audio, or convert formats. The video will be processed to ensure optimal compatibility with the rendering engine.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcode")]
        public bool? Transcode { get; set; }

        /// <summary>
        /// The start trim point of the video clip, in seconds (defaults to 0). Videos will start from the in trim point. The video will play until the file ends or the Clip length is reached.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trim")]
        public double? Trim { get; set; }

        /// <summary>
        /// Set the volume of the video clip. Use a number or an array of [Tween](./#tocs_tween) objects to create custom volume transitions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<float?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>))]
        public global::Shotstack.OneOf<float?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? Volume { get; set; }

        /// <summary>
        /// Preset volume effects to apply to the video asset &lt;ul&gt;<br/>
        ///   &lt;li&gt;`fadeIn` - fade volume in only&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fadeOut` - fade volume out only&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fadeInFadeOut` - fade volume in and out&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumeEffect")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.VideoAssetVolumeEffectJsonConverter))]
        public global::Shotstack.VideoAssetVolumeEffect? VolumeEffect { get; set; }

        /// <summary>
        /// Adjust the playback speed of the video clip between 0 (paused) and 10 (10x normal speed) where 1 is normal speed (defaults to 1). Adjusting the speed will also adjust the duration of the clip and may require you to adjust the Clip length. For example, if you set speed to 0.5, the clip will need to be 2x as long to play the entire video (i.e. original length / 0.5). If you set speed to 2, the clip will need to be half as long to play the entire video (i.e. original length / 2).<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public float? Speed { get; set; }

        /// <summary>
        /// Crop the sides of an asset by a relative amount. The size of the crop is specified using a scale between 0 and 1, relative to the screen width - i.e a left crop of 0.5 will crop half of the asset from the left, a top crop  of 0.25 will crop the top by quarter of the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crop")]
        public global::Shotstack.Crop? Crop { get; set; }

        /// <summary>
        /// Chroma key is a technique that replaces a specific color in a video with a different background image or video, enabling seamless integration of diverse environments. Commonly used for green screen and blue screen effects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chromaKey")]
        public global::Shotstack.ChromaKey? ChromaKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoAsset" /> class.
        /// </summary>
        /// <param name="src">
        /// The video source URL. The URL must be publicly accessible or include credentials. Provide either `src` or `prompt`, not both.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/video.mp4
        /// </param>
        /// <param name="prompt">
        /// A text prompt to generate the video from. When set without `src`, the engine generates a video and fills `src` automatically. Optionally pair with `inputSrc` for image-to-video. Use `model` to choose the generator.<br/>
        /// Example: Slowly zoom out and orbit left around the object.
        /// </param>
        /// <param name="inputSrc">
        /// Input image URL for image-to-video generation. The image is used as the starting frame; `prompt` describes the motion. Has no effect unless `prompt` is set.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/input-image.jpg
        /// </param>
        /// <param name="model">
        /// The generation model to use when `prompt` is set (e.g. `luma-ray-3`, `runpod-itv-mini`). Defaults to the platform's preferred generator if omitted.<br/>
        /// Example: luma-ray-3
        /// </param>
        /// <param name="transcode">
        /// Set to `true` to force re-encoding of the video during preprocessing. This can help resolve compatibility issues, fix rotation problems, synchronize audio, or convert formats. The video will be processed to ensure optimal compatibility with the rendering engine.<br/>
        /// Example: false
        /// </param>
        /// <param name="trim">
        /// The start trim point of the video clip, in seconds (defaults to 0). Videos will start from the in trim point. The video will play until the file ends or the Clip length is reached.<br/>
        /// Example: 2
        /// </param>
        /// <param name="volume">
        /// Set the volume of the video clip. Use a number or an array of [Tween](./#tocs_tween) objects to create custom volume transitions.
        /// </param>
        /// <param name="volumeEffect">
        /// Preset volume effects to apply to the video asset &lt;ul&gt;<br/>
        ///   &lt;li&gt;`fadeIn` - fade volume in only&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fadeOut` - fade volume out only&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fadeInFadeOut` - fade volume in and out&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </param>
        /// <param name="speed">
        /// Adjust the playback speed of the video clip between 0 (paused) and 10 (10x normal speed) where 1 is normal speed (defaults to 1). Adjusting the speed will also adjust the duration of the clip and may require you to adjust the Clip length. For example, if you set speed to 0.5, the clip will need to be 2x as long to play the entire video (i.e. original length / 0.5). If you set speed to 2, the clip will need to be half as long to play the entire video (i.e. original length / 2).<br/>
        /// Example: 1
        /// </param>
        /// <param name="crop">
        /// Crop the sides of an asset by a relative amount. The size of the crop is specified using a scale between 0 and 1, relative to the screen width - i.e a left crop of 0.5 will crop half of the asset from the left, a top crop  of 0.25 will crop the top by quarter of the asset.
        /// </param>
        /// <param name="chromaKey">
        /// Chroma key is a technique that replaces a specific color in a video with a different background image or video, enabling seamless integration of diverse environments. Commonly used for green screen and blue screen effects.
        /// </param>
        /// <param name="type">
        /// The type of asset - set to `video` for videos.<br/>
        /// Default Value: video
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoAsset(
            string? src,
            string? prompt,
            string? inputSrc,
            string? model,
            bool? transcode,
            double? trim,
            global::Shotstack.OneOf<float?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? volume,
            global::Shotstack.VideoAssetVolumeEffect? volumeEffect,
            float? speed,
            global::Shotstack.Crop? crop,
            global::Shotstack.ChromaKey? chromaKey,
            global::Shotstack.VideoAssetType type = global::Shotstack.VideoAssetType.Video)
        {
            this.Type = type;
            this.Src = src;
            this.Prompt = prompt;
            this.InputSrc = inputSrc;
            this.Model = model;
            this.Transcode = transcode;
            this.Trim = trim;
            this.Volume = volume;
            this.VolumeEffect = volumeEffect;
            this.Speed = speed;
            this.Crop = crop;
            this.ChromaKey = chromaKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoAsset" /> class.
        /// </summary>
        public VideoAsset()
        {
        }

    }
}