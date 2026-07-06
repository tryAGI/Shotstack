
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Aspect ratio for the generated image. Only meaningful when `prompt` is set and the model supports it.<br/>
    /// Example: 1:1
    /// </summary>
    public enum ImageAssetAspectRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        x1_1,
        /// <summary>
        /// 
        /// </summary>
        x21_9,
        /// <summary>
        /// 
        /// </summary>
        x3_4,
        /// <summary>
        /// 
        /// </summary>
        x4_3,
        /// <summary>
        /// 
        /// </summary>
        x9_16,
        /// <summary>
        /// 
        /// </summary>
        x9_21,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageAssetAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageAssetAspectRatio value)
        {
            return value switch
            {
                ImageAssetAspectRatio.x16_9 => "16:9",
                ImageAssetAspectRatio.x1_1 => "1:1",
                ImageAssetAspectRatio.x21_9 => "21:9",
                ImageAssetAspectRatio.x3_4 => "3:4",
                ImageAssetAspectRatio.x4_3 => "4:3",
                ImageAssetAspectRatio.x9_16 => "9:16",
                ImageAssetAspectRatio.x9_21 => "9:21",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageAssetAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => ImageAssetAspectRatio.x16_9,
                "1:1" => ImageAssetAspectRatio.x1_1,
                "21:9" => ImageAssetAspectRatio.x21_9,
                "3:4" => ImageAssetAspectRatio.x3_4,
                "4:3" => ImageAssetAspectRatio.x4_3,
                "9:16" => ImageAssetAspectRatio.x9_16,
                "9:21" => ImageAssetAspectRatio.x9_21,
                _ => null,
            };
        }
    }
}