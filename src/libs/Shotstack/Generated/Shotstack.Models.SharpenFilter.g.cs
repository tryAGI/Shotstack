
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Sharpens the clip.
    /// </summary>
    public sealed partial class SharpenFilter
    {
        /// <summary>
        /// The filter type - set to `sharpen`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.SharpenFilterTypeJsonConverter))]
        public global::Shotstack.SharpenFilterType Type { get; set; }

        /// <summary>
        /// Sets the amount of sharpening. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>))]
        public global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? Value { get; set; }

        /// <summary>
        /// Sets the sharpening radius in pixels for a 720p frame. It scales with the frame height. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("radius")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>))]
        public global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? Radius { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpenFilter" /> class.
        /// </summary>
        /// <param name="type">
        /// The filter type - set to `sharpen`.
        /// </param>
        /// <param name="value">
        /// Sets the amount of sharpening. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
        /// </param>
        /// <param name="radius">
        /// Sets the sharpening radius in pixels for a 720p frame. It scales with the frame height. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharpenFilter(
            global::Shotstack.SharpenFilterType type,
            global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? value,
            global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? radius)
        {
            this.Type = type;
            this.Value = value;
            this.Radius = radius;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharpenFilter" /> class.
        /// </summary>
        public SharpenFilter()
        {
        }

    }
}