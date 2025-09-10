using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	[DataContract]
	public class OrderOperationDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: ActEndDate 
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Actual End Date 
		/// </summary>
		[DataMember(Name="ActualEndDate", EmitDefaultValue=false)]
		public DateTimeValue? ActualEndDate { get; set; }

		/// <summary>
		/// DAC Field Name: ActStartDate 
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Actual Start Date 
		/// </summary>
		[DataMember(Name="ActualStartDate", EmitDefaultValue=false)]
		public DateTimeValue? ActualStartDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: At Vendor Quantity 
		/// </summary>
		[DataMember(Name="AtVendorQuantity", EmitDefaultValue=false)]
		public DecimalValue? AtVendorQuantity { get; set; }

		/// <summary>
		/// Auto report qty decides if the operation allows non sequential quantities when a move occurs for a later operation.
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Auto-Report Qty 
		/// </summary>
		[DataMember(Name="AutoReportQty", EmitDefaultValue=false)]
		public BooleanValue? AutoReportQty { get; set; }

		/// <summary>
		/// Determine whether user need to release labor manually or not 
		/// DAC Field Name: BFlush 
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Backflush Labor 
		/// </summary>
		[DataMember(Name="BackflushLabor", EmitDefaultValue=false)]
		public BooleanValue? BackflushLabor { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Control Point 
		/// </summary>
		[DataMember(Name="ControlPoint", EmitDefaultValue=false)]
		public BooleanValue? ControlPoint { get; set; }

		/// <summary>
		/// DAC Field Name: DropShippedToVendor 
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Drop Shipped to Vendor 
		/// </summary>
		[DataMember(Name="DropShippedtoVendor", EmitDefaultValue=false)]
		public BooleanValue? DropShippedtoVendor { get; set; }

		[DataMember(Name="FinishTime", EmitDefaultValue=false)]
		public IntValue? FinishTime { get; set; }

		[DataMember(Name="MachineTime", EmitDefaultValue=false)]
		public IntValue? MachineTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Machine Units 
		/// </summary>
		[DataMember(Name="MachineUnits", EmitDefaultValue=false)]
		public DecimalValue? MachineUnits { get; set; }

		[DataMember(Name="Material", EmitDefaultValue=false)]
		public List<OrderMaterialDetail>? Material { get; set; }

		[DataMember(Name="MoveTime", EmitDefaultValue=false)]
		public IntValue? MoveTime { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Operation Description 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="OperationDescription", EmitDefaultValue=false)]
		public StringValue? OperationDescription { get; set; }

		/// <summary>
		/// DAC Field Name: OperationCD 
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Operation ID 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="OperationNbr", EmitDefaultValue=false)]
		public StringValue? OperationNbr { get; set; }

		/// <summary>
		/// DAC Field Name: StatusID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Status 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="OperationStatus", EmitDefaultValue=false)]
		public StringValue? OperationStatus { get; set; }

		[DataMember(Name="OperationTotal", EmitDefaultValue=false)]
		public ProductionOrderOperationTotal? OperationTotal { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Outside Process 
		/// </summary>
		[DataMember(Name="OutsideProcess", EmitDefaultValue=false)]
		public BooleanValue? OutsideProcess { get; set; }

		[DataMember(Name="Overheads", EmitDefaultValue=false)]
		public List<OrderOverheadDetail>? Overheads { get; set; }

		/// <summary>
		/// DAC Field Name: PhtmBOMID 
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Phantom BOM ID 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="PhantomBomID", EmitDefaultValue=false)]
		public StringValue? PhantomBomID { get; set; }

		/// <summary>
		/// DAC Field Name: PhtmBOMLineRef 
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Phantom BOM Ref Line Nbr 
		/// </summary>
		[DataMember(Name="PhantomBOMLineID", EmitDefaultValue=false)]
		public IntValue? PhantomBOMLineID { get; set; }

		/// <summary>
		/// DAC Field Name: PhtmBOMOperationID 
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Phantom Operation ID 
		/// </summary>
		[DataMember(Name="PhantomBOMOperNbr", EmitDefaultValue=false)]
		public StringValue? PhantomBOMOperNbr { get; set; }

		/// <summary>
		/// DAC Field Name: PhtmBOMRevisionID 
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Phantom BOM Revision 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="PhantomBOMRevision", EmitDefaultValue=false)]
		public StringValue? PhantomBOMRevision { get; set; }

		/// <summary>
		/// DAC Field Name: PhtmLevel 
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Phantom Level 
		/// </summary>
		[DataMember(Name="PhantomLevel", EmitDefaultValue=false)]
		public IntValue? PhantomLevel { get; set; }

		/// <summary>
		/// DAC Field Name: PhtmMatlBOMID 
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Phantom Matl BOM ID 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="PhantomMatlBOMID", EmitDefaultValue=false)]
		public StringValue? PhantomMatlBOMID { get; set; }

		/// <summary>
		/// DAC Field Name: PhtmMatlLineRef 
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Phantom Matl Line Nbr 
		/// </summary>
		[DataMember(Name="PhantomMatlLineID", EmitDefaultValue=false)]
		public IntValue? PhantomMatlLineID { get; set; }

		/// <summary>
		/// DAC Field Name: PhtmMatlOperationID 
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Phantom Matl Operation ID 
		/// </summary>
		[DataMember(Name="PhantomMatlOperNbr", EmitDefaultValue=false)]
		public StringValue? PhantomMatlOperNbr { get; set; }

		/// <summary>
		/// DAC Field Name: PhtmMatlRevisionID 
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Phantom Matl Revision 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="PhantomMatlRevision", EmitDefaultValue=false)]
		public StringValue? PhantomMatlRevision { get; set; }

		/// <summary>
		/// DAC Field Name: PhtmPriorLevelQty 
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Phantom Prior Level Qty 
		/// </summary>
		[DataMember(Name="PhantomPriorLevelQty", EmitDefaultValue=false)]
		public DecimalValue? PhantomPriorLevelQty { get; set; }

		/// <summary>
		/// DAC Field Name: EndDate 
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: End Date 
		/// </summary>
		[DataMember(Name="PlanEndDate", EmitDefaultValue=false)]
		public DateTimeValue? PlanEndDate { get; set; }

		/// <summary>
		/// DAC Field Name: StartDate 
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Start Date 
		/// </summary>
		[DataMember(Name="PlanStartDate", EmitDefaultValue=false)]
		public DateTimeValue? PlanStartDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: PO Line Nbr. 
		/// </summary>
		[DataMember(Name="POLineNbr", EmitDefaultValue=false)]
		public IntValue? POLineNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: PO Order Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="POOrderNbr", EmitDefaultValue=false)]
		public StringValue? POOrderNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Qty Complete 
		/// </summary>
		[DataMember(Name="QtyComplete", EmitDefaultValue=false)]
		public DecimalValue? QtyComplete { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Qty Remaining 
		/// </summary>
		[DataMember(Name="QtyRemaining", EmitDefaultValue=false)]
		public DecimalValue? QtyRemaining { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Qty Scrapped 
		/// </summary>
		[DataMember(Name="QtyScrapped", EmitDefaultValue=false)]
		public DecimalValue? QtyScrapped { get; set; }

		/// <summary>
		/// DAC Field Name: QtytoProd 
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Qty to Produce 
		/// </summary>
		[DataMember(Name="QtytoProduce", EmitDefaultValue=false)]
		public DecimalValue? QtytoProduce { get; set; }

		[DataMember(Name="QueueTime", EmitDefaultValue=false)]
		public IntValue? QueueTime { get; set; }

		[DataMember(Name="RunTime", EmitDefaultValue=false)]
		public IntValue? RunTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Run Units 
		/// </summary>
		[DataMember(Name="RunUnits", EmitDefaultValue=false)]
		public DecimalValue? RunUnits { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Scrap Action 
		/// </summary>
		[DataMember(Name="ScrapAction", EmitDefaultValue=false)]
		public StringValue? ScrapAction { get; set; }

		[DataMember(Name="SetupTime", EmitDefaultValue=false)]
		public IntValue? SetupTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Shipped Quantity 
		/// </summary>
		[DataMember(Name="ShippedQuantity", EmitDefaultValue=false)]
		public DecimalValue? ShippedQuantity { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Ship Remaining Qty 
		/// </summary>
		[DataMember(Name="ShipRemainingQty", EmitDefaultValue=false)]
		public DecimalValue? ShipRemainingQty { get; set; }

		[DataMember(Name="Steps", EmitDefaultValue=false)]
		public List<OrderStepDetail>? Steps { get; set; }

		[DataMember(Name="Tools", EmitDefaultValue=false)]
		public List<OrderToolDetail>? Tools { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Total Qty 
		/// </summary>
		[DataMember(Name="TotalQty", EmitDefaultValue=false)]
		public DecimalValue? TotalQty { get; set; }

		/// <summary>
		/// DAC Field Name: VendorID 
		/// DAC: PX.Objects.AM.AMProdOper 
		/// </summary>
		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

		/// <summary>
		/// DAC Field Name: VendorLocationID 
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Vendor Location 
		/// </summary>
		[DataMember(Name="VendorLocation", EmitDefaultValue=false)]
		public StringValue? VendorLocation { get; set; }

		/// <summary>
		/// DAC Field Name: WcID 
		/// DAC: PX.Objects.AM.AMProdOper 
		/// Display Name: Work Center 
		/// SQL Type: nvarchar(20) 
		/// </summary>
		[DataMember(Name="WorkCenter", EmitDefaultValue=false)]
		public StringValue? WorkCenter { get; set; }

	}
}