// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Tooling.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Parameters for static validation (semantic and model)
    /// </summary>
    public partial class StaticValidationParameters
    {
        /// <summary>
        /// Initializes a new instance of the StaticValidationParameters class.
        /// </summary>
        public StaticValidationParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StaticValidationParameters class.
        /// </summary>
        /// <param name="commitHash">Commit Hash</param>
        /// <param name="token">Token to access private repositories.</param>
        public StaticValidationParameters(IList<string> fileUrls, string commitHash, string token = default(string))
        {
            FileUrls = fileUrls;
            CommitHash = commitHash;
            Token = token;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fileUrls")]
        public IList<string> FileUrls { get; set; }

        /// <summary>
        /// Gets or sets commit Hash
        /// </summary>
        [JsonProperty(PropertyName = "commitHash")]
        public string CommitHash { get; set; }

        /// <summary>
        /// Gets or sets token to access private repositories.
        /// </summary>
        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FileUrls == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FileUrls");
            }
            if (CommitHash == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CommitHash");
            }
        }
    }
}
