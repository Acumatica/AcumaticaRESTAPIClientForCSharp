using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM201100</c> in the Acumatica ERP
	/// <para>Key Fields: OrderType</para>
	/// </summary>
	public class OrderTypes : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// Allow pre-assigning of lot/serial numbers
		/// <para>DAC Field Name: PreassignLotSerial</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Allow Preassigning Lot/Serial Numbers</para>
		/// </summary>
		public BooleanValue? AllowPreassigningLotSerialNumbers { get; set; }

		public List<OrderTypeAttribute>? Attributes { get; set; }

		/// <summary>
		/// Enable/ Disable Auto backward reporting for the order type.
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Automatic Backward Reporting</para>
		/// </summary>
		public BooleanValue? AutoBackwardReporting { get; set; }

		/// <summary>
		/// APS Schedule option - Check for Material Availability.
		/// <para>DAC Field Name: CheckSchdMatlAvailability</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Check for Material Availability</para>
		/// </summary>
		public BooleanValue? CheckforMaterialAvailability { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DefaultCostMethod</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Costing Method</para>
		/// </summary>
		public StringValue? CostingMethod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DefaultOperationMoveQty</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Default Operation Move Qty.</para>
		/// </summary>
		public BooleanValue? Defaultoperationmoveqty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// Check if the Qty is exceeded for the operation
		/// <para>DAC Field Name: ExceedQtyOperations</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Excess Qty. for Operations</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? ExceedingQtyforOperations { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExcludeFromMRP</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Exclude from MRP</para>
		/// </summary>
		public BooleanValue? ExcludefromMRP { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// </summary>
		public StringValue? Function { get; set; }

		/// <summary>
		/// When checked, this option tells the calculation for over issue material to include any qty unreleased for the given material item.(Preference works with OverIssueMaterial.)
		/// <para>DAC Field Name: IncludeUnreleasedOverIssueMaterial</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Include Unreleased Batch Qty.</para>
		/// </summary>
		public BooleanValue? Includeunreleasedbatchqty { get; set; }

		/// <summary>
		/// Check for the given material item being added to a material issue transaction if the item exists on the entered production order.
		/// <para>DAC Field Name: IssueMaterialOnTheFly</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Issue Material Not On Order</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? IssueMaterialNotOnOrder { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CopyNotesItem</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Item/Header</para>
		/// </summary>
		public BooleanValue? ItemHeader { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CopyNotesMatl</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// </summary>
		public BooleanValue? Material { get; set; }

		/// <summary>
		/// Check operation completed status during move entry
		/// <para>DAC Field Name: MoveCompletedOrders</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Move on Completed Operations</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? MoveonCompletedOperations { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CopyNotesOper</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// </summary>
		public BooleanValue? Operation { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdNumberingID</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Order Numbering Sequence</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? OrderNumberingSequence { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// Key Field
		/// </summary>
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// Check for last operation if move qty > order qty remaining
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Excess Qty. for Orders</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? OverCompleteOrders { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CopyNotesOvhd</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// </summary>
		public BooleanValue? Overhead { get; set; }

		/// <summary>
		/// Check for over issued material during material entry
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Over Issue Material</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? OverIssueMaterial { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProductionReportID</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Print Production Report ID</para>
		/// <para>SQL Type: char(8)</para>
		/// </summary>
		public StringValue? PrintProductionReportID { get; set; }

		/// <summary>
		/// Parent lot number is/isn't required for material transactions
		/// <para>DAC Field Name: ParentLotSerialRequired</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Require Parent Lot/Serial Number</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? RequireParentLotSerialNumber { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ScrapLocationID</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Scrap Location</para>
		/// </summary>
		public StringValue? ScrapLocation { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Scrap Source</para>
		/// </summary>
		public StringValue? ScrapSource { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ScrapSiteID</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Scrap Warehouse</para>
		/// </summary>
		public StringValue? ScrapWarehouse { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CopyNotesStep</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// </summary>
		public BooleanValue? Step { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Substitute Work Centers</para>
		/// </summary>
		public BooleanValue? SubstituteWorkCenters { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CopyNotesTool</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// </summary>
		public BooleanValue? Tool { get; set; }

		/// <summary>
		/// Check for under issued material during move entry based on operation/current move qty
		/// <para>DAC Field Name: BackflushUnderIssueMaterial</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Under Issue Backflush Material</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? UnderIssueBackflushMaterial { get; set; }

		/// <summary>
		/// Check for under issued material during move entry based on operation/current move qty
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Under Issue Material</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? UnderIssueMaterial { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WIPVarianceAcctID</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: WIP Variance Account</para>
		/// </summary>
		public StringValue? WIPVarianceAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WIPVarianceSubID</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: WIP Variance Sub.</para>
		/// </summary>
		public StringValue? WIPVarianceSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WIPAcctID</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Work in Process Account</para>
		/// </summary>
		public StringValue? WorkinProcessAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WIPSubID</para>
		/// <para>DAC: PX.Objects.AM.AMOrderType</para>
		/// <para>Display Name: Work In Process Sub.</para>
		/// </summary>
		public StringValue? WorkInProcessSubaccount { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Attributes = "Attributes";

			//Intentionally excluded
			//public const string All = "Files,Translations,Attributes";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/25.100.001";
		}
	}
}