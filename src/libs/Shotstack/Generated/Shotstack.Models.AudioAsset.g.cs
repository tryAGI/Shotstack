
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The AudioAsset adds audio to a Clip. The audio can be sourced from a URL<br/>
    /// (`src`) or generated from a text prompt (`prompt`). Exactly one of `src` or<br/>
    /// `prompt` must be provided.<br/>
    /// - **Source URL:** set `src` to a publicly accessible audio URL (e.g. mp3).<br/>
    /// - **Generated speech:** set `prompt` to the spoken text and `voice` to a voice<br/>
    ///   identifier (text-to-speech). Optionally set `language`/`newscaster`.<br/>
    /// - **Generated music or SFX:** set `prompt` describing the sound; omit `voice`.<br/>
    /// - Use `model` to choose the generator. The generated `src` is filled in<br/>
    ///   automatically.
    /// </summary>
    public sealed partial class AudioAsset
    {
        /// <summary>
        /// The type of asset - set to `audio` for audio assets.<br/>
        /// Default Value: audio
        /// </summary>
        /// <default>global::Shotstack.AudioAssetType.Audio</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.AudioAssetTypeJsonConverter))]
        public global::Shotstack.AudioAssetType Type { get; set; } = global::Shotstack.AudioAssetType.Audio;

        /// <summary>
        /// The audio source URL. The URL must be publicly accessible or include credentials. Provide either `src` or `prompt`, not both.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/sound.mp3
        /// </summary>
        /// <example>https://s3-ap-northeast-1.amazonaws.com/my-bucket/sound.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        public string? Src { get; set; }

        /// <summary>
        /// A text prompt. When `voice` is set, the prompt is the spoken text (text-to-speech). Without `voice`, the prompt describes generated music or sound effects. The generated `src` is filled in automatically.<br/>
        /// Example: Welcome to today's broadcast.
        /// </summary>
        /// <example>Welcome to today's broadcast.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Voice identifier for text-to-speech generation (e.g. `Matthew`, `Joanna`). Only meaningful when `prompt` is set.<br/>
        /// Example: Matthew
        /// </summary>
        /// <example>Matthew</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public string? Voice { get; set; }

        /// <summary>
        /// Optional BCP-47 language code (e.g. `en-US`) for text-to-speech. Only meaningful when `prompt` and `voice` are set.<br/>
        /// Example: en-US
        /// </summary>
        /// <example>en-US</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Set to `true` to use the voice's newscaster mode when supported. Only meaningful when `prompt` and `voice` are set.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newscaster")]
        public bool? Newscaster { get; set; }

        /// <summary>
        /// The generation model to use when `prompt` is set (e.g. `polly-neural`). Defaults to the platform's preferred generator if omitted.<br/>
        /// Example: polly-neural
        /// </summary>
        /// <example>polly-neural</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The start trim point of the audio clip, in seconds (defaults to 0). Audio will start from the in trim point. The audio will play until the file ends or the Clip length is reached.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trim")]
        public double? Trim { get; set; }

        /// <summary>
        /// Set the volume of the audio clip. Use a number or an array of [Tween](./#tocs_tween) objects to create custom volume transitions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<float?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>))]
        public global::Shotstack.OneOf<float?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? Volume { get; set; }

        /// <summary>
        /// Adjust the playback speed of the audio clip between 0 (paused) and 10 (10x normal speed), where 1 is normal speed (defaults to 1). Adjusting the speed will also adjust the duration of the clip and may require you to adjust the Clip length. For example, if you set speed to 0.5, the clip will need to be 2x as long to play the entire audio (i.e. original length / 0.5). If you set speed to 2, the clip will need to be half as long to play the entire audio (i.e. original length / 2).<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public float? Speed { get; set; }

        /// <summary>
        /// The effect to apply to the audio asset &lt;ul&gt;<br/>
        ///   &lt;li&gt;`fadeIn` - fade volume in only&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fadeOut` - fade volume out only&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fadeInFadeOut` - fade volume in and out&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effect")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.AudioAssetEffectJsonConverter))]
        public global::Shotstack.AudioAssetEffect? Effect { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioAsset" /> class.
        /// </summary>
        /// <param name="src">
        /// The audio source URL. The URL must be publicly accessible or include credentials. Provide either `src` or `prompt`, not both.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/sound.mp3
        /// </param>
        /// <param name="prompt">
        /// A text prompt. When `voice` is set, the prompt is the spoken text (text-to-speech). Without `voice`, the prompt describes generated music or sound effects. The generated `src` is filled in automatically.<br/>
        /// Example: Welcome to today's broadcast.
        /// </param>
        /// <param name="voice">
        /// Voice identifier for text-to-speech generation (e.g. `Matthew`, `Joanna`). Only meaningful when `prompt` is set.<br/>
        /// Example: Matthew
        /// </param>
        /// <param name="language">
        /// Optional BCP-47 language code (e.g. `en-US`) for text-to-speech. Only meaningful when `prompt` and `voice` are set.<br/>
        /// Example: en-US
        /// </param>
        /// <param name="newscaster">
        /// Set to `true` to use the voice's newscaster mode when supported. Only meaningful when `prompt` and `voice` are set.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="model">
        /// The generation model to use when `prompt` is set (e.g. `polly-neural`). Defaults to the platform's preferred generator if omitted.<br/>
        /// Example: polly-neural
        /// </param>
        /// <param name="trim">
        /// The start trim point of the audio clip, in seconds (defaults to 0). Audio will start from the in trim point. The audio will play until the file ends or the Clip length is reached.
        /// </param>
        /// <param name="volume">
        /// Set the volume of the audio clip. Use a number or an array of [Tween](./#tocs_tween) objects to create custom volume transitions.
        /// </param>
        /// <param name="speed">
        /// Adjust the playback speed of the audio clip between 0 (paused) and 10 (10x normal speed), where 1 is normal speed (defaults to 1). Adjusting the speed will also adjust the duration of the clip and may require you to adjust the Clip length. For example, if you set speed to 0.5, the clip will need to be 2x as long to play the entire audio (i.e. original length / 0.5). If you set speed to 2, the clip will need to be half as long to play the entire audio (i.e. original length / 2).<br/>
        /// Example: 1
        /// </param>
        /// <param name="effect">
        /// The effect to apply to the audio asset &lt;ul&gt;<br/>
        ///   &lt;li&gt;`fadeIn` - fade volume in only&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fadeOut` - fade volume out only&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fadeInFadeOut` - fade volume in and out&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </param>
        /// <param name="type">
        /// The type of asset - set to `audio` for audio assets.<br/>
        /// Default Value: audio
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioAsset(
            string? src,
            string? prompt,
            string? voice,
            string? language,
            bool? newscaster,
            string? model,
            double? trim,
            global::Shotstack.OneOf<float?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? volume,
            float? speed,
            global::Shotstack.AudioAssetEffect? effect,
            global::Shotstack.AudioAssetType type = global::Shotstack.AudioAssetType.Audio)
        {
            this.Type = type;
            this.Src = src;
            this.Prompt = prompt;
            this.Voice = voice;
            this.Language = language;
            this.Newscaster = newscaster;
            this.Model = model;
            this.Trim = trim;
            this.Volume = volume;
            this.Speed = speed;
            this.Effect = effect;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioAsset" /> class.
        /// </summary>
        public AudioAsset()
        {
        }

    }
}