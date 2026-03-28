#nullable enable

namespace Shotstack.JsonConverters
{
    /// <inheritdoc />
    public sealed class OpenAiTextGeneratorOptionsModelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Shotstack.OpenAiTextGeneratorOptionsModel?>
    {
        /// <inheritdoc />
        public override global::Shotstack.OpenAiTextGeneratorOptionsModel? Read(
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
                        return global::Shotstack.OpenAiTextGeneratorOptionsModelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Shotstack.OpenAiTextGeneratorOptionsModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Shotstack.OpenAiTextGeneratorOptionsModel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Shotstack.OpenAiTextGeneratorOptionsModel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Shotstack.OpenAiTextGeneratorOptionsModelExtensions.ToValueString(value.Value));
            }
        }
    }
}
