#nullable enable

namespace Shotstack.JsonConverters
{
    /// <inheritdoc />
    public sealed class ImageToVideoAssetAspectRatioJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Shotstack.ImageToVideoAssetAspectRatio>
    {
        /// <inheritdoc />
        public override global::Shotstack.ImageToVideoAssetAspectRatio Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Shotstack.ImageToVideoAssetAspectRatioExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Shotstack.ImageToVideoAssetAspectRatio)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Shotstack.ImageToVideoAssetAspectRatio);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Shotstack.ImageToVideoAssetAspectRatio value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Shotstack.ImageToVideoAssetAspectRatioExtensions.ToValueString(value));
        }
    }
}
