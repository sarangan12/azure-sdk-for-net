// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Response to an ApplicationOperations.GetApplicationPackage request.
    /// </summary>
    public partial class GetApplicationPackageResult
    {
        /// <summary>
        /// Initializes a new instance of the GetApplicationPackageResult
        /// class.
        /// </summary>
        public GetApplicationPackageResult() { }

        /// <summary>
        /// Initializes a new instance of the GetApplicationPackageResult
        /// class.
        /// </summary>
        public GetApplicationPackageResult(string id = default(string), string version = default(string), PackageState? state = default(PackageState?), string format = default(string), string storageUrl = default(string), DateTime? storageUrlExpiry = default(DateTime?), DateTime? lastActivationTime = default(DateTime?))
        {
            Id = id;
            Version = version;
            State = state;
            Format = format;
            StorageUrl = storageUrl;
            StorageUrlExpiry = storageUrlExpiry;
            LastActivationTime = lastActivationTime;
        }

        /// <summary>
        /// Gets or sets the id of the application.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the version of the application package.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the current state of the application package.
        /// Possible values include: 'pending', 'active', 'unmapped'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public PackageState? State { get; set; }

        /// <summary>
        /// Gets or sets the format of the application package, if the package
        /// is active.
        /// </summary>
        [JsonProperty(PropertyName = "format")]
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets the storage URL at which the application package is
        /// stored.
        /// </summary>
        [JsonProperty(PropertyName = "storageUrl")]
        public string StorageUrl { get; set; }

        /// <summary>
        /// Gets or sets the UTC time at which the storage URL will expire.
        /// </summary>
        [JsonProperty(PropertyName = "storageUrlExpiry")]
        public DateTime? StorageUrlExpiry { get; set; }

        /// <summary>
        /// Gets or sets the time at which the package was last activated, if
        /// the package is active.
        /// </summary>
        [JsonProperty(PropertyName = "lastActivationTime")]
        public DateTime? LastActivationTime { get; set; }

    }
}
