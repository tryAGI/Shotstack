
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Why `available` is false. `AiCapabilityNotIncluded`: the account's plan does not include this kind of generation. `AiDisabled`: AI generation is turned off for the account. `AiAccessUnavailable`: access could not be confirmed; try again later.<br/>
    /// Example: AiCapabilityNotIncluded
    /// </summary>
    public enum GenerationModelUnavailableReason
    {
        /// <summary>
        /// the account's plan does not include this kind of generation. `AiDisabled`: AI generation is turned off for the account. `AiAccessUnavailable`: access could not be confirmed; try again later.
        /// </summary>
        AiAccessUnavailable,
        /// <summary>
        /// the account's plan does not include this kind of generation. `AiDisabled`: AI generation is turned off for the account. `AiAccessUnavailable`: access could not be confirmed; try again later.
        /// </summary>
        AiCapabilityNotIncluded,
        /// <summary>
        /// the account's plan does not include this kind of generation. `AiDisabled`: AI generation is turned off for the account. `AiAccessUnavailable`: access could not be confirmed; try again later.
        /// </summary>
        AiDisabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationModelUnavailableReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationModelUnavailableReason value)
        {
            return value switch
            {
                GenerationModelUnavailableReason.AiAccessUnavailable => "AiAccessUnavailable",
                GenerationModelUnavailableReason.AiCapabilityNotIncluded => "AiCapabilityNotIncluded",
                GenerationModelUnavailableReason.AiDisabled => "AiDisabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationModelUnavailableReason? ToEnum(string value)
        {
            return value switch
            {
                "AiAccessUnavailable" => GenerationModelUnavailableReason.AiAccessUnavailable,
                "AiCapabilityNotIncluded" => GenerationModelUnavailableReason.AiCapabilityNotIncluded,
                "AiDisabled" => GenerationModelUnavailableReason.AiDisabled,
                _ => null,
            };
        }
    }
}