#nullable enable

namespace Shotstack.JsonConverters
{
    /// <inheritdoc />
    public sealed class BrightnessFilterTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Shotstack.BrightnessFilterType>
    {
        /// <inheritdoc />
        public override global::Shotstack.BrightnessFilterType Read(
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
                        return global::Shotstack.BrightnessFilterTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Shotstack.BrightnessFilterType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Shotstack.BrightnessFilterType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Shotstack.BrightnessFilterType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Shotstack.BrightnessFilterTypeExtensions.ToValueString(value));
        }
    }
}
