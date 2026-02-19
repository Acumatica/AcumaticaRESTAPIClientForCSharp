using Acumatica.RESTClient.Auxiliary;
using Acumatica.RESTClient.ContractBasedApi.FileApi.Model;
using Acumatica.RESTClient.FileApi.Model;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    /// <summary>
    /// Entity
    /// </summary>
    public abstract class Entity
    {
		/// <summary>
		/// Indicates whether it is needed to delete detail record.
		/// </summary>
        public bool? Delete { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        public Guid? ID { get; set; }

        /// <summary>
        /// Gets or Sets RowNumber
        /// </summary>
        public long? RowNumber { get; set; }


        /// <summary>
        /// Gets or Sets Error
        /// </summary>
		[JsonIgnoreOnSerialize]
        public string? Error { get; set; }

        /// <summary>
        /// Dictionary containing ViewName as a key. 
        /// The value in the Dictionary is another Dictionary that contains 
        /// FieldName as Key.
        /// </summary>
        public Dictionary<string, Dictionary<string, CustomField>>? Custom { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        public StringValue? Note { get; set; }


        /// <summary>
        /// Gets or Sets Files
        /// </summary>
		[JsonIgnoreOnSerialize]
        public List<FileLink>? Files { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("_links")]
		[JsonIgnoreOnSerialize]
		public Links? Links { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
        {
           return ToJson().ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
