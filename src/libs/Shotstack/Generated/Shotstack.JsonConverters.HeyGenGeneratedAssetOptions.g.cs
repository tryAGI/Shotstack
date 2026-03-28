#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Shotstack.JsonConverters
{
    /// <inheritdoc />
    public class HeyGenGeneratedAssetOptionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Shotstack.HeyGenGeneratedAssetOptions>
    {
        /// <inheritdoc />
        public override global::Shotstack.HeyGenGeneratedAssetOptions Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.HeyGenGeneratedAssetOptionsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.HeyGenGeneratedAssetOptionsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.HeyGenGeneratedAssetOptionsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Shotstack.HeyGenTextToAvatarOptions? textToAvatar = default;
            if (discriminator?.Type == global::Shotstack.HeyGenGeneratedAssetOptionsDiscriminatorType.TextToAvatar)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.HeyGenTextToAvatarOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.HeyGenTextToAvatarOptions> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Shotstack.HeyGenTextToAvatarOptions)}");
                textToAvatar = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Shotstack.HeyGenGeneratedAssetOptions(
                discriminator?.Type,
                textToAvatar
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Shotstack.HeyGenGeneratedAssetOptions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTextToAvatar)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Shotstack.HeyGenTextToAvatarOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Shotstack.HeyGenTextToAvatarOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Shotstack.HeyGenTextToAvatarOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToAvatar, typeInfo);
            }
        }
    }
}