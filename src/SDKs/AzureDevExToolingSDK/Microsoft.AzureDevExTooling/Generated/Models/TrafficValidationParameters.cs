// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Tooling.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class TrafficValidationParameters
    {
        /// <summary>
        /// Initializes a new instance of the TrafficValidationParameters
        /// class.
        /// </summary>
        public TrafficValidationParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TrafficValidationParameters
        /// class.
        /// </summary>
        /// <param name="repository">The url of the repository.</param>
        /// <param name="gitRef">Name of the specific reference in the git
        /// repository. This can be a branch, tag or a commit hash.</param>
        /// <param name="resourceProvider">Resource provider for which to
        /// perform traffic validation.</param>
        /// <param name="apiVersions">API versions of the resource provider to
        /// use for the real traffic validation. If empty all api versions will
        /// be used.</param>
        /// <param name="startDate">Start date of the real traffic to be
        /// used.</param>
        /// <param name="endDate">End date of the real traffic to be
        /// used.</param>
        /// <param name="regions">Azure regions of the real traffic that will
        /// be used. If empty all regions will be used.</param>
        /// <param name="token">Token to access private repositories.</param>
        public TrafficValidationParameters(string repository, string gitRef, string resourceProvider, IList<string> apiVersions, System.DateTime startDate, System.DateTime endDate, IList<Region?> regions, string token = default(string))
        {
            Repository = repository;
            GitRef = gitRef;
            ResourceProvider = resourceProvider;
            ApiVersions = apiVersions;
            StartDate = startDate;
            EndDate = endDate;
            Regions = regions;
            Token = token;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the url of the repository.
        /// </summary>
        [JsonProperty(PropertyName = "repository")]
        public string Repository { get; set; }

        /// <summary>
        /// Gets or sets name of the specific reference in the git repository.
        /// This can be a branch, tag or a commit hash.
        /// </summary>
        [JsonProperty(PropertyName = "gitRef")]
        public string GitRef { get; set; }

        /// <summary>
        /// Gets or sets resource provider for which to perform traffic
        /// validation.
        /// </summary>
        [JsonProperty(PropertyName = "resourceProvider")]
        public string ResourceProvider { get; set; }

        /// <summary>
        /// Gets or sets API versions of the resource provider to use for the
        /// real traffic validation. If empty all api versions will be used.
        /// </summary>
        [JsonProperty(PropertyName = "apiVersions")]
        public IList<string> ApiVersions { get; set; }

        /// <summary>
        /// Gets or sets start date of the real traffic to be used.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets end date of the real traffic to be used.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "endDate")]
        public System.DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets azure regions of the real traffic that will be used.
        /// If empty all regions will be used.
        /// </summary>
        [JsonProperty(PropertyName = "regions")]
        public IList<Region?> Regions { get; set; }

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
            if (Repository == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Repository");
            }
            if (GitRef == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "GitRef");
            }
            if (ResourceProvider == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceProvider");
            }
            if (ApiVersions == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ApiVersions");
            }
            if (Regions == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Regions");
            }
        }
    }
}
