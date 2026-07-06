
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// Target video duration in seconds for generation models that accept it. `"auto"` lets the model decide. Only meaningful when `prompt` is set.<br/>
    /// Default Value: auto<br/>
    /// Example: 5
    /// </summary>
    public enum VideoAssetDuration
    {
        /// <summary>
        /// 
        /// </summary>
        x10,
        /// <summary>
        /// 
        /// </summary>
        x11,
        /// <summary>
        /// 
        /// </summary>
        x12,
        /// <summary>
        /// 
        /// </summary>
        x13,
        /// <summary>
        /// 
        /// </summary>
        x14,
        /// <summary>
        /// 
        /// </summary>
        x15,
        /// <summary>
        /// 
        /// </summary>
        x4,
        /// <summary>
        /// 
        /// </summary>
        x5,
        /// <summary>
        /// 
        /// </summary>
        x6,
        /// <summary>
        /// 
        /// </summary>
        x7,
        /// <summary>
        /// 
        /// </summary>
        x8,
        /// <summary>
        /// 
        /// </summary>
        x9,
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoAssetDurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoAssetDuration value)
        {
            return value switch
            {
                VideoAssetDuration.x10 => "10",
                VideoAssetDuration.x11 => "11",
                VideoAssetDuration.x12 => "12",
                VideoAssetDuration.x13 => "13",
                VideoAssetDuration.x14 => "14",
                VideoAssetDuration.x15 => "15",
                VideoAssetDuration.x4 => "4",
                VideoAssetDuration.x5 => "5",
                VideoAssetDuration.x6 => "6",
                VideoAssetDuration.x7 => "7",
                VideoAssetDuration.x8 => "8",
                VideoAssetDuration.x9 => "9",
                VideoAssetDuration.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoAssetDuration? ToEnum(string value)
        {
            return value switch
            {
                "10" => VideoAssetDuration.x10,
                "11" => VideoAssetDuration.x11,
                "12" => VideoAssetDuration.x12,
                "13" => VideoAssetDuration.x13,
                "14" => VideoAssetDuration.x14,
                "15" => VideoAssetDuration.x15,
                "4" => VideoAssetDuration.x4,
                "5" => VideoAssetDuration.x5,
                "6" => VideoAssetDuration.x6,
                "7" => VideoAssetDuration.x7,
                "8" => VideoAssetDuration.x8,
                "9" => VideoAssetDuration.x9,
                "auto" => VideoAssetDuration.Auto,
                _ => null,
            };
        }
    }
}