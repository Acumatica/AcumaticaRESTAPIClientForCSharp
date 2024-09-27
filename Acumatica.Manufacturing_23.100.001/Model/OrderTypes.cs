using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM201100 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class OrderTypes : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// Allow pre-assigning of lot/serial numbers
		/// DAC Field Name: PreassignLotSerial 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// Display Name: Allow Preassigning Lot/Serial Numbers 
		/// </summary>
		[DataMember(Name="AllowPreassigningLotSerialNumbers", EmitDefaultValue=false)]
		public BooleanValue? AllowPreassigningLotSerialNumbers { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<OrderTypeAttribute>? Attributes { get; set; }

		/// <summary>
		/// APS Schedule option - Check for Material Availability.
		/// DAC Field Name: CheckSchdMatlAvailability 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// Display Name: Check for Material Availability 
		/// </summary>
		[DataMember(Name="CheckforMaterialAvailability", EmitDefaultValue=false)]
		public BooleanValue? CheckforMaterialAvailability { get; set; }

		/// <summary>
		/// DAC Field Name: DefaultCostMethod 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// Display Name: Costing Method 
		/// </summary>
		[DataMember(Name="CostingMethod", EmitDefaultValue=false)]
		public StringValue? CostingMethod { get; set; }

		/// <summary>
		/// DAC Field Name: DefaultOperationMoveQty 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// Display Name: Default operation move qty 
		/// </summary>
		[DataMember(Name="Defaultoperationmoveqty", EmitDefaultValue=false)]
		public BooleanValue? Defaultoperationmoveqty { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// Check if the Qty is exceeded for the operation
		/// DAC Field Name: ExceedQtyOperations 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// Display Name: Excess Qty. for Operations 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="ExceedingQtyforOperations", EmitDefaultValue=false)]
		public StringValue? ExceedingQtyforOperations { get; set; }

		/// <summary>
		/// DAC Field Name: ExcludeFromMRP 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// Display Name: Exclude from MRP 
		/// </summary>
		[DataMember(Name="ExcludefromMRP", EmitDefaultValue=false)]
		public BooleanValue? ExcludefromMRP { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		[DataMember(Name="Function", EmitDefaultValue=false)]
		public StringValue? Function { get; set; }

		/// <summary>
		/// When checked, this option tells the calculation for over issue material to include any qty unreleased for the given material item.(Preference works with OverIssueMaterial.)
		/// DAC Field Name: IncludeUnreleasedOverIssueMaterial 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// Display Name: Include unreleased batch qty 
		/// </summary>
		[DataMember(Name="Includeunreleasedbatchqty", EmitDefaultValue=false)]
		public BooleanValue? Includeunreleasedbatchqty { get; set; }

		/// <summary>
		/// Check for the given material item being added to a material issue transaction if the item exists on the entered production order.
		/// DAC Field Name: IssueMaterialOnTheFly 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// Display Name: Issue Material Not On Order 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="IssueMaterialNotOnOrder", EmitDefaultValue=false)]
		public StringValue? IssueMaterialNotOnOrder { get; set; }

		/// <summary>
		/// DAC Field Name: CopyNotesItem 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// Display Name: Item/Header 
		/// </summary>
		[DataMember(Name="ItemHeader", EmitDefaultValue=false)]
		public BooleanValue? ItemHeader { get; set; }

		/// <summary>
		/// DAC Field Name: CopyNotesMatl 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		[DataMember(Name="Material", EmitDefaultValue=false)]
		public BooleanValue? Material { get; set; }

		/// <summary>
		/// Check operation completed status during move entry
		/// DAC Field Name: MoveCompletedOrders 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// Display Name: Move on Completed Operations 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="MoveonCompletedOperations", EmitDefaultValue=false)]
		public StringValue? MoveonCompletedOperations { get; set; }

		/// <summary>
		/// DAC Field Name: CopyNotesOper 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		[DataMember(Name="Operation", EmitDefaultValue=false)]
		public BooleanValue? Operation { get; set; }

		/// <summary>
		/// DAC Field Name: ProdNumberingID 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// Display Name: Order Numbering Sequence 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="OrderNumberingSequence", EmitDefaultValue=false)]
		public StringValue? OrderNumberingSequence { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMOrderType 
		/// Display Name: Order Type 
		/// SQL Type: char(2) 
		/// Key Field
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// Check for last operation if move qty > order qty remaining
		/// DAC: PX.Objects.AM.AMOrderType 
		/// Display Name: Excess Qty. for Orders 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="OverCompleteOrders", EmitDefaultValue=false)]
		public StringValue? OverCompleteOrders { get; set; }

		/// <summary>
		/// DAC Field Name: CopyNotesOvhd 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		[DataMember(Name="Overhead", EmitDefaultValue=false)]
		public BooleanValue? Overhead { get; set; }

		/// <summary>
		/// Check for over issued material during material entry
		/// DAC: PX.Objects.AM.AMOrderType 
		/// Display Name: Over Issue Material 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="OverIssueMaterial", EmitDefaultValue=false)]
		public StringValue? OverIssueMaterial { get; set; }

		/// <summary>
		/// DAC Field Name: ProductionReportID 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// Display Name: Print Production Report ID 
		/// SQL Type: char(8) 
		/// </summary>
		[DataMember(Name="PrintProductionReportID", EmitDefaultValue=false)]
		public StringValue? PrintProductionReportID { get; set; }

		/// <summary>
		/// Parent lot number is/isn't required for material transactions
		/// DAC Field Name: ParentLotSerialRequired 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// Display Name: Require Parent Lot/Serial Number 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="RequireParentLotSerialNumber", EmitDefaultValue=false)]
		public StringValue? RequireParentLotSerialNumber { get; set; }

		/// <summary>
		/// DAC Field Name: ScrapLocationID 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// Display Name: Scrap Location 
		/// </summary>
		[DataMember(Name="ScrapLocation", EmitDefaultValue=false)]
		public StringValue? ScrapLocation { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMOrderType 
		/// Display Name: Scrap Source 
		/// </summary>
		[DataMember(Name="ScrapSource", EmitDefaultValue=false)]
		public StringValue? ScrapSource { get; set; }

		/// <summary>
		/// DAC Field Name: ScrapSiteID 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// Display Name: Scrap Warehouse 
		/// </summary>
		[DataMember(Name="ScrapWarehouse", EmitDefaultValue=false)]
		public StringValue? ScrapWarehouse { get; set; }

		/// <summary>
		/// DAC Field Name: CopyNotesStep 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		[DataMember(Name="Step", EmitDefaultValue=false)]
		public BooleanValue? Step { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMOrderType 
		/// Display Name: Substitute Work Centers 
		/// </summary>
		[DataMember(Name="SubstituteWorkCenters", EmitDefaultValue=false)]
		public BooleanValue? SubstituteWorkCenters { get; set; }

		/// <summary>
		/// DAC Field Name: CopyNotesTool 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// </summary>
		[DataMember(Name="Tool", EmitDefaultValue=false)]
		public BooleanValue? Tool { get; set; }

		/// <summary>
		/// Check for under issued material during move entry based on operation/current move qty
		/// DAC Field Name: BackflushUnderIssueMaterial 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// Display Name: Under Issue Backflush Material 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="UnderIssueBackflushMaterial", EmitDefaultValue=false)]
		public StringValue? UnderIssueBackflushMaterial { get; set; }

		/// <summary>
		/// Check for under issued material during move entry based on operation/current move qty
		/// DAC: PX.Objects.AM.AMOrderType 
		/// Display Name: Under Issue Material 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="UnderIssueMaterial", EmitDefaultValue=false)]
		public StringValue? UnderIssueMaterial { get; set; }

		/// <summary>
		/// DAC Field Name: WIPVarianceAcctID 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// Display Name: WIP Variance Account 
		/// </summary>
		[DataMember(Name="WIPVarianceAccount", EmitDefaultValue=false)]
		public StringValue? WIPVarianceAccount { get; set; }

		/// <summary>
		/// DAC Field Name: WIPVarianceSubID 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// Display Name: WIP Variance Sub. 
		/// </summary>
		[DataMember(Name="WIPVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue? WIPVarianceSubaccount { get; set; }

		/// <summary>
		/// DAC Field Name: WIPAcctID 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// Display Name: Work in Process Account 
		/// </summary>
		[DataMember(Name="WorkinProcessAccount", EmitDefaultValue=false)]
		public StringValue? WorkinProcessAccount { get; set; }

		/// <summary>
		/// DAC Field Name: WIPSubID 
		/// DAC: PX.Objects.AM.AMOrderType 
		/// Display Name: Work In Process Sub. 
		/// </summary>
		[DataMember(Name="WorkInProcessSubaccount", EmitDefaultValue=false)]
		public StringValue? WorkInProcessSubaccount { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.100.001";
		}
	}
}