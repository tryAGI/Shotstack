
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Aspect ratio for the generated video. Only meaningful when `prompt` is set and the model supports it.<br/>
    /// Example: 16:9
    /// </summary>
    public enum VideoAssetAspectRatio
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
    public static class VideoAssetAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoAssetAspectRatio value)
        {
            return value switch
            {
                VideoAssetAspectRatio.x16_9 => "16:9",
                VideoAssetAspectRatio.x1_1 => "1:1",
                VideoAssetAspectRatio.x21_9 => "21:9",
                VideoAssetAspectRatio.x3_4 => "3:4",
                VideoAssetAspectRatio.x4_3 => "4:3",
                VideoAssetAspectRatio.x9_16 => "9:16",
                VideoAssetAspectRatio.x9_21 => "9:21",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoAssetAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => VideoAssetAspectRatio.x16_9,
                "1:1" => VideoAssetAspectRatio.x1_1,
                "21:9" => VideoAssetAspectRatio.x21_9,
                "3:4" => VideoAssetAspectRatio.x3_4,
                "4:3" => VideoAssetAspectRatio.x4_3,
                "9:16" => VideoAssetAspectRatio.x9_16,
                "9:21" => VideoAssetAspectRatio.x9_21,
                _ => null,
            };
        }
    }
}