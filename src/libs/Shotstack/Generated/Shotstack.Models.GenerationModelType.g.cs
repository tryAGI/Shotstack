
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The asset type this model generates.<br/>
    /// Example: video
    /// </summary>
    public enum GenerationModelType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationModelType value)
        {
            return value switch
            {
                GenerationModelType.Audio => "audio",
                GenerationModelType.Image => "image",
                GenerationModelType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationModelType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => GenerationModelType.Audio,
                "image" => GenerationModelType.Image,
                "video" => GenerationModelType.Video,
                _ => null,
            };
        }
    }
}