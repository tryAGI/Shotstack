#nullable enable

namespace Shotstack.JsonConverters
{
    /// <inheritdoc />
    public sealed class GenerationModelPricingQuantityRoundJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Shotstack.GenerationModelPricingQuantityRound>
    {
        /// <inheritdoc />
        public override global::Shotstack.GenerationModelPricingQuantityRound Read(
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
                        return global::Shotstack.GenerationModelPricingQuantityRoundExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Shotstack.GenerationModelPricingQuantityRound)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Shotstack.GenerationModelPricingQuantityRound);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Shotstack.GenerationModelPricingQuantityRound value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Shotstack.GenerationModelPricingQuantityRoundExtensions.ToValueString(value));
        }
    }
}
