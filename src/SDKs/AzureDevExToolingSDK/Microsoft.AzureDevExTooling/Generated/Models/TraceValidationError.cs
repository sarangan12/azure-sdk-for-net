// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Tooling.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class TraceValidationError
    {
        /// <summary>
        /// Initializes a new instance of the TraceValidationError class.
        /// </summary>
        public TraceValidationError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TraceValidationError class.
        /// </summary>
        /// <param name="severity">Severity</param>
        /// <param name="errorCode">Error Code</param>
        /// <param name="errorDetails">Error Details</param>
        /// <param name="source">Source</param>
        /// <param name="count">count</param>
        public TraceValidationError(int? severity = default(int?), string errorCode = default(string), object errorDetails = default(object), string source = default(string), int? count = default(int?))
        {
            Severity = severity;
            ErrorCode = errorCode;
            ErrorDetails = errorDetails;
            Source = source;
            Count = count;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets severity
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public int? Severity { get; set; }

        /// <summary>
        /// Gets or sets error Code
        /// </summary>
        [JsonProperty(PropertyName = "errorCode")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets error Details
        /// </summary>
        [JsonProperty(PropertyName = "errorDetails")]
        public object ErrorDetails { get; set; }

        /// <summary>
        /// Gets or sets source
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets count
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }

    }
}
