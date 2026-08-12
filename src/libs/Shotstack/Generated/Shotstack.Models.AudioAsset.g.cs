
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The AudioAsset adds audio to a Clip. The audio can be sourced from a URL<br/>
    /// (`src`), generated from a text prompt (`prompt`), or both. At least one of<br/>
    /// `src` or `prompt` must be provided.<br/>
    /// - **Source URL:** set `src` to a publicly accessible audio URL (e.g. mp3).<br/>
    /// - **Generated speech:** set `prompt` to the spoken text and choose a<br/>
    ///   text-to-speech `model`; set the voice via `options`.<br/>
    /// - **Generated music or SFX:** set `prompt` describing the sound and choose<br/>
    ///   a music generation `model`.<br/>
    /// - **Both:** `src` acts as a preview placeholder while `prompt` drives<br/>
    ///   generation — the audio is regenerated from the prompt at render time.<br/>
    ///   Unchanged prompts and options resolve from the generation cache.<br/>
    /// - Use `model` to choose the generator and `options` to configure it. The<br/>
    ///   generated `src` is filled in automatically.
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
        /// The audio source URL. The URL must be publicly accessible or include credentials. When `prompt` is also set, `src` serves as a preview placeholder and the audio is regenerated from the prompt at render time.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/sound.mp3
        /// </summary>
        /// <example>https://s3-ap-northeast-1.amazonaws.com/my-bucket/sound.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        public string? Src { get; set; }

        /// <summary>
        /// A text prompt. For text-to-speech models the prompt is the spoken text; for music models it describes the sound to generate. The generated `src` is filled in automatically; an existing `src` is treated as a preview placeholder and replaced.<br/>
        /// Example: Welcome to today's broadcast.
        /// </summary>
        /// <example>Welcome to today's broadcast.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The generation model to use when `prompt` is set (e.g. `polly-neural`, `elevenlabs-tts`, `elevenlabs-music`). Defaults to `elevenlabs-tts` (with a default voice) if omitted. Each model's available options are defined by the model registry.<br/>
        /// Example: polly-neural
        /// </summary>
        /// <example>polly-neural</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Model-specific generation settings. Valid keys and values depend on the chosen `model` and are defined by the model registry. Omitted options use the model's defaults. Unknown or invalid options are rejected.<br/>
        /// Example: {"voice":"Matthew","language":"en-US"}
        /// </summary>
        /// <example>{"voice":"Matthew","language":"en-US"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public object? Options { get; set; }

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
        /// The audio source URL. The URL must be publicly accessible or include credentials. When `prompt` is also set, `src` serves as a preview placeholder and the audio is regenerated from the prompt at render time.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/sound.mp3
        /// </param>
        /// <param name="prompt">
        /// A text prompt. For text-to-speech models the prompt is the spoken text; for music models it describes the sound to generate. The generated `src` is filled in automatically; an existing `src` is treated as a preview placeholder and replaced.<br/>
        /// Example: Welcome to today's broadcast.
        /// </param>
        /// <param name="model">
        /// The generation model to use when `prompt` is set (e.g. `polly-neural`, `elevenlabs-tts`, `elevenlabs-music`). Defaults to `elevenlabs-tts` (with a default voice) if omitted. Each model's available options are defined by the model registry.<br/>
        /// Example: polly-neural
        /// </param>
        /// <param name="options">
        /// Model-specific generation settings. Valid keys and values depend on the chosen `model` and are defined by the model registry. Omitted options use the model's defaults. Unknown or invalid options are rejected.<br/>
        /// Example: {"voice":"Matthew","language":"en-US"}
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
            string? model,
            object? options,
            double? trim,
            global::Shotstack.OneOf<float?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? volume,
            float? speed,
            global::Shotstack.AudioAssetEffect? effect,
            global::Shotstack.AudioAssetType type = global::Shotstack.AudioAssetType.Audio)
        {
            this.Type = type;
            this.Src = src;
            this.Prompt = prompt;
            this.Model = model;
            this.Options = options;
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