using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Acumatica.RESTClient.Client.OpenAPIDateConverter;

namespace Acumatica.RESTClient.Model
{
    /// <summary>
    /// Entity
    /// </summary>
    [DataContract]
    public abstract class Entity
    {
		#region Backward compatibility with SOAP
		[Obsolete("ReturnBehavior property is for backward compatibility with SOAP only. Please use $select and $expand parameters instead.")]
        public ReturnBehavior ReturnBehavior { get; set; }

        [Obsolete("CustomFields property is for backward compatibility with SOAP only. Please use Custom property instead.")]
        public CustomField[] CustomFields
        {
            get
            {
                List<CustomField> customFields = new List<CustomField>();
                foreach (var view in Custom)
                {
                    foreach (var field in view.Value)
                    {
                        field.Value.fieldName = field.Key;
                        field.Value.viewName = view.Key;
                        customFields.Add(field.Value);
                    }
                }
                return customFields.ToArray();
            }
            set
            {
                Custom.Clear();
                foreach (var field in value)
                {
                    if (!Custom.ContainsKey(field.viewName))
                    {
                        Custom.Add(field.viewName, new Dictionary<string, CustomField>());
                    }
                    Custom[field.viewName].Add(field.fieldName, field);
                }
            }
        }

		#endregion
		/// <summary>
		/// Indicates whether it is needed to delete detail record.
		/// </summary>
        [DataMember(Name = "delete", EmitDefaultValue = false)]
        public bool? Delete { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? ID { get; set; }

        /// <summary>
        /// Gets or Sets RowNumber
        /// </summary>
        [DataMember(Name="rowNumber", EmitDefaultValue=false)]
        public long? RowNumber { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public string Error { get; set; }

        /// <summary>
        /// Gets or Sets Custom
        /// </summary>
        [DataMember(Name="custom", EmitDefaultValue=false)]
        public Dictionary<string, Dictionary<string, CustomField>> Custom { get; set; }
       
        
        /// <summary>
        /// Gets or Sets Files
        /// </summary>
        [DataMember(Name="files", EmitDefaultValue=false)]
        public List<FileLink> Files { get; set; }

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
