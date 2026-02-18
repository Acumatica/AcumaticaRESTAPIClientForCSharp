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
                            field.Value.FieldName = field.Key;
                            field.Value.ViewName = view.Key;
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
                    if (!Custom.ContainsKey(field.ViewName))
                    {
                        Custom.Add(field.ViewName, new Dictionary<string, CustomField>());
                    }
                    Custom[field.ViewName].Add(field.FieldName, field);
                }
            }
        }

		#endregion
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
        public List<FileLink>? Files { get; set; }
		public bool ShouldSerializeFiles() => false;

		/// <summary>
		/// 
		/// </summary>
        public Links Links { get; set; }

		public bool ShouldSerializeLinks() => false;

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
