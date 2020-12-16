using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class SalesInvoiceFreightDetail : Entity_v4
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="FreightAmount", EmitDefaultValue=false)]
		public DecimalValue FreightAmount { get; set; }

		[DataMember(Name="FreightCost", EmitDefaultValue=false)]
		public DecimalValue FreightCost { get; set; }

		[DataMember(Name="LineTotal", EmitDefaultValue=false)]
		public DecimalValue LineTotal { get; set; }

		[DataMember(Name="PremiumFreightAmount", EmitDefaultValue=false)]
		public DecimalValue PremiumFreightAmount { get; set; }

		[DataMember(Name="ShipmentNbr", EmitDefaultValue=false)]
		public StringValue ShipmentNbr { get; set; }

		[DataMember(Name="ShipmentType", EmitDefaultValue=false)]
		public StringValue ShipmentType { get; set; }

		[DataMember(Name="TotalFreightAmount", EmitDefaultValue=false)]
		public DecimalValue TotalFreightAmount { get; set; }

		[DataMember(Name="Volume", EmitDefaultValue=false)]
		public DecimalValue Volume { get; set; }

		[DataMember(Name="Weight", EmitDefaultValue=false)]
		public DecimalValue Weight { get; set; }

	}
}