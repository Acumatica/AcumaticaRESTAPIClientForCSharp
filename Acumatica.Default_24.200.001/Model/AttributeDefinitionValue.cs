using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class AttributeDefinitionValue : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.CS.CSAttribute 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.CSAttributeDetail 
		/// </summary>
		[DataMember(Name="Disabled", EmitDefaultValue=false)]
		public BooleanValue? Disabled { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.CSAttributeDetail 
		/// Display Name: Sort Order 
		/// </summary>
		[DataMember(Name="SortOrder", EmitDefaultValue=false)]
		public ShortValue? SortOrder { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.CSAttributeDetail 
		/// Display Name: Value ID 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ValueID", EmitDefaultValue=false)]
		public StringValue? ValueID { get; set; }

	}
}