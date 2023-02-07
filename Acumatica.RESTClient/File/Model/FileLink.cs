using System;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.File.Model
{
    /// <summary>
    /// FileLink
    /// </summary>
    [DataContract]
    public partial class FileLink
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileLink" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="filename">filename.</param>
        /// <param name="href">href.</param>
        public FileLink(Guid? id = default, string filename = default, string href = default)
        {
            Id = id;
            Filename = filename;
            Href = href;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets Filename
        /// </summary>
        [DataMember(Name = "filename", EmitDefaultValue = false)]
        public string Filename { get; set; }

        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name = "href", EmitDefaultValue = false)]
        public string Href { get; set; }
    }

}
