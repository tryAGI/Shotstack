
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Lowers the clip's volume while other clips play and restores it afterwards, for example to keep music under a voiceover. The volume ramps down just before each referenced clip starts and back up after it ends. Requires a numeric `volume` on the clip and cannot be combined with `speed`.
    /// </summary>
    public sealed partial class Duck
    {
        /// <summary>
        /// The clip or clips to duck under, each referenced by its alias in the form `alias://clip-name`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("under")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Shotstack.OneOf<string, global::System.Collections.Generic.IList<string>> Under { get; set; }

        /// <summary>
        /// The volume while ducked, from 0 to 1. When omitted, the level is chosen automatically so the clips it ducks under stay clearly audible. When set, it must be lower than the clip's own volume.<br/>
        /// Example: 0.1F
        /// </summary>
        /// <example>0.1F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        public float? Volume { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Duck" /> class.
        /// </summary>
        /// <param name="under">
        /// The clip or clips to duck under, each referenced by its alias in the form `alias://clip-name`.
        /// </param>
        /// <param name="volume">
        /// The volume while ducked, from 0 to 1. When omitted, the level is chosen automatically so the clips it ducks under stay clearly audible. When set, it must be lower than the clip's own volume.<br/>
        /// Example: 0.1F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Duck(
            global::Shotstack.OneOf<string, global::System.Collections.Generic.IList<string>> under,
            float? volume)
        {
            this.Under = under;
            this.Volume = volume;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Duck" /> class.
        /// </summary>
        public Duck()
        {
        }

    }
}