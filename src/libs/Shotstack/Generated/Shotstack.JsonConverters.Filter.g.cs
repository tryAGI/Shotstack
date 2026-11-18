#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Shotstack.JsonConverters
{
    /// <inheritdoc />
    public class FilterJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Shotstack.Filter>
    {
        /// <inheritdoc />
        public override global::Shotstack.Filter Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.FilterDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.FilterDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.FilterDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Shotstack.BrightnessFilter? brightness = default;
            if (discriminator?.Type == global::Shotstack.FilterDiscriminatorType.Brightness)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.BrightnessFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.BrightnessFilter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.BrightnessFilter)}");
                brightness = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.ContrastFilter? contrast = default;
            if (discriminator?.Type == global::Shotstack.FilterDiscriminatorType.Contrast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.ContrastFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.ContrastFilter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.ContrastFilter)}");
                contrast = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.SaturationFilter? saturation = default;
            if (discriminator?.Type == global::Shotstack.FilterDiscriminatorType.Saturation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SaturationFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SaturationFilter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.SaturationFilter)}");
                saturation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.HueFilter? hue = default;
            if (discriminator?.Type == global::Shotstack.FilterDiscriminatorType.Hue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.HueFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.HueFilter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.HueFilter)}");
                hue = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.GradeFilter? grade = default;
            if (discriminator?.Type == global::Shotstack.FilterDiscriminatorType.Grade)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.GradeFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.GradeFilter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.GradeFilter)}");
                grade = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.BlurFilter? blur = default;
            if (discriminator?.Type == global::Shotstack.FilterDiscriminatorType.Blur)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.BlurFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.BlurFilter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.BlurFilter)}");
                blur = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.SharpenFilter? sharpen = default;
            if (discriminator?.Type == global::Shotstack.FilterDiscriminatorType.Sharpen)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SharpenFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SharpenFilter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.SharpenFilter)}");
                sharpen = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.PixelateFilter? pixelate = default;
            if (discriminator?.Type == global::Shotstack.FilterDiscriminatorType.Pixelate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.PixelateFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.PixelateFilter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.PixelateFilter)}");
                pixelate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.RgbSplitFilter? rgbSplit = default;
            if (discriminator?.Type == global::Shotstack.FilterDiscriminatorType.RgbSplit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.RgbSplitFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.RgbSplitFilter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.RgbSplitFilter)}");
                rgbSplit = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.NegativeFilter? negative = default;
            if (discriminator?.Type == global::Shotstack.FilterDiscriminatorType.Negative)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.NegativeFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.NegativeFilter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.NegativeFilter)}");
                negative = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Shotstack.Filter(
                discriminator?.Type,
                brightness,

                contrast,

                saturation,

                hue,

                grade,

                blur,

                sharpen,

                pixelate,

                rgbSplit,

                negative
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Shotstack.Filter value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBrightness)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.BrightnessFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.BrightnessFilter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.BrightnessFilter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrightness(), typeInfo);
            }
            else if (value.IsContrast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.ContrastFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.ContrastFilter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.ContrastFilter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickContrast(), typeInfo);
            }
            else if (value.IsSaturation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SaturationFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SaturationFilter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.SaturationFilter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSaturation(), typeInfo);
            }
            else if (value.IsHue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.HueFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.HueFilter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.HueFilter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickHue(), typeInfo);
            }
            else if (value.IsGrade)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.GradeFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.GradeFilter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.GradeFilter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGrade(), typeInfo);
            }
            else if (value.IsBlur)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.BlurFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.BlurFilter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.BlurFilter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBlur(), typeInfo);
            }
            else if (value.IsSharpen)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.SharpenFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.SharpenFilter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.SharpenFilter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSharpen(), typeInfo);
            }
            else if (value.IsPixelate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.PixelateFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.PixelateFilter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.PixelateFilter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickPixelate(), typeInfo);
            }
            else if (value.IsRgbSplit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.RgbSplitFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.RgbSplitFilter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.RgbSplitFilter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRgbSplit(), typeInfo);
            }
            else if (value.IsNegative)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.NegativeFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.NegativeFilter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.NegativeFilter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickNegative(), typeInfo);
            }
        }
    }
}