using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class OpportunityProduct : Entity_v4
	{

		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue Amount { get; set; }

		[DataMember(Name="Discount", EmitDefaultValue=false)]
		public DecimalValue Discount { get; set; }

		[DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
		public DecimalValue DiscountAmount { get; set; }

		[DataMember(Name="DiscountCode", EmitDefaultValue=false)]
		public StringValue DiscountCode { get; set; }

		[DataMember(Name="DiscountSequence", EmitDefaultValue=false)]
		public StringValue DiscountSequence { get; set; }

		[DataMember(Name="ExternalPrice", EmitDefaultValue=false)]
		public DecimalValue ExternalPrice { get; set; }

		[DataMember(Name="FreeItem", EmitDefaultValue=false)]
		public BooleanValue FreeItem { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="ManualDiscount", EmitDefaultValue=false)]
		public BooleanValue ManualDiscount { get; set; }

		[DataMember(Name="OpportunityProductID", EmitDefaultValue=false)]
		public IntValue OpportunityProductID { get; set; }

		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue ProjectTask { get; set; }

		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue Qty { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue TaxCategory { get; set; }

		[DataMember(Name="TransactionDescription", EmitDefaultValue=false)]
		public StringValue TransactionDescription { get; set; }

		[DataMember(Name="UnitPrice", EmitDefaultValue=false)]
		public DecimalValue UnitPrice { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

	}
}