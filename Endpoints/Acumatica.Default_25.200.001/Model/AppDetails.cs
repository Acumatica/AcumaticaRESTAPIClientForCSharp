using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class AppDetails : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: AcctID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// </summary>
		public StringValue? Account { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTranAmt</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Actual Amount</para>
		/// </summary>
		public DecimalValue? ActualAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Actual Duration</para>
		/// </summary>
		public StringValue? ActualDuration { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Qty</para>
		/// <para>DAC: PX.Objects.FS.FSApptLineSplit</para>
		/// <para>Display Name: Quantity</para>
		/// </summary>
		public DecimalValue? ActualQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Appointment Nbr.</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// Key Field
		/// </summary>
		public StringValue? AppointmentNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsBillable</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// </summary>
		public BooleanValue? Billable { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryBillableTranAmt</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Billable Amount</para>
		/// </summary>
		public DecimalValue? BillableAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Billable Quantity</para>
		/// </summary>
		public DecimalValue? BillableQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Billing Rule</para>
		/// <para>SQL Type: char(4)</para>
		/// </summary>
		public StringValue? BillingRule { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// </summary>
		public StringValue? Branch { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Component ID</para>
		/// </summary>
		public StringValue? ComponentID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EquipmentLineRef</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Component Ref. Nbr.</para>
		/// </summary>
		public StringValue? ComponentLineRef { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Covered Quantity</para>
		/// </summary>
		public DecimalValue? CoveredQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Unit Cost</para>
		/// </summary>
		public DecimalValue? CuryUnitCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryDiscAmt</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Discount Amount</para>
		/// </summary>
		public DecimalValue? DiscountAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DiscPct</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Discount Percent</para>
		/// </summary>
		public DecimalValue? DiscountPercent { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Equipment Action</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? EquipmentAction { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Comment</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Equipment Action Comment</para>
		/// <para>SQL Type: varchar(255)</para>
		/// </summary>
		public StringValue? EquipmentActionComment { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryEstimatedTranAmt</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Estimated Amount</para>
		/// </summary>
		public DecimalValue? EstimatedAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Estimated Duration</para>
		/// </summary>
		public StringValue? EstimatedDuration { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Estimated Quantity</para>
		/// </summary>
		public DecimalValue? EstimatedQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryBillableExtPrice</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Ext. Price</para>
		/// </summary>
		public DecimalValue? ExtPrice { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Ref. Nbr.</para>
		/// <para>SQL Type: char(4)</para>
		/// </summary>
		public StringValue? LineRef { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UIStatus</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Line Status</para>
		/// <para>SQL Type: nchar(2)</para>
		/// </summary>
		public StringValue? LineStatus { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Line Type</para>
		/// <para>SQL Type: char(5)</para>
		/// </summary>
		public StringValue? LineType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteLocationID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// </summary>
		public StringValue? Location { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Lot/Serial Nbr.</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Manual Price</para>
		/// </summary>
		public BooleanValue? ManualPrice { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EnablePO</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Mark for PO</para>
		/// </summary>
		public BooleanValue? MarkforPO { get; set; }

		/// <summary>
		/// <para>DAC Field Name: NewTargetEquipmentLineNbr</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Model Equipment Ref. Nbr.</para>
		/// <para>SQL Type: char(4)</para>
		/// </summary>
		public StringValue? ModelEquipmentLineRef { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExtraUsageQty</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Overage Quantity</para>
		/// </summary>
		public DecimalValue? OverageQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryExtraUsageUnitPrice</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Overage Unit Price</para>
		/// </summary>
		public DecimalValue? OverageUnitPrice { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ServiceType</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Pickup/Delivery Action</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? PickupDeliveryAction { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PickupDeliveryAppLineRef</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Pickup/Delivery Ref. Nbr.</para>
		/// <para>SQL Type: char(4)</para>
		/// </summary>
		public StringValue? PickupDeliveryLineRef { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Pickup/Delivery Service ID</para>
		/// </summary>
		public StringValue? PickupDeliveryServiceID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: PO Completed</para>
		/// </summary>
		public BooleanValue? POCompleted { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: PO Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? PONbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: PO Status</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? POStatus { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsPrepaid</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Prepaid Item</para>
		/// </summary>
		public BooleanValue? PrepaidItem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProjectTaskID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Project Task</para>
		/// </summary>
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LinkedDisplayRefNbr</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Related Doc. Nbr.</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? RelatedDocNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ContractRelated</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Service Contract Item</para>
		/// </summary>
		public BooleanValue? ServiceContractItem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SODetID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Service Order Detail Ref. Nbr.</para>
		/// </summary>
		public StringValue? ServiceOrderLineRef { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SrvOrdType</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Service Order Type</para>
		/// <para>SQL Type: char(4)</para>
		/// Key Field
		/// </summary>
		public StringValue? ServiceOrderType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Sort Order</para>
		/// </summary>
		public IntValue? SortOrder { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StaffID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Staff Member ID</para>
		/// </summary>
		public StringValue? StaffMemberID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// </summary>
		public StringValue? Subaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SMEquipmentID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Target Equipment ID</para>
		/// </summary>
		public StringValue? TargetEquipmentID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxCategoryID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Tax Category</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryUnitPrice</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Unit Price</para>
		/// </summary>
		public DecimalValue? UnitPrice { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// </summary>
		public BooleanValue? Warranty { get; set; }

	}
}