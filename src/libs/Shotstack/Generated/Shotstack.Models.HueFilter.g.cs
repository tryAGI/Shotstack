
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Rotates the hues of the clip around the color wheel.
    /// </summary>
    public sealed partial class HueFilter
    {
        /// <summary>
        /// The filter type - set to `hue`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.HueFilterTypeJsonConverter))]
        public global::Shotstack.HueFilterType Type { get; set; }

        /// <summary>
        /// Sets the hue rotation of the clip in degrees. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>))]
        public global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HueFilter" /> class.
        /// </summary>
        /// <param name="type">
        /// The filter type - set to `hue`.
        /// </param>
        /// <param name="value">
        /// Sets the hue rotation of the clip in degrees. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HueFilter(
            global::Shotstack.HueFilterType type,
            global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? value)
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HueFilter" /> class.
        /// </summary>
        public HueFilter()
        {
        }

    }
}