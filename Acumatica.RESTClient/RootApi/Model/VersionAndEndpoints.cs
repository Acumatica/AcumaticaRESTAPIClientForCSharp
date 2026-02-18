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
        public VersionAndEndpoints(Version? version = default, List<Endpoint>? endpoints = default)
        {
            Version = version;
            Endpoints = endpoints;
        }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        public Version? Version { get; set; }

        /// <summary>
        /// Gets or Sets Endpoints
        /// </summary>
        public List<Endpoint>? Endpoints { get; set; }
    }
}
