using System;
using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

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

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as FileLink);
        }

        /// <summary>
        /// Returns true if FileLink instances are equal
        /// </summary>
        /// <param name="input">Instance of FileLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileLink input)
        {
            if (input == null)
                return false;

            return
                (
                    Id == input.Id ||
                    Id != null &&
                    Id.Equals(input.Id)
                ) &&
                (
                    Filename == input.Filename ||
                    Filename != null &&
                    Filename.Equals(input.Filename)
                ) &&
                (
                    Href == input.Href ||
                    Href != null &&
                    Href.Equals(input.Href)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                if (Filename != null)
                    hashCode = hashCode * 59 + Filename.GetHashCode();
                if (Href != null)
                    hashCode = hashCode * 59 + Href.GetHashCode();
                return hashCode;
            }
        }
    }

}
