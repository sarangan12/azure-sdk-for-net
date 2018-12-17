// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Tooling.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Semantic Validation Results Error.
    /// </summary>
    public partial class SemanticError
    {
        /// <summary>
        /// Initializes a new instance of the SemanticError class.
        /// </summary>
        public SemanticError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SemanticError class.
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="errorCode">error code</param>
        /// <param name="path">path</param>
        /// <param name="severity">severity</param>
        /// <param name="errorDetails">error details</param>
        public SemanticError(string source = default(string), string errorCode = default(string), string path = default(string), int? severity = default(int?), SemanticErrorErrorDetails errorDetails = default(SemanticErrorErrorDetails))
        {
            Source = source;
            ErrorCode = errorCode;
            Path = path;
            Severity = severity;
            ErrorDetails = errorDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets source
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets error code
        /// </summary>
        [JsonProperty(PropertyName = "errorCode")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets path
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets severity
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public int? Severity { get; set; }

        /// <summary>
        /// Gets or sets error details
        /// </summary>
        [JsonProperty(PropertyName = "errorDetails")]
        public SemanticErrorErrorDetails ErrorDetails { get; set; }

    }
}
