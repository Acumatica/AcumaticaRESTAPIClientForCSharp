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
	public class RoughCutPlanningDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: AMProdItem__BranchID</para>
		/// <para>DAC: PX.Objects.AM.AMSchdItem</para>
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ConstDate</para>
		/// <para>DAC: PX.Objects.AM.AMSchdItem</para>
		/// </summary>
		[DataMember(Name="Constraint", EmitDefaultValue=false)]
		public DateTimeValue? Constraint { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMProdItem__CustomerID</para>
		/// <para>DAC: PX.Objects.AM.AMSchdItem</para>
		/// </summary>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryID_description</para>
		/// <para>DAC: PX.Objects.AM.AMSchdItem</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SchPriority</para>
		/// <para>DAC: PX.Objects.AM.AMSchdItem</para>
		/// <para>Display Name: Dispatch Priority</para>
		/// </summary>
		[DataMember(Name="DispatchPriority", EmitDefaultValue=false)]
		public ShortValue? DispatchPriority { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EndDate_Date</para>
		/// <para>DAC: PX.Objects.AM.AMSchdItem</para>
		/// </summary>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EndDate_Time</para>
		/// <para>DAC: PX.Objects.AM.AMSchdItem</para>
		/// </summary>
		[DataMember(Name="EndTime", EmitDefaultValue=false)]
		public DateTimeValue? EndTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMSchdItem</para>
		/// <para>Display Name: Firm Schedule</para>
		/// </summary>
		[DataMember(Name="FirmSchedule", EmitDefaultValue=false)]
		public BooleanValue? FirmSchedule { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMSchdItem</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMProdItem__ProdDate</para>
		/// <para>DAC: PX.Objects.AM.AMSchdItem</para>
		/// </summary>
		[DataMember(Name="OrderDate", EmitDefaultValue=false)]
		public DateTimeValue? OrderDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMProdItem__Descr</para>
		/// <para>DAC: PX.Objects.AM.AMSchdItem</para>
		/// </summary>
		[DataMember(Name="OrderDescription", EmitDefaultValue=false)]
		public StringValue? OrderDescription { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMSchdItem</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.AMSchdItem</para>
		/// <para>Display Name: Production Nbr.</para>
		/// <para>SQL Type: nvarchar(19)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMSchdItem</para>
		/// <para>Display Name: Qty Remaining</para>
		/// </summary>
		[DataMember(Name="QtyRemaining", EmitDefaultValue=false)]
		public DecimalValue? QtyRemaining { get; set; }

		/// <summary>
		/// Order Base Unit Qty to Produce
		/// <para>DAC Field Name: QtytoProd</para>
		/// <para>DAC: PX.Objects.AM.AMSchdItem</para>
		/// <para>Display Name: Qty to Produce</para>
		/// </summary>
		[DataMember(Name="QtytoProduce", EmitDefaultValue=false)]
		public DecimalValue? QtytoProduce { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SchdID</para>
		/// <para>DAC: PX.Objects.AM.AMSchdItem</para>
		/// <para>Display Name: Schedule ID</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ScheduleID", EmitDefaultValue=false)]
		public IntValue? ScheduleID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMSchdItem</para>
		/// <para>Display Name: Schedule Status</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="ScheduleStatus", EmitDefaultValue=false)]
		public StringValue? ScheduleStatus { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMSchdItem</para>
		/// <para>Display Name: Scheduling Method</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="SchedulingMethod", EmitDefaultValue=false)]
		public StringValue? SchedulingMethod { get; set; }

		/// <summary>
		/// Specifies (if set to true) that a user has selected the record in the table on the form for processing.
		/// <para>DAC: PX.Objects.AM.AMSchdItem</para>
		/// </summary>
		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMProdItem__OrdNbr</para>
		/// <para>DAC: PX.Objects.AM.AMSchdItem</para>
		/// </summary>
		[DataMember(Name="SOOrderNbr", EmitDefaultValue=false)]
		public StringValue? SOOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StartDate_Date</para>
		/// <para>DAC: PX.Objects.AM.AMSchdItem</para>
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StartDate_Time</para>
		/// <para>DAC: PX.Objects.AM.AMSchdItem</para>
		/// </summary>
		[DataMember(Name="StartTime", EmitDefaultValue=false)]
		public DateTimeValue? StartTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMProdItem__StatusID</para>
		/// <para>DAC: PX.Objects.AM.AMSchdItem</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMProdItem__UOM</para>
		/// <para>DAC: PX.Objects.AM.AMSchdItem</para>
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMSchdItem</para>
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}