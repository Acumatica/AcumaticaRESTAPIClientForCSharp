using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ShipVia : Entity_v4
	{

		[DataMember(Name="CalculationMethod", EmitDefaultValue=false)]
		public StringValue CalculationMethod { get; set; }

		[DataMember(Name="Calendar", EmitDefaultValue=false)]
		public StringValue Calendar { get; set; }

		[DataMember(Name="CarrierID", EmitDefaultValue=false)]
		public StringValue CarrierID { get; set; }

		[DataMember(Name="CommonCarrier", EmitDefaultValue=false)]
		public BooleanValue CommonCarrier { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="FreightExpenseAccount", EmitDefaultValue=false)]
		public StringValue FreightExpenseAccount { get; set; }

		[DataMember(Name="FreightExpenseSubaccount", EmitDefaultValue=false)]
		public StringValue FreightExpenseSubaccount { get; set; }

		[DataMember(Name="FreightRates", EmitDefaultValue=false)]
		public List<ShipViaFreightRate> FreightRates { get; set; }

		[DataMember(Name="FreightSalesAccount", EmitDefaultValue=false)]
		public StringValue FreightSalesAccount { get; set; }

		[DataMember(Name="FreightSalesSubaccount", EmitDefaultValue=false)]
		public StringValue FreightSalesSubaccount { get; set; }

		[DataMember(Name="Packages", EmitDefaultValue=false)]
		public List<ShippingBox> Packages { get; set; }

		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue TaxCategory { get; set; }

	}
}