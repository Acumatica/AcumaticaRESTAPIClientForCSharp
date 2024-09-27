using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	[DataContract]
	public class RoughCutPlanningDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: AMProdItem__BranchID 
		/// DAC: PX.Objects.AM.AMSchdItem 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// DAC Field Name: ConstDate 
		/// DAC: PX.Objects.AM.AMSchdItem 
		/// </summary>
		[DataMember(Name="Constraint", EmitDefaultValue=false)]
		public DateTimeValue? Constraint { get; set; }

		/// <summary>
		/// DAC Field Name: AMProdItem__CustomerID 
		/// DAC: PX.Objects.AM.AMSchdItem 
		/// </summary>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		/// <summary>
		/// DAC Field Name: InventoryID_description 
		/// DAC: PX.Objects.AM.AMSchdItem 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: SchPriority 
		/// DAC: PX.Objects.AM.AMSchdItem 
		/// Display Name: Dispatch Priority 
		/// </summary>
		[DataMember(Name="DispatchPriority", EmitDefaultValue=false)]
		public ShortValue? DispatchPriority { get; set; }

		/// <summary>
		/// DAC Field Name: EndDate_Date 
		/// DAC: PX.Objects.AM.AMSchdItem 
		/// </summary>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// DAC Field Name: EndDate_Time 
		/// DAC: PX.Objects.AM.AMSchdItem 
		/// </summary>
		[DataMember(Name="EndTime", EmitDefaultValue=false)]
		public DateTimeValue? EndTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMSchdItem 
		/// Display Name: Firm Schedule 
		/// </summary>
		[DataMember(Name="FirmSchedule", EmitDefaultValue=false)]
		public BooleanValue? FirmSchedule { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMSchdItem 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: AMProdItem__ProdDate 
		/// DAC: PX.Objects.AM.AMSchdItem 
		/// </summary>
		[DataMember(Name="OrderDate", EmitDefaultValue=false)]
		public DateTimeValue? OrderDate { get; set; }

		/// <summary>
		/// DAC Field Name: AMProdItem__Descr 
		/// DAC: PX.Objects.AM.AMSchdItem 
		/// </summary>
		[DataMember(Name="OrderDescription", EmitDefaultValue=false)]
		public StringValue? OrderDescription { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMSchdItem 
		/// Display Name: Order Type 
		/// SQL Type: char(2) 
		/// Key Field
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// DAC Field Name: ProdOrdID 
		/// DAC: PX.Objects.AM.AMSchdItem 
		/// Display Name: Production Nbr. 
		/// SQL Type: nvarchar(19) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMSchdItem 
		/// Display Name: Qty Remaining 
		/// </summary>
		[DataMember(Name="QtyRemaining", EmitDefaultValue=false)]
		public DecimalValue? QtyRemaining { get; set; }

		/// <summary>
		/// Order Base Unit Qty to Produce
		/// DAC Field Name: QtytoProd 
		/// DAC: PX.Objects.AM.AMSchdItem 
		/// Display Name: Qty to Produce 
		/// </summary>
		[DataMember(Name="QtytoProduce", EmitDefaultValue=false)]
		public DecimalValue? QtytoProduce { get; set; }

		/// <summary>
		/// DAC Field Name: SchdID 
		/// DAC: PX.Objects.AM.AMSchdItem 
		/// Display Name: Schedule ID 
		/// Key Field
		/// </summary>
		[DataMember(Name="ScheduleID", EmitDefaultValue=false)]
		public IntValue? ScheduleID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMSchdItem 
		/// Display Name: Schedule Status 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="ScheduleStatus", EmitDefaultValue=false)]
		public StringValue? ScheduleStatus { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMSchdItem 
		/// Display Name: Scheduling Method 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="SchedulingMethod", EmitDefaultValue=false)]
		public StringValue? SchedulingMethod { get; set; }

		/// <summary>
		/// Specifies (if set to true) that a user has selected the record in the table on the form for processing.
		/// DAC: PX.Objects.AM.AMSchdItem 
		/// </summary>
		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// DAC Field Name: AMProdItem__OrdNbr 
		/// DAC: PX.Objects.AM.AMSchdItem 
		/// </summary>
		[DataMember(Name="SOOrderNbr", EmitDefaultValue=false)]
		public StringValue? SOOrderNbr { get; set; }

		/// <summary>
		/// DAC Field Name: StartDate_Date 
		/// DAC: PX.Objects.AM.AMSchdItem 
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// DAC Field Name: StartDate_Time 
		/// DAC: PX.Objects.AM.AMSchdItem 
		/// </summary>
		[DataMember(Name="StartTime", EmitDefaultValue=false)]
		public DateTimeValue? StartTime { get; set; }

		/// <summary>
		/// DAC Field Name: AMProdItem__StatusID 
		/// DAC: PX.Objects.AM.AMSchdItem 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// DAC Field Name: AMProdItem__UOM 
		/// DAC: PX.Objects.AM.AMSchdItem 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMSchdItem 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}