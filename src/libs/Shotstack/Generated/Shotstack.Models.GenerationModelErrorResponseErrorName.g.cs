
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// `UnknownGenerationModel`: no model has this identifier. `WithdrawnGenerationModel`: the model is no longer listed, but edits that already use it still validate, bill and render.<br/>
    /// Example: UnknownGenerationModel
    /// </summary>
    public enum GenerationModelErrorResponseErrorName
    {
        /// <summary>
        /// no model has this identifier. `WithdrawnGenerationModel`: the model is no longer listed, but edits that already use it still validate, bill and render.
        /// </summary>
        UnknownGenerationModel,
        /// <summary>
        /// no model has this identifier. `WithdrawnGenerationModel`: the model is no longer listed, but edits that already use it still validate, bill and render.
        /// </summary>
        WithdrawnGenerationModel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationModelErrorResponseErrorNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationModelErrorResponseErrorName value)
        {
            return value switch
            {
                GenerationModelErrorResponseErrorName.UnknownGenerationModel => "UnknownGenerationModel",
                GenerationModelErrorResponseErrorName.WithdrawnGenerationModel => "WithdrawnGenerationModel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationModelErrorResponseErrorName? ToEnum(string value)
        {
            return value switch
            {
                "UnknownGenerationModel" => GenerationModelErrorResponseErrorName.UnknownGenerationModel,
                "WithdrawnGenerationModel" => GenerationModelErrorResponseErrorName.WithdrawnGenerationModel,
                _ => null,
            };
        }
    }
}