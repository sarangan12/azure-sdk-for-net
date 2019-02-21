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

    public partial class TrafficValidationDetails
    {
        /// <summary>
        /// Initializes a new instance of the TrafficValidationDetails class.
        /// </summary>
        public TrafficValidationDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TrafficValidationDetails class.
        /// </summary>
        /// <param name="status">Status</param>
        /// <param name="repository">repository</param>
        /// <param name="commitHash">The reference used for the source files
        /// that were used to validate against.</param>
        /// <param name="resourceProvider">The resource provider for the
        /// validation.</param>
        /// <param name="apiVersions">The API versions for the
        /// validation.</param>
        /// <param name="startDate">Start date of traffic to be
        /// validated.</param>
        /// <param name="endDate">End date of traffic to be validated.</param>
        /// <param name="validationId">Validation Id.</param>
        /// <param name="validationStatus">Task Status. Possible values
        /// include: 'NotStarted', 'InProgress', 'Finished', 'Failed'</param>
        /// <param name="createdAt">The time of when the validation
        /// started.</param>
        /// <param name="regions">Azure regions where the operation was
        /// encountered.</param>
        /// <param name="unmatchedOperations">Traffic for which no operations
        /// from the spec could me matched against.</param>
        /// <param name="uniqueIssues">Unique issues from the traffic
        /// validation.</param>
        public TrafficValidationDetails(string status, string repository, string commitHash, string resourceProvider, IList<string> apiVersions, System.DateTime startDate, System.DateTime endDate, string validationId, ValidationStatus validationStatus, string createdAt, IList<Region?> regions, IList<UnmatchedOperation> unmatchedOperations, IList<TrafficValidationIssue> uniqueIssues)
        {
            Status = status;
            Repository = repository;
            CommitHash = commitHash;
            ResourceProvider = resourceProvider;
            ApiVersions = apiVersions;
            StartDate = startDate;
            EndDate = endDate;
            ValidationId = validationId;
            ValidationStatus = validationStatus;
            CreatedAt = createdAt;
            Regions = regions;
            UnmatchedOperations = unmatchedOperations;
            UniqueIssues = uniqueIssues;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets repository
        /// </summary>
        [JsonProperty(PropertyName = "repository")]
        public string Repository { get; set; }

        /// <summary>
        /// Gets or sets the reference used for the source files that were used
        /// to validate against.
        /// </summary>
        [JsonProperty(PropertyName = "commitHash")]
        public string CommitHash { get; set; }

        /// <summary>
        /// Gets or sets the resource provider for the validation.
        /// </summary>
        [JsonProperty(PropertyName = "resourceProvider")]
        public string ResourceProvider { get; set; }

        /// <summary>
        /// Gets or sets the API versions for the validation.
        /// </summary>
        [JsonProperty(PropertyName = "apiVersions")]
        public IList<string> ApiVersions { get; set; }

        /// <summary>
        /// Gets or sets start date of traffic to be validated.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets end date of traffic to be validated.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "endDate")]
        public System.DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets validation Id.
        /// </summary>
        [JsonProperty(PropertyName = "validationId")]
        public string ValidationId { get; set; }

        /// <summary>
        /// Gets or sets task Status. Possible values include: 'NotStarted',
        /// 'InProgress', 'Finished', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "validationStatus")]
        public ValidationStatus ValidationStatus { get; set; }

        /// <summary>
        /// Gets or sets the time of when the validation started.
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets azure regions where the operation was encountered.
        /// </summary>
        [JsonProperty(PropertyName = "regions")]
        public IList<Region?> Regions { get; set; }

        /// <summary>
        /// Gets or sets traffic for which no operations from the spec could me
        /// matched against.
        /// </summary>
        [JsonProperty(PropertyName = "unmatchedOperations")]
        public IList<UnmatchedOperation> UnmatchedOperations { get; set; }

        /// <summary>
        /// Gets or sets unique issues from the traffic validation.
        /// </summary>
        [JsonProperty(PropertyName = "uniqueIssues")]
        public IList<TrafficValidationIssue> UniqueIssues { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Status == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Status");
            }
            if (Repository == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Repository");
            }
            if (CommitHash == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CommitHash");
            }
            if (ResourceProvider == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceProvider");
            }
            if (ApiVersions == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ApiVersions");
            }
            if (ValidationId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ValidationId");
            }
            if (CreatedAt == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CreatedAt");
            }
            if (Regions == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Regions");
            }
            if (UnmatchedOperations == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UnmatchedOperations");
            }
            if (UniqueIssues == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UniqueIssues");
            }
            if (UnmatchedOperations != null)
            {
                foreach (var element in UnmatchedOperations)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (UniqueIssues != null)
            {
                foreach (var element1 in UniqueIssues)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
