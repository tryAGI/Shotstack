
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// The weight of the font for the active word. Can be a number (100-900) or a string. Inherits from the base font.weight when not set.<br/>
    /// Default Value: 400
    /// </summary>
    public sealed partial class RichCaptionActiveFontWeight
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}