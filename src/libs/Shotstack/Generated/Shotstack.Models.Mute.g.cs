
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Silences English profanity in the clip's speech, and any listed `words`. The audio is transcribed when the edit renders, and the volume drops to zero just before each matching word and returns just after it. Rich captions transcribed from this clip show the same words masked. Profanity detection is not exhaustive: list any word that must not be heard. Cannot be combined with `speed`, `duck` or a volume tween array.
    /// </summary>
    public sealed partial class Mute
    {
        /// <summary>
        /// Extra words to silence, each a single word, matched whole and ignoring case and surrounding punctuation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<string>? Words { get; set; }

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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Mute(
            global::System.Collections.Generic.IList<string>? words)
        {
            this.Words = words;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mute" /> class.
        /// </summary>
        public Mute()
        {
        }

    }
}