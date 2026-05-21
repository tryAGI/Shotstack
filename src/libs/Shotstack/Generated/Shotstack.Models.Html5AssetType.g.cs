
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The type of asset - set to `html5` for HTML5/CSS3/JS.<br/>
    /// Default Value: html5
    /// </summary>
    public enum Html5AssetType
    {
        /// <summary>
        /// 
        /// </summary>
        Html5,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Html5AssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Html5AssetType value)
        {
            return value switch
            {
                Html5AssetType.Html5 => "html5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Html5AssetType? ToEnum(string value)
        {
            return value switch
            {
                "html5" => Html5AssetType.Html5,
                _ => null,
            };
        }
    }
}