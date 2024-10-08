using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ShippingTermDetail : Entity
	{

		[DataMember(Name="BreakAmount", EmitDefaultValue=false)]
		public DecimalValue? BreakAmount { get; set; }

		[DataMember(Name="FreightCost", EmitDefaultValue=false)]
		public DecimalValue? FreightCost { get; set; }

		[DataMember(Name="InvoiceAmount", EmitDefaultValue=false)]
		public DecimalValue? InvoiceAmount { get; set; }

		[DataMember(Name="LineHandling", EmitDefaultValue=false)]
		public DecimalValue? LineHandling { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="ShippingandHandling", EmitDefaultValue=false)]
		public DecimalValue? ShippingandHandling { get; set; }

	}
}