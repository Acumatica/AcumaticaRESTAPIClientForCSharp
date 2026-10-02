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
        /// <param name="features">features.</param>
        public VersionAndEndpoints(Version? version = default, List<Endpoint>? endpoints = default, List<string>? features = default)
        {
            Version = version;
            Endpoints = endpoints;
            Features = features;
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

        /// <summary>
        /// The fully-qualified names of the <c>PX.Objects.CS.FeaturesSet</c> nested types enabled on this instance,
        /// e.g. <c>PX.Objects.CS.FeaturesSet+Manufacturing</c>. Present starting with 26R2.
        /// </summary>
        [DataMember(Name = "features", EmitDefaultValue = false)]
        public List<string>? Features { get; set; }
    }
}
