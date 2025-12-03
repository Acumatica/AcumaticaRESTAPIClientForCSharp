using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM201100</c> in the Acumatica ERP
	/// <para>Key Fields: OrderType</para>
	/// </summary>
	[DataContract]
	public class OrderTypes : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// Allow pre-assigning of lot/serial numbers
		/// <para>DAC Field Name: PreassignLotSerial</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Allow Preassigning Lot/Serial Numbers</para>
		/// </summary>
		[DataMember(Name="AllowPreassigningLotSerialNumbers", EmitDefaultValue=false)]
		public BooleanValue? AllowPreassigningLotSerialNumbers { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<OrderTypeAttribute>? Attributes { get; set; }

		/// <summary>
		/// Enable/ Disable Auto backward reporting for the order type.
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Automatic Backward Reporting</para>
		/// </summary>
		[DataMember(Name="AutoBackwardReporting", EmitDefaultValue=false)]
		public BooleanValue? AutoBackwardReporting { get; set; }

		/// <summary>
		/// APS Schedule option - Check for Material Availability.
		/// <para>DAC Field Name: CheckSchdMatlAvailability</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Check for Material Availability</para>
		/// </summary>
		[DataMember(Name="CheckforMaterialAvailability", EmitDefaultValue=false)]
		public BooleanValue? CheckforMaterialAvailability { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DefaultCostMethod</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Costing Method</para>
		/// </summary>
		[DataMember(Name="CostingMethod", EmitDefaultValue=false)]
		public StringValue? CostingMethod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DefaultOperationMoveQty</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Default operation move qty</para>
		/// </summary>
		[DataMember(Name="Defaultoperationmoveqty", EmitDefaultValue=false)]
		public BooleanValue? Defaultoperationmoveqty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// Check if the Qty is exceeded for the operation
		/// <para>DAC Field Name: ExceedQtyOperations</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Excess Qty. for Operations</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="ExceedingQtyforOperations", EmitDefaultValue=false)]
		public StringValue? ExceedingQtyforOperations { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExcludeFromMRP</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Exclude from MRP</para>
		/// </summary>
		[DataMember(Name="ExcludefromMRP", EmitDefaultValue=false)]
		public BooleanValue? ExcludefromMRP { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// </summary>
		[DataMember(Name="Function", EmitDefaultValue=false)]
		public StringValue? Function { get; set; }

		/// <summary>
		/// When checked, this option tells the calculation for over issue material to include any qty unreleased for the given material item.(Preference works with OverIssueMaterial.)
		/// <para>DAC Field Name: IncludeUnreleasedOverIssueMaterial</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Include unreleased batch qty</para>
		/// </summary>
		[DataMember(Name="Includeunreleasedbatchqty", EmitDefaultValue=false)]
		public BooleanValue? Includeunreleasedbatchqty { get; set; }

		/// <summary>
		/// Check for the given material item being added to a material issue transaction if the item exists on the entered production order.
		/// <para>DAC Field Name: IssueMaterialOnTheFly</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Issue Material Not On Order</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="IssueMaterialNotOnOrder", EmitDefaultValue=false)]
		public StringValue? IssueMaterialNotOnOrder { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CopyNotesItem</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Item/Header</para>
		/// </summary>
		[DataMember(Name="ItemHeader", EmitDefaultValue=false)]
		public BooleanValue? ItemHeader { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CopyNotesMatl</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// </summary>
		[DataMember(Name="Material", EmitDefaultValue=false)]
		public BooleanValue? Material { get; set; }

		/// <summary>
		/// Check operation completed status during move entry
		/// <para>DAC Field Name: MoveCompletedOrders</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Move on Completed Operations</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="MoveonCompletedOperations", EmitDefaultValue=false)]
		public StringValue? MoveonCompletedOperations { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CopyNotesOper</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// </summary>
		[DataMember(Name="Operation", EmitDefaultValue=false)]
		public BooleanValue? Operation { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdNumberingID</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Order Numbering Sequence</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="OrderNumberingSequence", EmitDefaultValue=false)]
		public StringValue? OrderNumberingSequence { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// Check for last operation if move qty > order qty remaining
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Excess Qty. for Orders</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="OverCompleteOrders", EmitDefaultValue=false)]
		public StringValue? OverCompleteOrders { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CopyNotesOvhd</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// </summary>
		[DataMember(Name="Overhead", EmitDefaultValue=false)]
		public BooleanValue? Overhead { get; set; }

		/// <summary>
		/// Check for over issued material during material entry
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Over Issue Material</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="OverIssueMaterial", EmitDefaultValue=false)]
		public StringValue? OverIssueMaterial { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProductionReportID</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Print Production Report ID</para>
		/// <para>SQL Type: char(8)</para>
		/// </summary>
		[DataMember(Name="PrintProductionReportID", EmitDefaultValue=false)]
		public StringValue? PrintProductionReportID { get; set; }

		/// <summary>
		/// Parent lot number is/isn't required for material transactions
		/// <para>DAC Field Name: ParentLotSerialRequired</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Require Parent Lot/Serial Number</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="RequireParentLotSerialNumber", EmitDefaultValue=false)]
		public StringValue? RequireParentLotSerialNumber { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ScrapLocationID</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Scrap Location</para>
		/// </summary>
		[DataMember(Name="ScrapLocation", EmitDefaultValue=false)]
		public StringValue? ScrapLocation { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Scrap Source</para>
		/// </summary>
		[DataMember(Name="ScrapSource", EmitDefaultValue=false)]
		public StringValue? ScrapSource { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ScrapSiteID</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Scrap Warehouse</para>
		/// </summary>
		[DataMember(Name="ScrapWarehouse", EmitDefaultValue=false)]
		public StringValue? ScrapWarehouse { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CopyNotesStep</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// </summary>
		[DataMember(Name="Step", EmitDefaultValue=false)]
		public BooleanValue? Step { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Substitute Work Centers</para>
		/// </summary>
		[DataMember(Name="SubstituteWorkCenters", EmitDefaultValue=false)]
		public BooleanValue? SubstituteWorkCenters { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CopyNotesTool</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// </summary>
		[DataMember(Name="Tool", EmitDefaultValue=false)]
		public BooleanValue? Tool { get; set; }

		/// <summary>
		/// Check for under issued material during move entry based on operation/current move qty
		/// <para>DAC Field Name: BackflushUnderIssueMaterial</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Under Issue Backflush Material</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="UnderIssueBackflushMaterial", EmitDefaultValue=false)]
		public StringValue? UnderIssueBackflushMaterial { get; set; }

		/// <summary>
		/// Check for under issued material during move entry based on operation/current move qty
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Under Issue Material</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="UnderIssueMaterial", EmitDefaultValue=false)]
		public StringValue? UnderIssueMaterial { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WIPVarianceAcctID</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: WIP Variance Account</para>
		/// </summary>
		[DataMember(Name="WIPVarianceAccount", EmitDefaultValue=false)]
		public StringValue? WIPVarianceAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WIPVarianceSubID</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: WIP Variance Sub.</para>
		/// </summary>
		[DataMember(Name="WIPVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue? WIPVarianceSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WIPAcctID</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Work in Process Account</para>
		/// </summary>
		[DataMember(Name="WorkinProcessAccount", EmitDefaultValue=false)]
		public StringValue? WorkinProcessAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WIPSubID</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Work In Process Sub.</para>
		/// </summary>
		[DataMember(Name="WorkInProcessSubaccount", EmitDefaultValue=false)]
		public StringValue? WorkInProcessSubaccount { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Attributes = "Attributes";

			//Intentionally excluded
			//public const string All = "Files,Attributes";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}