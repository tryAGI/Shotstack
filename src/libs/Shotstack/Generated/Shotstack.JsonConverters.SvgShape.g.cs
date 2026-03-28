#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Shotstack.JsonConverters
{
    /// <inheritdoc />
    public class SvgShapeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Shotstack.SvgShape>
    {
        /// <inheritdoc />
        public override global::Shotstack.SvgShape Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgShapeDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgShapeDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.SvgShapeDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Shotstack.SvgRectangleShape? rectangle = default;
            if (discriminator?.Type == global::Shotstack.SvgShapeDiscriminatorType.Rectangle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgRectangleShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgRectangleShape> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.SvgRectangleShape)}");
                rectangle = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.SvgCircleShape? circle = default;
            if (discriminator?.Type == global::Shotstack.SvgShapeDiscriminatorType.Circle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgCircleShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgCircleShape> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.SvgCircleShape)}");
                circle = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.SvgEllipseShape? ellipse = default;
            if (discriminator?.Type == global::Shotstack.SvgShapeDiscriminatorType.Ellipse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgEllipseShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgEllipseShape> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.SvgEllipseShape)}");
                ellipse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.SvgLineShape? line = default;
            if (discriminator?.Type == global::Shotstack.SvgShapeDiscriminatorType.Line)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgLineShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgLineShape> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.SvgLineShape)}");
                line = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.SvgPolygonShape? polygon = default;
            if (discriminator?.Type == global::Shotstack.SvgShapeDiscriminatorType.Polygon)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgPolygonShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgPolygonShape> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.SvgPolygonShape)}");
                polygon = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.SvgStarShape? star = default;
            if (discriminator?.Type == global::Shotstack.SvgShapeDiscriminatorType.Star)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgStarShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgStarShape> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.SvgStarShape)}");
                star = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.SvgArrowShape? arrow = default;
            if (discriminator?.Type == global::Shotstack.SvgShapeDiscriminatorType.Arrow)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgArrowShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgArrowShape> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.SvgArrowShape)}");
                arrow = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.SvgHeartShape? heart = default;
            if (discriminator?.Type == global::Shotstack.SvgShapeDiscriminatorType.Heart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgHeartShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgHeartShape> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.SvgHeartShape)}");
                heart = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.SvgCrossShape? cross = default;
            if (discriminator?.Type == global::Shotstack.SvgShapeDiscriminatorType.Cross)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgCrossShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgCrossShape> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.SvgCrossShape)}");
                cross = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.SvgRingShape? ring = default;
            if (discriminator?.Type == global::Shotstack.SvgShapeDiscriminatorType.Ring)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgRingShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgRingShape> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.SvgRingShape)}");
                ring = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.SvgPathShape? path = default;
            if (discriminator?.Type == global::Shotstack.SvgShapeDiscriminatorType.Path)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgPathShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgPathShape> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.SvgPathShape)}");
                path = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Shotstack.SvgShape(
                discriminator?.Type,
                rectangle,

                circle,

                ellipse,

                line,

                polygon,

                star,

                arrow,

                heart,

                cross,

                ring,

                path
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Shotstack.SvgShape value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRectangle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgRectangleShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgRectangleShape?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.SvgRectangleShape).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Rectangle, typeInfo);
            }
            else if (value.IsCircle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgCircleShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgCircleShape?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.SvgCircleShape).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Circle, typeInfo);
            }
            else if (value.IsEllipse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgEllipseShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgEllipseShape?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.SvgEllipseShape).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ellipse, typeInfo);
            }
            else if (value.IsLine)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgLineShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgLineShape?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.SvgLineShape).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Line, typeInfo);
            }
            else if (value.IsPolygon)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgPolygonShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgPolygonShape?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.SvgPolygonShape).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Polygon, typeInfo);
            }
            else if (value.IsStar)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgStarShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgStarShape?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.SvgStarShape).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Star, typeInfo);
            }
            else if (value.IsArrow)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgArrowShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgArrowShape?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.SvgArrowShape).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Arrow, typeInfo);
            }
            else if (value.IsHeart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgHeartShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgHeartShape?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.SvgHeartShape).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Heart, typeInfo);
            }
            else if (value.IsCross)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgCrossShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgCrossShape?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.SvgCrossShape).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Cross, typeInfo);
            }
            else if (value.IsRing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgRingShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgRingShape?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.SvgRingShape).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ring, typeInfo);
            }
            else if (value.IsPath)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgPathShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgPathShape?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.SvgPathShape).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Path, typeInfo);
            }
        }
    }
}