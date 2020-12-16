using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class SrvOrdDetails : Entity_v4
	{

		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue Account { get; set; }

		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue Amount { get; set; }

		[DataMember(Name="AppointmentAmount", EmitDefaultValue=false)]
		public DecimalValue AppointmentAmount { get; set; }

		[DataMember(Name="AppointmentCount", EmitDefaultValue=false)]
		public IntValue AppointmentCount { get; set; }

		[DataMember(Name="AppointmentDuration", EmitDefaultValue=false)]
		public StringValue AppointmentDuration { get; set; }

		[DataMember(Name="AppointmentEstimatedDuration", EmitDefaultValue=false)]
		public StringValue AppointmentEstimatedDuration { get; set; }

		[DataMember(Name="AppointmentQty", EmitDefaultValue=false)]
		public DecimalValue AppointmentQty { get; set; }

		[DataMember(Name="Billable", EmitDefaultValue=false)]
		public BooleanValue Billable { get; set; }

		[DataMember(Name="BillingRule", EmitDefaultValue=false)]
		public StringValue BillingRule { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue Branch { get; set; }

		[DataMember(Name="ComponentID", EmitDefaultValue=false)]
		public StringValue ComponentID { get; set; }

		[DataMember(Name="ComponentLineRef", EmitDefaultValue=false)]
		public StringValue ComponentLineRef { get; set; }

		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue CostCode { get; set; }

		[DataMember(Name="CoveredQty", EmitDefaultValue=false)]
		public DecimalValue CoveredQty { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
		public DecimalValue DiscountAmount { get; set; }

		[DataMember(Name="DiscountPercent", EmitDefaultValue=false)]
		public DecimalValue DiscountPercent { get; set; }

		[DataMember(Name="EquipmentAction", EmitDefaultValue=false)]
		public StringValue EquipmentAction { get; set; }

		[DataMember(Name="EquipmentActionComment", EmitDefaultValue=false)]
		public StringValue EquipmentActionComment { get; set; }

		[DataMember(Name="EstimatedAmount", EmitDefaultValue=false)]
		public DecimalValue EstimatedAmount { get; set; }

		[DataMember(Name="EstimatedDuration", EmitDefaultValue=false)]
		public StringValue EstimatedDuration { get; set; }

		[DataMember(Name="EstimatedQty", EmitDefaultValue=false)]
		public DecimalValue EstimatedQty { get; set; }

		[DataMember(Name="ExtPrice", EmitDefaultValue=false)]
		public DecimalValue ExtPrice { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="LastReference", EmitDefaultValue=false)]
		public StringValue LastReference { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="LineRef", EmitDefaultValue=false)]
		public StringValue LineRef { get; set; }

		[DataMember(Name="LineStatus", EmitDefaultValue=false)]
		public StringValue LineStatus { get; set; }

		[DataMember(Name="LineType", EmitDefaultValue=false)]
		public StringValue LineType { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue Location { get; set; }

		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue LotSerialNbr { get; set; }

		[DataMember(Name="ManualPrice", EmitDefaultValue=false)]
		public BooleanValue ManualPrice { get; set; }

		[DataMember(Name="MarkforPO", EmitDefaultValue=false)]
		public BooleanValue MarkforPO { get; set; }

		[DataMember(Name="ModelEquipmentLineRef", EmitDefaultValue=false)]
		public StringValue ModelEquipmentLineRef { get; set; }

		[DataMember(Name="OverageQty", EmitDefaultValue=false)]
		public DecimalValue OverageQty { get; set; }

		[DataMember(Name="OverageUnitPrice", EmitDefaultValue=false)]
		public DecimalValue OverageUnitPrice { get; set; }

		[DataMember(Name="POCompleted", EmitDefaultValue=false)]
		public BooleanValue POCompleted { get; set; }

		[DataMember(Name="PONbr", EmitDefaultValue=false)]
		public StringValue PONbr { get; set; }

		[DataMember(Name="POStatus", EmitDefaultValue=false)]
		public StringValue POStatus { get; set; }

		[DataMember(Name="PrepaidItem", EmitDefaultValue=false)]
		public BooleanValue PrepaidItem { get; set; }

		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue ProjectTask { get; set; }

		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue Qty { get; set; }

		[DataMember(Name="ServiceContractItem", EmitDefaultValue=false)]
		public BooleanValue ServiceContractItem { get; set; }

		[DataMember(Name="ServiceOrderNbr", EmitDefaultValue=false)]
		public StringValue ServiceOrderNbr { get; set; }

		[DataMember(Name="ServiceOrderType", EmitDefaultValue=false)]
		public StringValue ServiceOrderType { get; set; }

		[DataMember(Name="SortOrder", EmitDefaultValue=false)]
		public IntValue SortOrder { get; set; }

		[DataMember(Name="StaffMemberID", EmitDefaultValue=false)]
		public StringValue StaffMemberID { get; set; }

		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue Subaccount { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="TargetEquipmentID", EmitDefaultValue=false)]
		public StringValue TargetEquipmentID { get; set; }

		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue TaxCategory { get; set; }

		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue UnitCost { get; set; }

		[DataMember(Name="UnitPrice", EmitDefaultValue=false)]
		public DecimalValue UnitPrice { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

		[DataMember(Name="VendorID", EmitDefaultValue=false)]
		public StringValue VendorID { get; set; }

		[DataMember(Name="VendorLocationID", EmitDefaultValue=false)]
		public StringValue VendorLocationID { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

		[DataMember(Name="Warranty", EmitDefaultValue=false)]
		public BooleanValue Warranty { get; set; }

	}
}