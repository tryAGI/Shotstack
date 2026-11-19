
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Silences English profanity in the clip's speech, and any listed `words`. The audio is transcribed when the edit renders, and the volume drops to zero over each matching word, with an optional bleep. Rich captions transcribed from this clip show the same words masked. Profanity detection is not exhaustive: list any word that must not be heard. Cannot be combined with `speed`, `duck` or a volume tween array.
    /// </summary>
    public sealed partial class Mute
    {
        /// <summary>
        /// Extra words to silence, each a single word, matched whole and ignoring case and surrounding punctuation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<string>? Words { get; set; }

        /// <summary>
        /// How muted words sound. `silence` drops the volume to zero over each word; `bleep` does the same and plays a 1 kHz tone over it.<br/>
        /// Default Value: silence<br/>
        /// Example: bleep
        /// </summary>
        /// <example>bleep</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sound")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.MuteSoundJsonConverter))]
        public global::Shotstack.MuteSound? Sound { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Mute" /> class.
        /// </summary>
        /// <param name="words">
        /// Extra words to silence, each a single word, matched whole and ignoring case and surrounding punctuation.
        /// </param>
        /// <param name="sound">
        /// How muted words sound. `silence` drops the volume to zero over each word; `bleep` does the same and plays a 1 kHz tone over it.<br/>
        /// Default Value: silence<br/>
        /// Example: bleep
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Mute(
            global::System.Collections.Generic.IList<string>? words,
            global::Shotstack.MuteSound? sound)
        {
            this.Words = words;
            this.Sound = sound;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mute" /> class.
        /// </summary>
        public Mute()
        {
        }

    }
}