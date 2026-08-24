#nullable enable

namespace Shotstack.JsonConverters
{
    /// <inheritdoc />
    public sealed class GenerationModelPricingUnitNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Shotstack.GenerationModelPricingUnit?>
    {
        /// <inheritdoc />
        public override global::Shotstack.GenerationModelPricingUnit? Read(
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
                        return global::Shotstack.GenerationModelPricingUnitExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Shotstack.GenerationModelPricingUnit)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Shotstack.GenerationModelPricingUnit?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Shotstack.GenerationModelPricingUnit? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Shotstack.GenerationModelPricingUnitExtensions.ToValueString(value.Value));
            }
        }
    }
}
