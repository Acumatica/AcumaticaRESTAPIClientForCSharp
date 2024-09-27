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
		/// DAC Field Name: AcctID 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		/// <summary>
		/// DAC Field Name: CuryTranAmt 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Actual Amount 
		/// </summary>
		[DataMember(Name="ActualAmount", EmitDefaultValue=false)]
		public DecimalValue? ActualAmount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Actual Duration 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="ActualDuration", EmitDefaultValue=false)]
		public StringValue? ActualDuration { get; set; }

		/// <summary>
		/// DAC Field Name: Qty 
		/// DAC: PX.Objects.FS.FSApptLineSplit 
		/// Display Name: Quantity 
		/// </summary>
		[DataMember(Name="ActualQty", EmitDefaultValue=false)]
		public DecimalValue? ActualQty { get; set; }

		/// <summary>
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Appointment Nbr. 
		/// SQL Type: nvarchar(20) 
		/// Key Field
		/// </summary>
		[DataMember(Name="AppointmentNbr", EmitDefaultValue=false)]
		public StringValue? AppointmentNbr { get; set; }

		/// <summary>
		/// DAC Field Name: IsBillable 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// </summary>
		[DataMember(Name="Billable", EmitDefaultValue=false)]
		public BooleanValue? Billable { get; set; }

		/// <summary>
		/// DAC Field Name: CuryBillableTranAmt 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Billable Amount 
		/// </summary>
		[DataMember(Name="BillableAmount", EmitDefaultValue=false)]
		public DecimalValue? BillableAmount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Billable Quantity 
		/// </summary>
		[DataMember(Name="BillableQty", EmitDefaultValue=false)]
		public DecimalValue? BillableQty { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Billing Rule 
		/// SQL Type: char(4) 
		/// </summary>
		[DataMember(Name="BillingRule", EmitDefaultValue=false)]
		public StringValue? BillingRule { get; set; }

		/// <summary>
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Component ID 
		/// </summary>
		[DataMember(Name="ComponentID", EmitDefaultValue=false)]
		public StringValue? ComponentID { get; set; }

		/// <summary>
		/// DAC Field Name: EquipmentLineRef 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Component Ref. Nbr. 
		/// </summary>
		[DataMember(Name="ComponentLineRef", EmitDefaultValue=false)]
		public StringValue? ComponentLineRef { get; set; }

		/// <summary>
		/// DAC Field Name: CostCodeID 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Cost Code 
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Covered Quantity 
		/// </summary>
		[DataMember(Name="CoveredQty", EmitDefaultValue=false)]
		public DecimalValue? CoveredQty { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Unit Cost 
		/// </summary>
		[DataMember(Name="CuryUnitCost", EmitDefaultValue=false)]
		public DecimalValue? CuryUnitCost { get; set; }

		/// <summary>
		/// DAC Field Name: TranDesc 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: CuryDiscAmt 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Discount Amount 
		/// </summary>
		[DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
		public DecimalValue? DiscountAmount { get; set; }

		/// <summary>
		/// DAC Field Name: DiscPct 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Discount Percent 
		/// </summary>
		[DataMember(Name="DiscountPercent", EmitDefaultValue=false)]
		public DecimalValue? DiscountPercent { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Equipment Action 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="EquipmentAction", EmitDefaultValue=false)]
		public StringValue? EquipmentAction { get; set; }

		/// <summary>
		/// DAC Field Name: Comment 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Equipment Action Comment 
		/// SQL Type: varchar(255) 
		/// </summary>
		[DataMember(Name="EquipmentActionComment", EmitDefaultValue=false)]
		public StringValue? EquipmentActionComment { get; set; }

		/// <summary>
		/// DAC Field Name: CuryEstimatedTranAmt 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Estimated Amount 
		/// </summary>
		[DataMember(Name="EstimatedAmount", EmitDefaultValue=false)]
		public DecimalValue? EstimatedAmount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Estimated Duration 
		/// </summary>
		[DataMember(Name="EstimatedDuration", EmitDefaultValue=false)]
		public StringValue? EstimatedDuration { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Estimated Quantity 
		/// </summary>
		[DataMember(Name="EstimatedQty", EmitDefaultValue=false)]
		public DecimalValue? EstimatedQty { get; set; }

		/// <summary>
		/// DAC Field Name: CuryBillableExtPrice 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Ext. Price 
		/// </summary>
		[DataMember(Name="ExtPrice", EmitDefaultValue=false)]
		public DecimalValue? ExtPrice { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Line Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Ref. Nbr. 
		/// SQL Type: char(4) 
		/// </summary>
		[DataMember(Name="LineRef", EmitDefaultValue=false)]
		public StringValue? LineRef { get; set; }

		/// <summary>
		/// DAC Field Name: UIStatus 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Line Status 
		/// SQL Type: nchar(2) 
		/// </summary>
		[DataMember(Name="LineStatus", EmitDefaultValue=false)]
		public StringValue? LineStatus { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Line Type 
		/// SQL Type: char(5) 
		/// </summary>
		[DataMember(Name="LineType", EmitDefaultValue=false)]
		public StringValue? LineType { get; set; }

		/// <summary>
		/// DAC Field Name: SiteLocationID 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Lot/Serial Nbr. 
		/// SQL Type: nvarchar(100) 
		/// </summary>
		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Manual Price 
		/// </summary>
		[DataMember(Name="ManualPrice", EmitDefaultValue=false)]
		public BooleanValue? ManualPrice { get; set; }

		/// <summary>
		/// DAC Field Name: EnablePO 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Mark for PO 
		/// </summary>
		[DataMember(Name="MarkforPO", EmitDefaultValue=false)]
		public BooleanValue? MarkforPO { get; set; }

		/// <summary>
		/// DAC Field Name: NewTargetEquipmentLineNbr 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Model Equipment Ref. Nbr. 
		/// SQL Type: char(4) 
		/// </summary>
		[DataMember(Name="ModelEquipmentLineRef", EmitDefaultValue=false)]
		public StringValue? ModelEquipmentLineRef { get; set; }

		/// <summary>
		/// DAC Field Name: ExtraUsageQty 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Overage Quantity 
		/// </summary>
		[DataMember(Name="OverageQty", EmitDefaultValue=false)]
		public DecimalValue? OverageQty { get; set; }

		/// <summary>
		/// DAC Field Name: CuryExtraUsageUnitPrice 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Overage Unit Price 
		/// </summary>
		[DataMember(Name="OverageUnitPrice", EmitDefaultValue=false)]
		public DecimalValue? OverageUnitPrice { get; set; }

		/// <summary>
		/// DAC Field Name: ServiceType 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Pickup/Delivery Action 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="PickupDeliveryAction", EmitDefaultValue=false)]
		public StringValue? PickupDeliveryAction { get; set; }

		/// <summary>
		/// DAC Field Name: PickupDeliveryAppLineRef 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Pickup/Delivery Ref. Nbr. 
		/// SQL Type: char(4) 
		/// </summary>
		[DataMember(Name="PickupDeliveryLineRef", EmitDefaultValue=false)]
		public StringValue? PickupDeliveryLineRef { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Pickup/Delivery Service ID 
		/// </summary>
		[DataMember(Name="PickupDeliveryServiceID", EmitDefaultValue=false)]
		public StringValue? PickupDeliveryServiceID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: PO Completed 
		/// </summary>
		[DataMember(Name="POCompleted", EmitDefaultValue=false)]
		public BooleanValue? POCompleted { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: PO Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="PONbr", EmitDefaultValue=false)]
		public StringValue? PONbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: PO Status 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="POStatus", EmitDefaultValue=false)]
		public StringValue? POStatus { get; set; }

		/// <summary>
		/// DAC Field Name: IsPrepaid 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Prepaid Item 
		/// </summary>
		[DataMember(Name="PrepaidItem", EmitDefaultValue=false)]
		public BooleanValue? PrepaidItem { get; set; }

		/// <summary>
		/// DAC Field Name: ProjectTaskID 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Project Task 
		/// </summary>
		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// DAC Field Name: LinkedDisplayRefNbr 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Related Doc. Nbr. 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="RelatedDocNbr", EmitDefaultValue=false)]
		public StringValue? RelatedDocNbr { get; set; }

		/// <summary>
		/// DAC Field Name: ContractRelated 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Service Contract Item 
		/// </summary>
		[DataMember(Name="ServiceContractItem", EmitDefaultValue=false)]
		public BooleanValue? ServiceContractItem { get; set; }

		/// <summary>
		/// DAC Field Name: SODetID 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Service Order Detail Ref. Nbr. 
		/// </summary>
		[DataMember(Name="ServiceOrderLineRef", EmitDefaultValue=false)]
		public StringValue? ServiceOrderLineRef { get; set; }

		/// <summary>
		/// DAC Field Name: SrvOrdType 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Service Order Type 
		/// SQL Type: char(4) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ServiceOrderType", EmitDefaultValue=false)]
		public StringValue? ServiceOrderType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Sort Order 
		/// </summary>
		[DataMember(Name="SortOrder", EmitDefaultValue=false)]
		public IntValue? SortOrder { get; set; }

		/// <summary>
		/// DAC Field Name: StaffID 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Staff Member ID 
		/// </summary>
		[DataMember(Name="StaffMemberID", EmitDefaultValue=false)]
		public StringValue? StaffMemberID { get; set; }

		/// <summary>
		/// DAC Field Name: SubID 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// </summary>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC Field Name: SMEquipmentID 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Target Equipment ID 
		/// </summary>
		[DataMember(Name="TargetEquipmentID", EmitDefaultValue=false)]
		public StringValue? TargetEquipmentID { get; set; }

		/// <summary>
		/// DAC Field Name: TaxCategoryID 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Tax Category 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// DAC Field Name: CuryUnitPrice 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Unit Price 
		/// </summary>
		[DataMember(Name="UnitPrice", EmitDefaultValue=false)]
		public DecimalValue? UnitPrice { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// </summary>
		[DataMember(Name="Warranty", EmitDefaultValue=false)]
		public BooleanValue? Warranty { get; set; }

	}
}