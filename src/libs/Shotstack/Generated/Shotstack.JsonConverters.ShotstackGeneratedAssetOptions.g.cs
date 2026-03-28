#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Shotstack.JsonConverters
{
    /// <inheritdoc />
    public class ShotstackGeneratedAssetOptionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Shotstack.ShotstackGeneratedAssetOptions>
    {
        /// <inheritdoc />
        public override global::Shotstack.ShotstackGeneratedAssetOptions Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.ShotstackGeneratedAssetOptionsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.ShotstackGeneratedAssetOptionsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.ShotstackGeneratedAssetOptionsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Shotstack.ShotstackTextToSpeechOptions? textToSpeech = default;
            if (discriminator?.Type == global::Shotstack.ShotstackGeneratedAssetOptionsDiscriminatorType.TextToSpeech)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.ShotstackTextToSpeechOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.ShotstackTextToSpeechOptions> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.ShotstackTextToSpeechOptions)}");
                textToSpeech = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.ShotstackTextToImageOptions? textToImage = default;
            if (discriminator?.Type == global::Shotstack.ShotstackGeneratedAssetOptionsDiscriminatorType.TextToImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.ShotstackTextToImageOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.ShotstackTextToImageOptions> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.ShotstackTextToImageOptions)}");
                textToImage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.ShotstackTextGeneratorOptions? textGenerator = default;
            if (discriminator?.Type == global::Shotstack.ShotstackGeneratedAssetOptionsDiscriminatorType.TextGenerator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.ShotstackTextGeneratorOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.ShotstackTextGeneratorOptions> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.ShotstackTextGeneratorOptions)}");
                textGenerator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Shotstack.ShotstackImageToVideoOptions? imageToVideo = default;
            if (discriminator?.Type == global::Shotstack.ShotstackGeneratedAssetOptionsDiscriminatorType.ImageToVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.ShotstackImageToVideoOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.ShotstackImageToVideoOptions> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.ShotstackImageToVideoOptions)}");
                imageToVideo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Shotstack.ShotstackGeneratedAssetOptions(
                discriminator?.Type,
                textToSpeech,

                textToImage,

                textGenerator,

                imageToVideo
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Shotstack.ShotstackGeneratedAssetOptions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTextToSpeech)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.ShotstackTextToSpeechOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.ShotstackTextToSpeechOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.ShotstackTextToSpeechOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToSpeech, typeInfo);
            }
            else if (value.IsTextToImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.ShotstackTextToImageOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.ShotstackTextToImageOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.ShotstackTextToImageOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToImage, typeInfo);
            }
            else if (value.IsTextGenerator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.ShotstackTextGeneratorOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.ShotstackTextGeneratorOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.ShotstackTextGeneratorOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextGenerator, typeInfo);
            }
            else if (value.IsImageToVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.ShotstackImageToVideoOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.ShotstackImageToVideoOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.ShotstackImageToVideoOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageToVideo, typeInfo);
            }
        }
    }
}