using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class AttributeDefinitionValue : Entity
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Disabled", EmitDefaultValue=false)]
		public BooleanValue Disabled { get; set; }

		[DataMember(Name="SortOrder", EmitDefaultValue=false)]
		public ShortValue SortOrder { get; set; }

		[DataMember(Name="ValueID", EmitDefaultValue=false)]
		public StringValue ValueID { get; set; }

	}
}