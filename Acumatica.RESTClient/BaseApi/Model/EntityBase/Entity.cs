using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Acumatica.RESTClient.FileApi.Model;
using Newtonsoft.Json;

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
                if (Custom != null)
                {
                    foreach (var view in Custom)
                    {
                        foreach (var field in view.Value)
                        {
                            field.Value.fieldName = field.Key;
                            field.Value.viewName = view.Key;
                            customFields.Add(field.Value);
                        }
                    }
                }
                return customFields.ToArray();
            }
            set
            {
                Custom = new Dictionary<string, Dictionary<string, CustomField>>();
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
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public string Error { get; set; }

        /// <summary>
        /// Dictionary containing ViewName as a key. 
        /// The value in the Dictionary is another Dictionary that contains 
        /// FieldName as Key.
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
