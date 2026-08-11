
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// **Notice: The Soundtrack is deprecated, use an [AudioAsset](#tocs_audioasset) clip on its own track instead.** This type continues to function; no behaviour change for existing integrations.<br/>
    /// A music or audio file in mp3 format that plays for the duration of the rendered video or the length of the audio file, which ever is shortest.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class Soundtrack
    {
        /// <summary>
        /// The URL of the mp3 audio file. The URL must be publicly accessible or include credentials.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/music.mp3
        /// </summary>
        /// <example>https://s3-ap-northeast-1.amazonaws.com/my-bucket/music.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required string Src { get; set; }

        /// <summary>
        /// The effect to apply to the audio file &lt;ul&gt;<br/>
        ///   &lt;li&gt;`fadeIn` - fade volume in only&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fadeOut` - fade volume out only&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fadeInFadeOut` - fade volume in and out&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effect")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.SoundtrackEffectJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Shotstack.SoundtrackEffect? Effect { get; set; }

        /// <summary>
        /// Set the volume for the soundtrack between 0 and 1 where 0 is muted and 1 is full volume (defaults to 1).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? Volume { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Soundtrack" /> class.
        /// </summary>
        /// <param name="src">
        /// The URL of the mp3 audio file. The URL must be publicly accessible or include credentials.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/music.mp3
        /// </param>
        /// <param name="effect">
        /// The effect to apply to the audio file &lt;ul&gt;<br/>
        ///   &lt;li&gt;`fadeIn` - fade volume in only&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fadeOut` - fade volume out only&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fadeInFadeOut` - fade volume in and out&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </param>
        /// <param name="volume">
        /// Set the volume for the soundtrack between 0 and 1 where 0 is muted and 1 is full volume (defaults to 1).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Soundtrack(
            string src,
            global::Shotstack.SoundtrackEffect? effect,
            double? volume)
        {
            this.Src = src ?? throw new global::System.ArgumentNullException(nameof(src));
            this.Effect = effect;
            this.Volume = volume;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Soundtrack" /> class.
        /// </summary>
        public Soundtrack()
        {
        }

    }
}