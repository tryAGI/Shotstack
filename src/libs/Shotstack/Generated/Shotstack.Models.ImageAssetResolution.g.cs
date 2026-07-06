
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Output resolution tier for supported image generation models. `1K` (default), `2K`, or `4K`. Only meaningful when `prompt` is set.<br/>
    /// Example: 1K
    /// </summary>
    public enum ImageAssetResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x1k,
        /// <summary>
        /// 
        /// </summary>
        x2k,
        /// <summary>
        /// 
        /// </summary>
        x4k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageAssetResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageAssetResolution value)
        {
            return value switch
            {
                ImageAssetResolution.x1k => "1K",
                ImageAssetResolution.x2k => "2K",
                ImageAssetResolution.x4k => "4K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageAssetResolution? ToEnum(string value)
        {
            return value switch
            {
                "1K" => ImageAssetResolution.x1k,
                "2K" => ImageAssetResolution.x2k,
                "4K" => ImageAssetResolution.x4k,
                _ => null,
            };
        }
    }
}