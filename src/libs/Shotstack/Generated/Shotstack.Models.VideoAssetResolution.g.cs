
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Output resolution for video generation. Only meaningful when `prompt` is set and the model supports it (e.g. `fal/seedance-2.0`).<br/>
    /// Example: 720p
    /// </summary>
    public enum VideoAssetResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x1080p,
        /// <summary>
        /// 
        /// </summary>
        x480p,
        /// <summary>
        /// 
        /// </summary>
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoAssetResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoAssetResolution value)
        {
            return value switch
            {
                VideoAssetResolution.x1080p => "1080p",
                VideoAssetResolution.x480p => "480p",
                VideoAssetResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoAssetResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => VideoAssetResolution.x1080p,
                "480p" => VideoAssetResolution.x480p,
                "720p" => VideoAssetResolution.x720p,
                _ => null,
            };
        }
    }
}