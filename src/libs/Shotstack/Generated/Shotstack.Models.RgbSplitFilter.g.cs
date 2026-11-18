
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Offsets the red and blue channels in opposite directions to create a color fringing effect. Channels pushed past one edge of the frame reappear at the opposite edge, so small values such as 0.02 work best and 1 or -1 shows no split.
    /// </summary>
    public sealed partial class RgbSplitFilter
    {
        /// <summary>
        /// The filter type - set to `rgbSplit`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.RgbSplitFilterTypeJsonConverter))]
        public global::Shotstack.RgbSplitFilterType Type { get; set; }

        /// <summary>
        /// Sets the horizontal offset of the red and blue channels as a fraction of the clip's frame. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>))]
        public global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? X { get; set; }

        /// <summary>
        /// Sets the vertical offset of the red and blue channels as a fraction of the clip's frame. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>))]
        public global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? Y { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RgbSplitFilter" /> class.
        /// </summary>
        /// <param name="type">
        /// The filter type - set to `rgbSplit`.
        /// </param>
        /// <param name="x">
        /// Sets the horizontal offset of the red and blue channels as a fraction of the clip's frame. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
        /// </param>
        /// <param name="y">
        /// Sets the vertical offset of the red and blue channels as a fraction of the clip's frame. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RgbSplitFilter(
            global::Shotstack.RgbSplitFilterType type,
            global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? x,
            global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? y)
        {
            this.Type = type;
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RgbSplitFilter" /> class.
        /// </summary>
        public RgbSplitFilter()
        {
        }

    }
}