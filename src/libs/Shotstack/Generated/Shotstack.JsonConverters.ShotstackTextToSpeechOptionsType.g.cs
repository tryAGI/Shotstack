#nullable enable

namespace Shotstack.JsonConverters
{
    /// <inheritdoc />
    public sealed class ShotstackTextToSpeechOptionsTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Shotstack.ShotstackTextToSpeechOptionsType>
    {
        /// <inheritdoc />
        public override global::Shotstack.ShotstackTextToSpeechOptionsType Read(
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
                        return global::Shotstack.ShotstackTextToSpeechOptionsTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Shotstack.ShotstackTextToSpeechOptionsType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Shotstack.ShotstackTextToSpeechOptionsType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Shotstack.ShotstackTextToSpeechOptionsType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Shotstack.ShotstackTextToSpeechOptionsTypeExtensions.ToValueString(value));
        }
    }
}
