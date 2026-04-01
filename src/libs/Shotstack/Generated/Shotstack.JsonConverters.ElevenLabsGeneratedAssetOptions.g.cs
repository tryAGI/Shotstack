#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Shotstack.JsonConverters
{
    /// <inheritdoc />
    public class ElevenLabsGeneratedAssetOptionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Shotstack.ElevenLabsGeneratedAssetOptions>
    {
        /// <inheritdoc />
        public override global::Shotstack.ElevenLabsGeneratedAssetOptions Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.ElevenLabsGeneratedAssetOptionsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.ElevenLabsGeneratedAssetOptionsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.ElevenLabsGeneratedAssetOptionsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Shotstack.ElevenLabsTextToSpeechOptions? textToSpeech = default;
            if (discriminator?.Type == global::Shotstack.ElevenLabsGeneratedAssetOptionsDiscriminatorType.TextToSpeech)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.ElevenLabsTextToSpeechOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.ElevenLabsTextToSpeechOptions> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.ElevenLabsTextToSpeechOptions)}");
                textToSpeech = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Shotstack.ElevenLabsGeneratedAssetOptions(
                discriminator?.Type,
                textToSpeech
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Shotstack.ElevenLabsGeneratedAssetOptions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTextToSpeech)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.ElevenLabsTextToSpeechOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.ElevenLabsTextToSpeechOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.ElevenLabsTextToSpeechOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToSpeech!, typeInfo);
            }
        }
    }
}