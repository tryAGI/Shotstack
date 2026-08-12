
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The status of the generation job.<br/>
    /// Example: done
    /// </summary>
    public enum GenerationResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationResponseStatus value)
        {
            return value switch
            {
                GenerationResponseStatus.Done => "done",
                GenerationResponseStatus.Failed => "failed",
                GenerationResponseStatus.Processing => "processing",
                GenerationResponseStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "done" => GenerationResponseStatus.Done,
                "failed" => GenerationResponseStatus.Failed,
                "processing" => GenerationResponseStatus.Processing,
                "queued" => GenerationResponseStatus.Queued,
                _ => null,
            };
        }
    }
}