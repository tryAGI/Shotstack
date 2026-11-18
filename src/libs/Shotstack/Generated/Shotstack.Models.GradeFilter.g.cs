
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Applies several grading adjustments at once: exposure, temperature, tint, highlights, shadows and vibrance. Every property is optional and an omitted property leaves the clip unchanged.
    /// </summary>
    public sealed partial class GradeFilter
    {
        /// <summary>
        /// The filter type - set to `grade`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.GradeFilterTypeJsonConverter))]
        public global::Shotstack.GradeFilterType Type { get; set; }

        /// <summary>
        /// Sets the exposure of the clip in stops. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exposure")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>))]
        public global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? Exposure { get; set; }

        /// <summary>
        /// Sets the white balance of the clip. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>))]
        public global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? Temperature { get; set; }

        /// <summary>
        /// Sets the tint of the clip between green and magenta. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tint")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>))]
        public global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? Tint { get; set; }

        /// <summary>
        /// Adjusts the brightest areas of the clip. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlights")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>))]
        public global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? Highlights { get; set; }

        /// <summary>
        /// Adjusts the darkest areas of the clip. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shadows")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>))]
        public global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? Shadows { get; set; }

        /// <summary>
        /// Adjusts the saturation of the clip, with a stronger effect on muted colors than on colors that are already vivid. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vibrance")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>))]
        public global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? Vibrance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GradeFilter" /> class.
        /// </summary>
        /// <param name="type">
        /// The filter type - set to `grade`.
        /// </param>
        /// <param name="exposure">
        /// Sets the exposure of the clip in stops. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
        /// </param>
        /// <param name="temperature">
        /// Sets the white balance of the clip. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
        /// </param>
        /// <param name="tint">
        /// Sets the tint of the clip between green and magenta. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
        /// </param>
        /// <param name="highlights">
        /// Adjusts the brightest areas of the clip. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
        /// </param>
        /// <param name="shadows">
        /// Adjusts the darkest areas of the clip. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
        /// </param>
        /// <param name="vibrance">
        /// Adjusts the saturation of the clip, with a stronger effect on muted colors than on colors that are already vivid. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GradeFilter(
            global::Shotstack.GradeFilterType type,
            global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? exposure,
            global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? temperature,
            global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? tint,
            global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? highlights,
            global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? shadows,
            global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? vibrance)
        {
            this.Type = type;
            this.Exposure = exposure;
            this.Temperature = temperature;
            this.Tint = tint;
            this.Highlights = highlights;
            this.Shadows = shadows;
            this.Vibrance = vibrance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GradeFilter" /> class.
        /// </summary>
        public GradeFilter()
        {
        }

    }
}