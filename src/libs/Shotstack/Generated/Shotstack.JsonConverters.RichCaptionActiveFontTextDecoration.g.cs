#nullable enable

namespace Shotstack.JsonConverters
{
    /// <inheritdoc />
    public sealed class RichCaptionActiveFontTextDecorationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Shotstack.RichCaptionActiveFontTextDecoration>
    {
        /// <inheritdoc />
        public override global::Shotstack.RichCaptionActiveFontTextDecoration Read(
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
                        return global::Shotstack.RichCaptionActiveFontTextDecorationExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Shotstack.RichCaptionActiveFontTextDecoration)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Shotstack.RichCaptionActiveFontTextDecoration);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Shotstack.RichCaptionActiveFontTextDecoration value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Shotstack.RichCaptionActiveFontTextDecorationExtensions.ToValueString(value));
        }
    }
}
