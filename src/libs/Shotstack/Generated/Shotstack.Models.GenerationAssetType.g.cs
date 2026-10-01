
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The kind of asset to generate.<br/>
    /// Example: image
    /// </summary>
    public enum GenerationAssetType
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
    public static class GenerationAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationAssetType value)
        {
            return value switch
            {
                GenerationAssetType.Audio => "audio",
                GenerationAssetType.Image => "image",
                GenerationAssetType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationAssetType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => GenerationAssetType.Audio,
                "image" => GenerationAssetType.Image,
                "video" => GenerationAssetType.Video,
                _ => null,
            };
        }
    }
}