using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class SalesInvoiceTotals : Entity_v3
	{

		[DataMember(Name="DiscountTotal", EmitDefaultValue=false)]
		public DecimalValue DiscountTotal { get; set; }

		[DataMember(Name="Freight", EmitDefaultValue=false)]
		public DecimalValue Freight { get; set; }

		[DataMember(Name="LineTotal", EmitDefaultValue=false)]
		public DecimalValue LineTotal { get; set; }

		[DataMember(Name="MiscTotal", EmitDefaultValue=false)]
		public DecimalValue MiscTotal { get; set; }

		[DataMember(Name="PaymentTotal", EmitDefaultValue=false)]
		public DecimalValue PaymentTotal { get; set; }

		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue TaxTotal { get; set; }

	}
}