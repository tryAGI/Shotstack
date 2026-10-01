#nullable enable

namespace Shotstack.JsonConverters
{
    /// <inheritdoc />
    public sealed class GenerationAssetTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Shotstack.GenerationAssetType?>
    {
        /// <inheritdoc />
        public override global::Shotstack.GenerationAssetType? Read(
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
                        return global::Shotstack.GenerationAssetTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Shotstack.GenerationAssetType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Shotstack.GenerationAssetType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Shotstack.GenerationAssetType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Shotstack.GenerationAssetTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
