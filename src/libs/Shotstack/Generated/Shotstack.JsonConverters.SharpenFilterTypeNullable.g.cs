#nullable enable

namespace Shotstack.JsonConverters
{
    /// <inheritdoc />
    public sealed class SharpenFilterTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Shotstack.SharpenFilterType?>
    {
        /// <inheritdoc />
        public override global::Shotstack.SharpenFilterType? Read(
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
                        return global::Shotstack.SharpenFilterTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Shotstack.SharpenFilterType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Shotstack.SharpenFilterType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Shotstack.SharpenFilterType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Shotstack.SharpenFilterTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
