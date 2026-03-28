
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// A heart shape commonly used for love/like icons.<br/>
    /// The heart is defined by a single size parameter.
    /// </summary>
    public sealed partial class SvgHeartShape
    {
        /// <summary>
        /// The shape type - set to `heart`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.SvgHeartShapeTypeJsonConverter))]
        public global::Shotstack.SvgHeartShapeType Type { get; set; }

        /// <summary>
        /// The size of the heart in pixels.<br/>
        /// This determines both the width and height proportionally.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgHeartShape" /> class.
        /// </summary>
        /// <param name="type">
        /// The shape type - set to `heart`.
        /// </param>
        /// <param name="size">
        /// The size of the heart in pixels.<br/>
        /// This determines both the width and height proportionally.<br/>
        /// Example: 100
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SvgHeartShape(
            double size,
            global::Shotstack.SvgHeartShapeType type)
        {
            this.Size = size;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgHeartShape" /> class.
        /// </summary>
        public SvgHeartShape()
        {
        }
    }
}