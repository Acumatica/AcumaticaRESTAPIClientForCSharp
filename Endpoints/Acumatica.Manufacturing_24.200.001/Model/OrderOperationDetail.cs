using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	public class OrderOperationDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: ActEndDate</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Actual End Date</para>
		/// </summary>
		public DateTimeValue? ActualEndDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ActStartDate</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Actual Start Date</para>
		/// </summary>
		public DateTimeValue? ActualStartDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: At Vendor Quantity</para>
		/// </summary>
		public DecimalValue? AtVendorQuantity { get; set; }

		/// <summary>
		/// Auto report qty decides if the operation allows non sequential quantities when a move occurs for a later operation.
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Auto-Report Qty.</para>
		/// </summary>
		public BooleanValue? AutoReportQty { get; set; }

		/// <summary>
		/// Determine whether user need to release labor manually or not 
		/// <para>DAC Field Name: BFlush</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Backflush Labor</para>
		/// </summary>
		public BooleanValue? BackflushLabor { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Control Point</para>
		/// </summary>
		public BooleanValue? ControlPoint { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DropShippedToVendor</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Drop Shipped to Vendor</para>
		/// </summary>
		public BooleanValue? DropShippedtoVendor { get; set; }

		public IntValue? FinishTime { get; set; }

		public IntValue? MachineTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Machine Units</para>
		/// </summary>
		public DecimalValue? MachineUnits { get; set; }

		public List<OrderMaterialDetail>? Material { get; set; }

		public IntValue? MoveTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Operation Description</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? OperationDescription { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OperationCD</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Operation ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? OperationNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StatusID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Status</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? OperationStatus { get; set; }

		public ProductionOrderOperationTotal? OperationTotal { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Outside Process</para>
		/// </summary>
		public BooleanValue? OutsideProcess { get; set; }

		public List<OrderOverheadDetail>? Overheads { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PhtmBOMID</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Phantom BOM ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? PhantomBomID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PhtmBOMLineRef</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Phantom BOM Ref. Line Nbr.</para>
		/// </summary>
		public IntValue? PhantomBOMLineID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PhtmBOMOperationID</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Phantom Operation ID</para>
		/// </summary>
		public StringValue? PhantomBOMOperNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PhtmBOMRevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Phantom BOM Revision</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? PhantomBOMRevision { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PhtmLevel</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Phantom Level</para>
		/// </summary>
		public IntValue? PhantomLevel { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PhtmMatlBOMID</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Phantom Material BOM ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? PhantomMatlBOMID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PhtmMatlLineRef</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Phantom Material Line Nbr.</para>
		/// </summary>
		public IntValue? PhantomMatlLineID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PhtmMatlOperationID</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Phantom Material Operation ID</para>
		/// </summary>
		public StringValue? PhantomMatlOperNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PhtmMatlRevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Phantom Material Revision</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? PhantomMatlRevision { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PhtmPriorLevelQty</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Phantom Prior Level Qty.</para>
		/// </summary>
		public DecimalValue? PhantomPriorLevelQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EndDate</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: End Date</para>
		/// </summary>
		public DateTimeValue? PlanEndDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StartDate</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Start Date</para>
		/// </summary>
		public DateTimeValue? PlanStartDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: PO Line Nbr.</para>
		/// </summary>
		public IntValue? POLineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: PO Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? POOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Completed Qty.</para>
		/// </summary>
		public DecimalValue? QtyComplete { get; set; }

		/// <summary>
		/// TotalQty subtract QtyComplete add QtyScrapped.
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Remaining Qty.</para>
		/// </summary>
		public DecimalValue? QtyRemaining { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Scrapped Qty.</para>
		/// </summary>
		public DecimalValue? QtyScrapped { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtytoProd</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Qty. to Produce</para>
		/// </summary>
		public DecimalValue? QtytoProduce { get; set; }

		public IntValue? QueueTime { get; set; }

		public IntValue? RunTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Run Units</para>
		/// </summary>
		public DecimalValue? RunUnits { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Scrap Action</para>
		/// </summary>
		public StringValue? ScrapAction { get; set; }

		public IntValue? SetupTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Shipped Quantity</para>
		/// </summary>
		public DecimalValue? ShippedQuantity { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Ship Remaining Qty.</para>
		/// </summary>
		public DecimalValue? ShipRemainingQty { get; set; }

		public List<OrderStepDetail>? Steps { get; set; }

		public List<OrderToolDetail>? Tools { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Total Qty.</para>
		/// </summary>
		public DecimalValue? TotalQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorID</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// </summary>
		public StringValue? Vendor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorLocationID</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Vendor Location</para>
		/// </summary>
		public StringValue? VendorLocation { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WcID</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Work Center</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		public StringValue? WorkCenter { get; set; }

	}
}