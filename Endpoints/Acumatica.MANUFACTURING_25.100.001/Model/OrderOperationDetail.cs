using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	[DataContract]
	public class OrderOperationDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: ActEndDate</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Actual End Date</para>
		/// </summary>
		[DataMember(Name="ActualEndDate", EmitDefaultValue=false)]
		public DateTimeValue? ActualEndDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ActStartDate</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Actual Start Date</para>
		/// </summary>
		[DataMember(Name="ActualStartDate", EmitDefaultValue=false)]
		public DateTimeValue? ActualStartDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: At Vendor Quantity</para>
		/// </summary>
		[DataMember(Name="AtVendorQuantity", EmitDefaultValue=false)]
		public DecimalValue? AtVendorQuantity { get; set; }

		/// <summary>
		/// Auto report qty decides if the operation allows non sequential quantities when a move occurs for a later operation.
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Auto-Report Qty</para>
		/// </summary>
		[DataMember(Name="AutoReportQty", EmitDefaultValue=false)]
		public BooleanValue? AutoReportQty { get; set; }

		/// <summary>
		/// Determine whether user need to release labor manually or not 
		/// <para>DAC Field Name: BFlush</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Backflush Labor</para>
		/// </summary>
		[DataMember(Name="BackflushLabor", EmitDefaultValue=false)]
		public BooleanValue? BackflushLabor { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Control Point</para>
		/// </summary>
		[DataMember(Name="ControlPoint", EmitDefaultValue=false)]
		public BooleanValue? ControlPoint { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DropShippedToVendor</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Drop Shipped to Vendor</para>
		/// </summary>
		[DataMember(Name="DropShippedtoVendor", EmitDefaultValue=false)]
		public BooleanValue? DropShippedtoVendor { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: End Date</para>
		/// </summary>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		[DataMember(Name="FinishTime", EmitDefaultValue=false)]
		public IntValue? FinishTime { get; set; }

		[DataMember(Name="MachineTime", EmitDefaultValue=false)]
		public IntValue? MachineTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Machine Units</para>
		/// </summary>
		[DataMember(Name="MachineUnits", EmitDefaultValue=false)]
		public DecimalValue? MachineUnits { get; set; }

		[DataMember(Name="Material", EmitDefaultValue=false)]
		public List<OrderMaterialDetail>? Material { get; set; }

		[DataMember(Name="MoveTime", EmitDefaultValue=false)]
		public IntValue? MoveTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Operation Description</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="OperationDescription", EmitDefaultValue=false)]
		public StringValue? OperationDescription { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OperationCD</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Operation ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="OperationNbr", EmitDefaultValue=false)]
		public StringValue? OperationNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StatusID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Status</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="OperationStatus", EmitDefaultValue=false)]
		public StringValue? OperationStatus { get; set; }

		[DataMember(Name="OperationTotal", EmitDefaultValue=false)]
		public ProductionOrderOperationTotal? OperationTotal { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Outside Process</para>
		/// </summary>
		[DataMember(Name="OutsideProcess", EmitDefaultValue=false)]
		public BooleanValue? OutsideProcess { get; set; }

		[DataMember(Name="Overheads", EmitDefaultValue=false)]
		public List<OrderOverheadDetail>? Overheads { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PhtmBOMID</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Phantom BOM ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="PhantomBomID", EmitDefaultValue=false)]
		public StringValue? PhantomBomID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PhtmBOMLineRef</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Phantom BOM Ref Line Nbr</para>
		/// </summary>
		[DataMember(Name="PhantomBOMLineID", EmitDefaultValue=false)]
		public IntValue? PhantomBOMLineID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PhtmBOMOperationID</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Phantom Operation ID</para>
		/// </summary>
		[DataMember(Name="PhantomBOMOperNbr", EmitDefaultValue=false)]
		public StringValue? PhantomBOMOperNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PhtmBOMRevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Phantom BOM Revision</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="PhantomBOMRevision", EmitDefaultValue=false)]
		public StringValue? PhantomBOMRevision { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PhtmLevel</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Phantom Level</para>
		/// </summary>
		[DataMember(Name="PhantomLevel", EmitDefaultValue=false)]
		public IntValue? PhantomLevel { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PhtmMatlBOMID</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Phantom Matl BOM ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="PhantomMatlBOMID", EmitDefaultValue=false)]
		public StringValue? PhantomMatlBOMID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PhtmMatlLineRef</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Phantom Matl Line Nbr</para>
		/// </summary>
		[DataMember(Name="PhantomMatlLineID", EmitDefaultValue=false)]
		public IntValue? PhantomMatlLineID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PhtmMatlOperationID</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Phantom Matl Operation ID</para>
		/// </summary>
		[DataMember(Name="PhantomMatlOperNbr", EmitDefaultValue=false)]
		public StringValue? PhantomMatlOperNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PhtmMatlRevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Phantom Matl Revision</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="PhantomMatlRevision", EmitDefaultValue=false)]
		public StringValue? PhantomMatlRevision { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PhtmPriorLevelQty</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Phantom Prior Level Qty</para>
		/// </summary>
		[DataMember(Name="PhantomPriorLevelQty", EmitDefaultValue=false)]
		public DecimalValue? PhantomPriorLevelQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EndDate</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: End Date</para>
		/// </summary>
		[DataMember(Name="PlanEndDate", EmitDefaultValue=false)]
		public DateTimeValue? PlanEndDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StartDate</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Start Date</para>
		/// </summary>
		[DataMember(Name="PlanStartDate", EmitDefaultValue=false)]
		public DateTimeValue? PlanStartDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: PO Line Nbr.</para>
		/// </summary>
		[DataMember(Name="POLineNbr", EmitDefaultValue=false)]
		public IntValue? POLineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: PO Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="POOrderNbr", EmitDefaultValue=false)]
		public StringValue? POOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Qty Complete</para>
		/// </summary>
		[DataMember(Name="QtyComplete", EmitDefaultValue=false)]
		public DecimalValue? QtyComplete { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Qty Remaining</para>
		/// </summary>
		[DataMember(Name="QtyRemaining", EmitDefaultValue=false)]
		public DecimalValue? QtyRemaining { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Qty Scrapped</para>
		/// </summary>
		[DataMember(Name="QtyScrapped", EmitDefaultValue=false)]
		public DecimalValue? QtyScrapped { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtytoProd</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Qty to Produce</para>
		/// </summary>
		[DataMember(Name="QtytoProduce", EmitDefaultValue=false)]
		public DecimalValue? QtytoProduce { get; set; }

		[DataMember(Name="QueueTime", EmitDefaultValue=false)]
		public IntValue? QueueTime { get; set; }

		[DataMember(Name="RunTime", EmitDefaultValue=false)]
		public IntValue? RunTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Run Units</para>
		/// </summary>
		[DataMember(Name="RunUnits", EmitDefaultValue=false)]
		public DecimalValue? RunUnits { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Scrap Action</para>
		/// </summary>
		[DataMember(Name="ScrapAction", EmitDefaultValue=false)]
		public StringValue? ScrapAction { get; set; }

		[DataMember(Name="SetupTime", EmitDefaultValue=false)]
		public IntValue? SetupTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Shipped Quantity</para>
		/// </summary>
		[DataMember(Name="ShippedQuantity", EmitDefaultValue=false)]
		public DecimalValue? ShippedQuantity { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Ship Remaining Qty</para>
		/// </summary>
		[DataMember(Name="ShipRemainingQty", EmitDefaultValue=false)]
		public DecimalValue? ShipRemainingQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Start Date</para>
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		[DataMember(Name="Steps", EmitDefaultValue=false)]
		public List<OrderStepDetail>? Steps { get; set; }

		[DataMember(Name="Tools", EmitDefaultValue=false)]
		public List<OrderToolDetail>? Tools { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Total Qty</para>
		/// </summary>
		[DataMember(Name="TotalQty", EmitDefaultValue=false)]
		public DecimalValue? TotalQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorID</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// </summary>
		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorLocationID</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Vendor Location</para>
		/// </summary>
		[DataMember(Name="VendorLocation", EmitDefaultValue=false)]
		public StringValue? VendorLocation { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WcID</para>
		/// <para>DAC: PX.Objects.AM.AMProdOper</para>
		/// <para>Display Name: Work Center</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		[DataMember(Name="WorkCenter", EmitDefaultValue=false)]
		public StringValue? WorkCenter { get; set; }

	}
}