using System;
using System.Runtime.Serialization;
using System.Text;

namespace Acumatica.RESTClient.FileApi.Model
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
        public FileLink(Guid? id = default, string? filename = default, string? href = default)
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
        public string? Filename { get; set; }

        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name = "href", EmitDefaultValue = false)]
        public string? Href { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileLink {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
