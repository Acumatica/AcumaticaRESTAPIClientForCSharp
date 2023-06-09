using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class PurchasingDetail : Entity
	{

		[DataMember(Name="POOrderLineNbr", EmitDefaultValue=false)]
		public IntValue POOrderLineNbr { get; set; }

		[DataMember(Name="POOrderNbr", EmitDefaultValue=false)]
		public StringValue POOrderNbr { get; set; }

		[DataMember(Name="POOrderType", EmitDefaultValue=false)]
		public StringValue POOrderType { get; set; }

		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue Selected { get; set; }

	}
}