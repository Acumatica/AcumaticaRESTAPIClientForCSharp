using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.RootApi.Model
{
	/// <summary>
	/// VersionAndEndpoints
	/// </summary>
	[DataContract]
    public partial class VersionAndEndpoints
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VersionAndEndpoints" /> class.
        /// </summary>
        /// <param name="version">version.</param>
        /// <param name="endpoints">endpoints.</param>
        public VersionAndEndpoints(Version? version = default, List<Endpoint>? endpoints = default)
        {
            Version = version;
            Endpoints = endpoints;
        }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public Version? Version { get; set; }

        /// <summary>
        /// Gets or Sets Endpoints
        /// </summary>
        [DataMember(Name = "endpoints", EmitDefaultValue = false)]
        public List<Endpoint>? Endpoints { get; set; }
    }
}
