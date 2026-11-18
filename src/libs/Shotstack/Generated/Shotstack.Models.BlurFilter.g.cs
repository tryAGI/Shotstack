
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Blurs the clip. Set `value` to blur both axes equally, or set `x` and `y` to blur each axis separately.
    /// </summary>
    public sealed partial class BlurFilter
    {
        /// <summary>
        /// The filter type - set to `blur`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.BlurFilterTypeJsonConverter))]
        public global::Shotstack.BlurFilterType Type { get; set; }

        /// <summary>
        /// Sets the blur radius in pixels, measured on the clip before it is scaled to fit the viewport. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>))]
        public global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? Value { get; set; }

        /// <summary>
        /// Sets the horizontal blur radius in pixels, overriding `value` on that axis. When omitted, `value` is used. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>))]
        public global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? X { get; set; }

        /// <summary>
        /// Sets the vertical blur radius in pixels, overriding `value` on that axis. When omitted, `value` is used. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
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
        /// Initializes a new instance of the <see cref="BlurFilter" /> class.
        /// </summary>
        /// <param name="type">
        /// The filter type - set to `blur`.
        /// </param>
        /// <param name="value">
        /// Sets the blur radius in pixels, measured on the clip before it is scaled to fit the viewport. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
        /// </param>
        /// <param name="x">
        /// Sets the horizontal blur radius in pixels, overriding `value` on that axis. When omitted, `value` is used. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
        /// </param>
        /// <param name="y">
        /// Sets the vertical blur radius in pixels, overriding `value` on that axis. When omitted, `value` is used. Use a number or an array of [Tween](./#tocs_tween) objects to change it over time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BlurFilter(
            global::Shotstack.BlurFilterType type,
            global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? value,
            global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? x,
            global::Shotstack.OneOf<double?, global::System.Collections.Generic.IList<global::Shotstack.Tween>>? y)
        {
            this.Type = type;
            this.Value = value;
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlurFilter" /> class.
        /// </summary>
        public BlurFilter()
        {
        }

    }
}