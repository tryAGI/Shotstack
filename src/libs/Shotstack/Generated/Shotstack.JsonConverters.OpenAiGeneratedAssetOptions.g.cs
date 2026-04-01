#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Shotstack.JsonConverters
{
    /// <inheritdoc />
    public class OpenAiGeneratedAssetOptionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Shotstack.OpenAiGeneratedAssetOptions>
    {
        /// <inheritdoc />
        public override global::Shotstack.OpenAiGeneratedAssetOptions Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.OpenAiGeneratedAssetOptionsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.OpenAiGeneratedAssetOptionsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.OpenAiGeneratedAssetOptionsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Shotstack.OpenAiTextGeneratorOptions? textGenerator = default;
            if (discriminator?.Type == global::Shotstack.OpenAiGeneratedAssetOptionsDiscriminatorType.TextGenerator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.OpenAiTextGeneratorOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.OpenAiTextGeneratorOptions> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.OpenAiTextGeneratorOptions)}");
                textGenerator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Shotstack.OpenAiGeneratedAssetOptions(
                discriminator?.Type,
                textGenerator
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Shotstack.OpenAiGeneratedAssetOptions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTextGenerator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.OpenAiTextGeneratorOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.OpenAiTextGeneratorOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.OpenAiTextGeneratorOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextGenerator!, typeInfo);
            }
        }
    }
}