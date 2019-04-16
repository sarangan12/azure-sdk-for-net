// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Tooling.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class IssueSourceLocationPosition
    {
        /// <summary>
        /// Initializes a new instance of the IssueSourceLocationPosition
        /// class.
        /// </summary>
        public IssueSourceLocationPosition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IssueSourceLocationPosition
        /// class.
        /// </summary>
        /// <param name="line">line</param>
        /// <param name="column">column</param>
        public IssueSourceLocationPosition(int? line = default(int?), int? column = default(int?))
        {
            Line = line;
            Column = column;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets line
        /// </summary>
        [JsonProperty(PropertyName = "line")]
        public int? Line { get; set; }

        /// <summary>
        /// Gets or sets column
        /// </summary>
        [JsonProperty(PropertyName = "column")]
        public int? Column { get; set; }

    }
}
