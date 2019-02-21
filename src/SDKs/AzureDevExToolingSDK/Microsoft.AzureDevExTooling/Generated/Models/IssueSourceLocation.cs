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
    /// Document/Position of the Static Validation result.
    /// </summary>
    public partial class IssueSourceLocation
    {
        /// <summary>
        /// Initializes a new instance of the IssueSourceLocation class.
        /// </summary>
        public IssueSourceLocation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IssueSourceLocation class.
        /// </summary>
        /// <param name="url">url</param>
        /// <param name="length">the length of the word with issue</param>
        /// <param name="jsonRef">Json ref location of the issue.</param>
        /// <param name="jsonPath">Json path of location of the issue.</param>
        public IssueSourceLocation(string url = default(string), int? length = default(int?), string jsonRef = default(string), string jsonPath = default(string), IssueSourceLocationPosition position = default(IssueSourceLocationPosition))
        {
            Url = url;
            Length = length;
            JsonRef = jsonRef;
            JsonPath = jsonPath;
            Position = position;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets url
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the length of the word with issue
        /// </summary>
        [JsonProperty(PropertyName = "length")]
        public int? Length { get; set; }

        /// <summary>
        /// Gets or sets json ref location of the issue.
        /// </summary>
        [JsonProperty(PropertyName = "jsonRef")]
        public string JsonRef { get; set; }

        /// <summary>
        /// Gets or sets json path of location of the issue.
        /// </summary>
        [JsonProperty(PropertyName = "jsonPath")]
        public string JsonPath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public IssueSourceLocationPosition Position { get; set; }

    }
}
