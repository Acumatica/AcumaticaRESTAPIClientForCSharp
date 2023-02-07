using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.Root.Model
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
        public VersionAndEndpoints(Version version = default, List<Endpoint> endpoints = default)
        {
            Version = version;
            Endpoints = endpoints;
        }

        /// <summary>
        /// Current Acumatica ERP version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public Version Version { get; set; }

        /// <summary>
        /// List of available Endpoints
        /// </summary>
        [DataMember(Name = "endpoints", EmitDefaultValue = false)]
        public List<Endpoint> Endpoints { get; set; }
    }

}
