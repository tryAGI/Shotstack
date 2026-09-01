#nullable enable

namespace Shotstack.JsonConverters
{
    /// <inheritdoc />
    public sealed class GenerationModelPricingQuantityMeasureNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Shotstack.GenerationModelPricingQuantityMeasure?>
    {
        /// <inheritdoc />
        public override global::Shotstack.GenerationModelPricingQuantityMeasure? Read(
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
                        return global::Shotstack.GenerationModelPricingQuantityMeasureExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Shotstack.GenerationModelPricingQuantityMeasure)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Shotstack.GenerationModelPricingQuantityMeasure?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Shotstack.GenerationModelPricingQuantityMeasure? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Shotstack.GenerationModelPricingQuantityMeasureExtensions.ToValueString(value.Value));
            }
        }
    }
}
