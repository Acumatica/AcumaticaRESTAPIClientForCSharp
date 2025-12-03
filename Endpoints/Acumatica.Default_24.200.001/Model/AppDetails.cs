using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class AppDetails : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: AcctID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTranAmt</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Actual Amount</para>
		/// </summary>
		[DataMember(Name="ActualAmount", EmitDefaultValue=false)]
		public DecimalValue? ActualAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Actual Duration</para>
		/// </summary>
		[DataMember(Name="ActualDuration", EmitDefaultValue=false)]
		public StringValue? ActualDuration { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Qty</para>
		/// <para>DAC: PX.Objects.FS.FSApptLineSplit</para>
		/// <para>Display Name: Quantity</para>
		/// </summary>
		[DataMember(Name="ActualQty", EmitDefaultValue=false)]
		public DecimalValue? ActualQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Appointment Nbr.</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="AppointmentNbr", EmitDefaultValue=false)]
		public StringValue? AppointmentNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsBillable</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// </summary>
		[DataMember(Name="Billable", EmitDefaultValue=false)]
		public BooleanValue? Billable { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryBillableTranAmt</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Billable Amount</para>
		/// </summary>
		[DataMember(Name="BillableAmount", EmitDefaultValue=false)]
		public DecimalValue? BillableAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Billable Quantity</para>
		/// </summary>
		[DataMember(Name="BillableQty", EmitDefaultValue=false)]
		public DecimalValue? BillableQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Billing Rule</para>
		/// <para>SQL Type: char(4)</para>
		/// </summary>
		[DataMember(Name="BillingRule", EmitDefaultValue=false)]
		public StringValue? BillingRule { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Component ID</para>
		/// </summary>
		[DataMember(Name="ComponentID", EmitDefaultValue=false)]
		public StringValue? ComponentID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EquipmentLineRef</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Component Ref. Nbr.</para>
		/// </summary>
		[DataMember(Name="ComponentLineRef", EmitDefaultValue=false)]
		public StringValue? ComponentLineRef { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Covered Quantity</para>
		/// </summary>
		[DataMember(Name="CoveredQty", EmitDefaultValue=false)]
		public DecimalValue? CoveredQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Unit Cost</para>
		/// </summary>
		[DataMember(Name="CuryUnitCost", EmitDefaultValue=false)]
		public DecimalValue? CuryUnitCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryDiscAmt</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Discount Amount</para>
		/// </summary>
		[DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
		public DecimalValue? DiscountAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DiscPct</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Discount Percent</para>
		/// </summary>
		[DataMember(Name="DiscountPercent", EmitDefaultValue=false)]
		public DecimalValue? DiscountPercent { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Equipment Action</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="EquipmentAction", EmitDefaultValue=false)]
		public StringValue? EquipmentAction { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Comment</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Equipment Action Comment</para>
		/// <para>SQL Type: varchar(255)</para>
		/// </summary>
		[DataMember(Name="EquipmentActionComment", EmitDefaultValue=false)]
		public StringValue? EquipmentActionComment { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryEstimatedTranAmt</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Estimated Amount</para>
		/// </summary>
		[DataMember(Name="EstimatedAmount", EmitDefaultValue=false)]
		public DecimalValue? EstimatedAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Estimated Duration</para>
		/// </summary>
		[DataMember(Name="EstimatedDuration", EmitDefaultValue=false)]
		public StringValue? EstimatedDuration { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Estimated Quantity</para>
		/// </summary>
		[DataMember(Name="EstimatedQty", EmitDefaultValue=false)]
		public DecimalValue? EstimatedQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryBillableExtPrice</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Ext. Price</para>
		/// </summary>
		[DataMember(Name="ExtPrice", EmitDefaultValue=false)]
		public DecimalValue? ExtPrice { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Ref. Nbr.</para>
		/// <para>SQL Type: char(4)</para>
		/// </summary>
		[DataMember(Name="LineRef", EmitDefaultValue=false)]
		public StringValue? LineRef { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UIStatus</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Line Status</para>
		/// <para>SQL Type: nchar(2)</para>
		/// </summary>
		[DataMember(Name="LineStatus", EmitDefaultValue=false)]
		public StringValue? LineStatus { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Line Type</para>
		/// <para>SQL Type: char(5)</para>
		/// </summary>
		[DataMember(Name="LineType", EmitDefaultValue=false)]
		public StringValue? LineType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteLocationID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Lot/Serial Nbr.</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Manual Price</para>
		/// </summary>
		[DataMember(Name="ManualPrice", EmitDefaultValue=false)]
		public BooleanValue? ManualPrice { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EnablePO</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Mark for PO</para>
		/// </summary>
		[DataMember(Name="MarkforPO", EmitDefaultValue=false)]
		public BooleanValue? MarkforPO { get; set; }

		/// <summary>
		/// <para>DAC Field Name: NewTargetEquipmentLineNbr</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Model Equipment Ref. Nbr.</para>
		/// <para>SQL Type: char(4)</para>
		/// </summary>
		[DataMember(Name="ModelEquipmentLineRef", EmitDefaultValue=false)]
		public StringValue? ModelEquipmentLineRef { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExtraUsageQty</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Overage Quantity</para>
		/// </summary>
		[DataMember(Name="OverageQty", EmitDefaultValue=false)]
		public DecimalValue? OverageQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryExtraUsageUnitPrice</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Overage Unit Price</para>
		/// </summary>
		[DataMember(Name="OverageUnitPrice", EmitDefaultValue=false)]
		public DecimalValue? OverageUnitPrice { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ServiceType</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Pickup/Delivery Action</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="PickupDeliveryAction", EmitDefaultValue=false)]
		public StringValue? PickupDeliveryAction { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PickupDeliveryAppLineRef</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Pickup/Delivery Ref. Nbr.</para>
		/// <para>SQL Type: char(4)</para>
		/// </summary>
		[DataMember(Name="PickupDeliveryLineRef", EmitDefaultValue=false)]
		public StringValue? PickupDeliveryLineRef { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Pickup/Delivery Service ID</para>
		/// </summary>
		[DataMember(Name="PickupDeliveryServiceID", EmitDefaultValue=false)]
		public StringValue? PickupDeliveryServiceID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: PO Completed</para>
		/// </summary>
		[DataMember(Name="POCompleted", EmitDefaultValue=false)]
		public BooleanValue? POCompleted { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: PO Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="PONbr", EmitDefaultValue=false)]
		public StringValue? PONbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: PO Status</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="POStatus", EmitDefaultValue=false)]
		public StringValue? POStatus { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsPrepaid</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Prepaid Item</para>
		/// </summary>
		[DataMember(Name="PrepaidItem", EmitDefaultValue=false)]
		public BooleanValue? PrepaidItem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProjectTaskID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Project Task</para>
		/// </summary>
		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LinkedDisplayRefNbr</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Related Doc. Nbr.</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="RelatedDocNbr", EmitDefaultValue=false)]
		public StringValue? RelatedDocNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ContractRelated</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Service Contract Item</para>
		/// </summary>
		[DataMember(Name="ServiceContractItem", EmitDefaultValue=false)]
		public BooleanValue? ServiceContractItem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SODetID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Service Order Detail Ref. Nbr.</para>
		/// </summary>
		[DataMember(Name="ServiceOrderLineRef", EmitDefaultValue=false)]
		public StringValue? ServiceOrderLineRef { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SrvOrdType</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Service Order Type</para>
		/// <para>SQL Type: char(4)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ServiceOrderType", EmitDefaultValue=false)]
		public StringValue? ServiceOrderType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Sort Order</para>
		/// </summary>
		[DataMember(Name="SortOrder", EmitDefaultValue=false)]
		public IntValue? SortOrder { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StaffID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Staff Member ID</para>
		/// </summary>
		[DataMember(Name="StaffMemberID", EmitDefaultValue=false)]
		public StringValue? StaffMemberID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// </summary>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SMEquipmentID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Target Equipment ID</para>
		/// </summary>
		[DataMember(Name="TargetEquipmentID", EmitDefaultValue=false)]
		public StringValue? TargetEquipmentID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxCategoryID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Tax Category</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryUnitPrice</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Unit Price</para>
		/// </summary>
		[DataMember(Name="UnitPrice", EmitDefaultValue=false)]
		public DecimalValue? UnitPrice { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// </summary>
		[DataMember(Name="Warranty", EmitDefaultValue=false)]
		public BooleanValue? Warranty { get; set; }

	}
}