using System;
using System.Text;

namespace Acumatica.RESTClient.FileApi.Model
{
    /// <summary>
    /// FileLink
    /// </summary>
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
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets Filename
        /// </summary>
        public string? Filename { get; set; }

        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        public string? Href { get; set; }

        /// <summary>
        /// The field is available starting from Acumatica 2024r2 
        /// </summary>
        public string? Comment { get; set; }

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
