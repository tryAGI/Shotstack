
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Increases or decreases the intensity of the colors in the clip.
    /// </summary>
    public sealed partial class SaturationFilter
    {
        /// <summary>
        /// The filter type - set to `saturation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.SaturationFilterTypeJsonConverter))]
        public global::Shotstack.SaturationFilterType Type { get; set; }

        /// <summary>
        /// Sets the saturation of the clip. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
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
        /// Initializes a new instance of the <see cref="SaturationFilter" /> class.
        /// </summary>
        /// <param name="type">
        /// The filter type - set to `saturation`.
        /// </param>
        /// <param name="value">
        /// Sets the saturation of the clip. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SaturationFilter(
            global::Shotstack.SaturationFilterType type,
            global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? value)
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaturationFilter" /> class.
        /// </summary>
        public SaturationFilter()
        {
        }

    }
}