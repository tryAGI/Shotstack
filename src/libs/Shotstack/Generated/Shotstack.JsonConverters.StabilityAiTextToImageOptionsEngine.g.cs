#nullable enable

namespace Shotstack.JsonConverters
{
    /// <inheritdoc />
    public sealed class StabilityAiTextToImageOptionsEngineJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Shotstack.StabilityAiTextToImageOptionsEngine>
    {
        /// <inheritdoc />
        public override global::Shotstack.StabilityAiTextToImageOptionsEngine Read(
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
                        return global::Shotstack.StabilityAiTextToImageOptionsEngineExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Shotstack.StabilityAiTextToImageOptionsEngine)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Shotstack.StabilityAiTextToImageOptionsEngine);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Shotstack.StabilityAiTextToImageOptionsEngine value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Shotstack.StabilityAiTextToImageOptionsEngineExtensions.ToValueString(value));
        }
    }
}
