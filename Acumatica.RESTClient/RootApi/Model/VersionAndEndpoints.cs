using System.Collections.Generic;

namespace Acumatica.RESTClient.RootApi.Model
{
	/// <summary>
	/// VersionAndEndpoints
	/// </summary>
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
        public Version? Version { get; set; }

        /// <summary>
        /// Gets or Sets Endpoints
        /// </summary>
        public List<Endpoint>? Endpoints { get; set; }

        /// <summary>
        /// The fully-qualified names of the <c>PX.Objects.CS.FeaturesSet</c> nested types enabled on this instance,
        /// e.g. <c>PX.Objects.CS.FeaturesSet+Manufacturing</c>. Present starting with 26R2.
        /// </summary>
        public List<string>? Features { get; set; }
    }
}
