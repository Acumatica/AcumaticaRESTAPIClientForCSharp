using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	[DataContract]
	public class SalesInvoiceFreightDetail : Entity
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="FreightAmount", EmitDefaultValue=false)]
		public DecimalValue? FreightAmount { get; set; }

		[DataMember(Name="FreightCost", EmitDefaultValue=false)]
		public DecimalValue? FreightCost { get; set; }

		[DataMember(Name="LineTotal", EmitDefaultValue=false)]
		public DecimalValue? LineTotal { get; set; }

		[DataMember(Name="PremiumFreightAmount", EmitDefaultValue=false)]
		public DecimalValue? PremiumFreightAmount { get; set; }

		[DataMember(Name="ShipmentNbr", EmitDefaultValue=false)]
		public StringValue? ShipmentNbr { get; set; }

		[DataMember(Name="ShipmentType", EmitDefaultValue=false)]
		public StringValue? ShipmentType { get; set; }

		[DataMember(Name="TotalFreightAmount", EmitDefaultValue=false)]
		public DecimalValue? TotalFreightAmount { get; set; }

		[DataMember(Name="Volume", EmitDefaultValue=false)]
		public DecimalValue? Volume { get; set; }

		[DataMember(Name="Weight", EmitDefaultValue=false)]
		public DecimalValue? Weight { get; set; }

	}
}