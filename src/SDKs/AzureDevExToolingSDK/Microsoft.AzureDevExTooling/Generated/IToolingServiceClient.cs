// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Tooling
{
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Client that can be used to access Azure DevEx Tooling services to run
    /// linter, static and api validations.
    /// </summary>
    public partial interface IToolingServiceClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }


        /// <summary>
        /// Gets the ITools.
        /// </summary>
        ITools Tools { get; }

    }
}
