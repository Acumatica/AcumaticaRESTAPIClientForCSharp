using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class ShippingTermDetail : Entity
	{

		[DataMember(Name="BreakAmount", EmitDefaultValue=false)]
		public DecimalValue BreakAmount { get; set; }

		[DataMember(Name="FreightCost", EmitDefaultValue=false)]
		public DecimalValue FreightCost { get; set; }

		[DataMember(Name="InvoiceAmount", EmitDefaultValue=false)]
		public DecimalValue InvoiceAmount { get; set; }

		[DataMember(Name="LineHandling", EmitDefaultValue=false)]
		public DecimalValue LineHandling { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="ShippingandHandling", EmitDefaultValue=false)]
		public DecimalValue ShippingandHandling { get; set; }

	}
}