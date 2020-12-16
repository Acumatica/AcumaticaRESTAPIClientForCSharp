using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class AppProfitability : Entity_v4
	{

		[DataMember(Name="ActualAmount", EmitDefaultValue=false)]
		public DecimalValue ActualAmount { get; set; }

		[DataMember(Name="ActualDuration", EmitDefaultValue=false)]
		public StringValue ActualDuration { get; set; }

		[DataMember(Name="ActualQuantity", EmitDefaultValue=false)]
		public DecimalValue ActualQuantity { get; set; }

		[DataMember(Name="BillableAmount", EmitDefaultValue=false)]
		public DecimalValue BillableAmount { get; set; }

		[DataMember(Name="BillableQuantity", EmitDefaultValue=false)]
		public DecimalValue BillableQuantity { get; set; }

		[DataMember(Name="ExtCost", EmitDefaultValue=false)]
		public DecimalValue ExtCost { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="EstimatedAmount", EmitDefaultValue=false)]
		public DecimalValue EstimatedAmount { get; set; }

		[DataMember(Name="EstimatedQty", EmitDefaultValue=false)]
		public DecimalValue EstimatedQty { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="LineRef", EmitDefaultValue=false)]
		public StringValue LineRef { get; set; }

		[DataMember(Name="LineType", EmitDefaultValue=false)]
		public StringValue LineType { get; set; }

		[DataMember(Name="Profit", EmitDefaultValue=false)]
		public DecimalValue Profit { get; set; }

		[DataMember(Name="ProfitPercent", EmitDefaultValue=false)]
		public DecimalValue ProfitPercent { get; set; }

		[DataMember(Name="StaffMember", EmitDefaultValue=false)]
		public StringValue StaffMember { get; set; }

		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue UnitCost { get; set; }

		[DataMember(Name="UnitPrice", EmitDefaultValue=false)]
		public DecimalValue UnitPrice { get; set; }

	}
}