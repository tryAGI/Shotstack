
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Inverts the clip, turning light areas dark and dark areas light. It has no properties other than `type` and cannot be animated.
    /// </summary>
    public sealed partial class NegativeFilter
    {
        /// <summary>
        /// The filter type - set to `negative`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.NegativeFilterTypeJsonConverter))]
        public global::Shotstack.NegativeFilterType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NegativeFilter" /> class.
        /// </summary>
        /// <param name="type">
        /// The filter type - set to `negative`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NegativeFilter(
            global::Shotstack.NegativeFilterType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NegativeFilter" /> class.
        /// </summary>
        public NegativeFilter()
        {
        }

    }
}