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
    /// Traffic validation issue.
    /// </summary>
    public partial class TrafficValidationIssue
    {
        /// <summary>
        /// Initializes a new instance of the TrafficValidationIssue class.
        /// </summary>
        public TrafficValidationIssue()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TrafficValidationIssue class.
        /// </summary>
        /// <param name="code">The code  for the issue.</param>
        /// <param name="id">Issue id.</param>
        /// <param name="message">The issue message.</param>
        /// <param name="severity">severity</param>
        /// <param name="source">Source location of the issue.</param>
        /// <param name="count">count</param>
        /// <param name="operationId">The operationId for which the model has
        /// issues.</param>
        /// <param name="apiVersion">The api version for which the model has
        /// issues.</param>
        /// <param name="origin">The source of the issue. Possible values
        /// include: 'Response', 'Request', 'Global'</param>
        /// <param name="title">Path to the spec object with issues.</param>
        /// <param name="description">The description associated with the
        /// object with issues.</param>
        /// <param name="docUrl">The url to the issue's documentation.</param>
        /// <param name="pathInModel">Path to the property with issues inside a
        /// model.</param>
        public TrafficValidationIssue(string code, string id, string message, int severity, IssueSourceLocation source, int count, string operationId, string apiVersion, IssueOrigin origin, IList<string> paramsProperty, string title, string description, string docUrl = default(string), object inner = default(object), string pathInModel = default(string))
        {
            Code = code;
            Id = id;
            Message = message;
            Severity = severity;
            Source = source;
            DocUrl = docUrl;
            Inner = inner;
            Count = count;
            OperationId = operationId;
            ApiVersion = apiVersion;
            Origin = origin;
            ParamsProperty = paramsProperty;
            Title = title;
            PathInModel = pathInModel;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the code  for the issue.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets issue id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the issue message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets severity
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public int Severity { get; set; }

        /// <summary>
        /// Gets or sets source location of the issue.
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public IssueSourceLocation Source { get; set; }

        /// <summary>
        /// Gets or sets the url to the issue's documentation.
        /// </summary>
        [JsonProperty(PropertyName = "docUrl")]
        public string DocUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "inner")]
        public object Inner { get; set; }

        /// <summary>
        /// Gets or sets count
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the operationId for which the model has issues.
        /// </summary>
        [JsonProperty(PropertyName = "operationId")]
        public string OperationId { get; set; }

        /// <summary>
        /// Gets or sets the api version for which the model has issues.
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or sets the source of the issue. Possible values include:
        /// 'Response', 'Request', 'Global'
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public IssueOrigin Origin { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "params")]
        public IList<string> ParamsProperty { get; set; }

        /// <summary>
        /// Gets or sets path to the spec object with issues.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets path to the property with issues inside a model.
        /// </summary>
        [JsonProperty(PropertyName = "pathInModel")]
        public string PathInModel { get; set; }

        /// <summary>
        /// Gets or sets the description associated with the object with
        /// issues.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Code == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Code");
            }
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (Message == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Message");
            }
            if (Source == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Source");
            }
            if (OperationId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OperationId");
            }
            if (ApiVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ApiVersion");
            }
            if (ParamsProperty == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ParamsProperty");
            }
            if (Title == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Title");
            }
            if (Description == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Description");
            }
        }
    }
}
