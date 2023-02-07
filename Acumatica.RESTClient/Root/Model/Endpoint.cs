using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace Acumatica.RESTClient.Root.Model
{
    /// <summary>
    /// Endpoint
    /// </summary>
    [DataContract]
    public partial class Endpoint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Endpoint" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="version">version.</param>
        /// <param name="href">href.</param>
        public Endpoint(string name = default, string version = default, string href = default)
        {
            Name = name;
            Version = version;
            Href = href;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name = "href", EmitDefaultValue = false)]
        public string Href { get; set; }
    }

}
