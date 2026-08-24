
#nullable enable

namespace Shotstack
{
    /// <summary>
    /// JSON Schema for the model's `options` object. Only returned for a single model, or for a list requested with `expand=options`. Values outside this schema are rejected.
    /// </summary>
    public sealed partial class GenerationModelOptions
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}