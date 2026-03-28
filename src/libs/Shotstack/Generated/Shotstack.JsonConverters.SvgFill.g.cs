#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Shotstack.JsonConverters
{
    /// <inheritdoc />
    public class SvgFillJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Shotstack.SvgFill>
    {
        /// <inheritdoc />
        public override global::Shotstack.SvgFill Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgFillDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgFillDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.SvgFillDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Shotstack.SvgSolidFill? solid = default;
            if (discriminator?.Type == global::Shotstack.SvgFillDiscriminatorType.Solid)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgSolidFill), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgSolidFill> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.SvgSolidFill)}");
                solid = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.SvgLinearGradientFill? linear = default;
            if (discriminator?.Type == global::Shotstack.SvgFillDiscriminatorType.Linear)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgLinearGradientFill), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgLinearGradientFill> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.SvgLinearGradientFill)}");
                linear = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.SvgRadialGradientFill? radial = default;
            if (discriminator?.Type == global::Shotstack.SvgFillDiscriminatorType.Radial)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgRadialGradientFill), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgRadialGradientFill> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.SvgRadialGradientFill)}");
                radial = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Shotstack.SvgFill(
                discriminator?.Type,
                solid,

                linear,

                radial
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Shotstack.SvgFill value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSolid)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgSolidFill), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgSolidFill?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.SvgSolidFill).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Solid, typeInfo);
            }
            else if (value.IsLinear)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgLinearGradientFill), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgLinearGradientFill?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.SvgLinearGradientFill).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Linear, typeInfo);
            }
            else if (value.IsRadial)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SvgRadialGradientFill), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SvgRadialGradientFill?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.SvgRadialGradientFill).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Radial, typeInfo);
            }
        }
    }
}