using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class Totals : Entity
	{

		[DataMember(Name="DiscountTotal", EmitDefaultValue=false)]
		public DecimalValue DiscountTotal { get; set; }

		[DataMember(Name="Freight", EmitDefaultValue=false)]
		public DecimalValue Freight { get; set; }

		[DataMember(Name="FreightCost", EmitDefaultValue=false)]
		public DecimalValue FreightCost { get; set; }

		[DataMember(Name="FreightCostIsuptodate", EmitDefaultValue=false)]
		public BooleanValue FreightCostIsuptodate { get; set; }

		[DataMember(Name="FreightTaxCategory", EmitDefaultValue=false)]
		public StringValue FreightTaxCategory { get; set; }

		[DataMember(Name="LineTotalAmount", EmitDefaultValue=false)]
		public DecimalValue LineTotalAmount { get; set; }

		[DataMember(Name="MiscTotalAmount", EmitDefaultValue=false)]
		public DecimalValue MiscTotalAmount { get; set; }

		[DataMember(Name="OrderVolume", EmitDefaultValue=false)]
		public DecimalValue OrderVolume { get; set; }

		[DataMember(Name="OrderWeight", EmitDefaultValue=false)]
		public DecimalValue OrderWeight { get; set; }

		[DataMember(Name="PackageWeight", EmitDefaultValue=false)]
		public DecimalValue PackageWeight { get; set; }

		[DataMember(Name="PremiumFreight", EmitDefaultValue=false)]
		public DecimalValue PremiumFreight { get; set; }

		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue TaxTotal { get; set; }

		[DataMember(Name="UnbilledAmount", EmitDefaultValue=false)]
		public DecimalValue UnbilledAmount { get; set; }

		[DataMember(Name="UnbilledQty", EmitDefaultValue=false)]
		public DecimalValue UnbilledQty { get; set; }

		[DataMember(Name="UnpaidBalance", EmitDefaultValue=false)]
		public DecimalValue UnpaidBalance { get; set; }

	}
}