
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The ShapeAsset is used to add shapes to a video. The shape can be styled with a fill and a stroke.<br/>
    /// You can manipulate properties such as rotation to create dynamic effects like a diamond shape or stripes.
    /// </summary>
    public sealed partial class ShapeAsset
    {
        /// <summary>
        /// The type of asset - set to `shape` for shape.<br/>
        /// Default Value: shape
        /// </summary>
        /// <default>global::Shotstack.ShapeAssetType.Shape</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.ShapeAssetTypeJsonConverter))]
        public global::Shotstack.ShapeAssetType Type { get; set; } = global::Shotstack.ShapeAssetType.Shape;

        /// <summary>
        /// The shape to display.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shape")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Shotstack.JsonConverters.ShapeAssetShapeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Shotstack.ShapeAssetShape Shape { get; set; }

        /// <summary>
        /// Sets the width of the bounding box in pixels. This value should be larger than the shape's width. If omitted, the entire viewport width and height will be used.<br/>
        /// Example: 800
        /// </summary>
        /// <example>800</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Sets the height of the bounding box in pixels. This value should be larger than the shape's height. If omitted, the entire viewport width and height will be used.<br/>
        /// Example: 800
        /// </summary>
        /// <example>800</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Specifies the fill style of the shape.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fill")]
        public global::Shotstack.ShapeAssetFill? Fill { get; set; }

        /// <summary>
        /// Specifies the stroke style of the shape.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stroke")]
        public global::Shotstack.ShapeAssetStroke? Stroke { get; set; }

        /// <summary>
        /// Configuration settings for the rectangle shape. Required when `shape` is set to `rectangle`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rectangle")]
        public global::Shotstack.ShapeAssetRectangle? Rectangle { get; set; }

        /// <summary>
        /// Configuration settings for the circle shape. Required when `shape` is set to `circle`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("circle")]
        public global::Shotstack.ShapeAssetCircle? Circle { get; set; }

        /// <summary>
        /// Configuration settings for the line shape. Required when `shape` is set to `line`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line")]
        public global::Shotstack.ShapeAssetLine? Line { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeAsset" /> class.
        /// </summary>
        /// <param name="shape">
        /// The shape to display.
        /// </param>
        /// <param name="width">
        /// Sets the width of the bounding box in pixels. This value should be larger than the shape's width. If omitted, the entire viewport width and height will be used.<br/>
        /// Example: 800
        /// </param>
        /// <param name="height">
        /// Sets the height of the bounding box in pixels. This value should be larger than the shape's height. If omitted, the entire viewport width and height will be used.<br/>
        /// Example: 800
        /// </param>
        /// <param name="fill">
        /// Specifies the fill style of the shape.
        /// </param>
        /// <param name="stroke">
        /// Specifies the stroke style of the shape.
        /// </param>
        /// <param name="rectangle">
        /// Configuration settings for the rectangle shape. Required when `shape` is set to `rectangle`.
        /// </param>
        /// <param name="circle">
        /// Configuration settings for the circle shape. Required when `shape` is set to `circle`.
        /// </param>
        /// <param name="line">
        /// Configuration settings for the line shape. Required when `shape` is set to `line`.
        /// </param>
        /// <param name="type">
        /// The type of asset - set to `shape` for shape.<br/>
        /// Default Value: shape
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShapeAsset(
            global::Shotstack.ShapeAssetShape shape,
            int? width,
            int? height,
            global::Shotstack.ShapeAssetFill? fill,
            global::Shotstack.ShapeAssetStroke? stroke,
            global::Shotstack.ShapeAssetRectangle? rectangle,
            global::Shotstack.ShapeAssetCircle? circle,
            global::Shotstack.ShapeAssetLine? line,
            global::Shotstack.ShapeAssetType type = global::Shotstack.ShapeAssetType.Shape)
        {
            this.Type = type;
            this.Shape = shape;
            this.Width = width;
            this.Height = height;
            this.Fill = fill;
            this.Stroke = stroke;
            this.Rectangle = rectangle;
            this.Circle = circle;
            this.Line = line;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeAsset" /> class.
        /// </summary>
        public ShapeAsset()
        {
        }
    }
}