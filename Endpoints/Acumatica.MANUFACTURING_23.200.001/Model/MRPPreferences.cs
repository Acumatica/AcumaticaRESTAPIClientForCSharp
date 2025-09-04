using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM100000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class MRPPreferences : Entity, ITopLevelEntity
	{

		/// <summary>
		/// Exception days afterPreviously AMRPDefaults.EXWin1
		/// DAC Field Name: ExceptionDaysAfter 
		/// DAC: PX.Objects.AM.AMRPSetup 
		/// Display Name: Days After 
		/// </summary>
		[DataMember(Name="DaysAfter", EmitDefaultValue=false)]
		public IntValue? DaysAfter { get; set; }

		/// <summary>
		/// Exception days beforePreviously AMRPDefaults.EXWin
		/// DAC Field Name: ExceptionDaysBefore 
		/// DAC: PX.Objects.AM.AMRPSetup 
		/// Display Name: Days Before 
		/// </summary>
		[DataMember(Name="DaysBefore", EmitDefaultValue=false)]
		public IntValue? DaysBefore { get; set; }

		/// <summary>
		/// Default MPS Type ID when creating new MPS entires
		/// DAC Field Name: DefaultMPSTypeID 
		/// DAC: PX.Objects.AM.AMRPSetup 
		/// Display Name: Default Type 
		/// SQL Type: nvarchar(20) 
		/// </summary>
		[DataMember(Name="DefaultType", EmitDefaultValue=false)]
		public StringValue? DefaultType { get; set; }

		/// <summary>
		/// Demand Time Fence (days)
		/// DAC Field Name: ForecastPlanHorizon 
		/// DAC: PX.Objects.AM.AMRPSetup 
		/// Display Name: Demand Time Fence 
		/// </summary>
		[DataMember(Name="DemandTimeFence", EmitDefaultValue=false)]
		public IntValue? DemandTimeFence { get; set; }

		/// <summary>
		/// MRP Grace Period (days)Previously AMRPDefaults.PlnH
		/// DAC: PX.Objects.AM.AMRPSetup 
		/// Display Name: Grace Period 
		/// </summary>
		[DataMember(Name="GracePeriod", EmitDefaultValue=false)]
		public IntValue? GracePeriod { get; set; }

		/// <summary>
		/// Defines if a production order on hold should be included as supply (Item) and demand (material) in MRP
		/// DAC Field Name: IncludeOnHoldProductionOrder 
		/// DAC: PX.Objects.AM.AMRPSetup 
		/// Display Name: Include On-Hold Production Orders 
		/// </summary>
		[DataMember(Name="IncludeOnHoldProductionOrders", EmitDefaultValue=false)]
		public BooleanValue? IncludeOnHoldProductionOrders { get; set; }

		/// <summary>
		/// Defines if a purchase order on hold should be included as Supply in MRP
		/// DAC Field Name: IncludeOnHoldPurchaseOrder 
		/// DAC: PX.Objects.AM.AMRPSetup 
		/// Display Name: Include On-Hold Purchase Orders 
		/// </summary>
		[DataMember(Name="IncludeOnHoldPurchaseOrders", EmitDefaultValue=false)]
		public BooleanValue? IncludeOnHoldPurchaseOrders { get; set; }

		/// <summary>
		/// Defines if a sales order on hold should be included as Demand in MRPPreviously AMRPDefaults.Admin
		/// DAC Field Name: IncludeOnHoldSalesOrder 
		/// DAC: PX.Objects.AM.AMRPSetup 
		/// Display Name: Include On-Hold Sales Orders 
		/// </summary>
		[DataMember(Name="IncludeOnHoldSalesOrders", EmitDefaultValue=false)]
		public BooleanValue? IncludeOnHoldSalesOrders { get; set; }

		/// <summary>
		/// DAC Field Name: ForecastNumberingID 
		/// DAC: PX.Objects.AM.AMRPSetup 
		/// Display Name: Numbering Sequence 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="NumberingSequence", EmitDefaultValue=false)]
		public StringValue? NumberingSequence { get; set; }

		/// <summary>
		/// Plan order type
		/// DAC: PX.Objects.AM.AMRPSetup 
		/// Display Name: Plan Order Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="PlanOrderType", EmitDefaultValue=false)]
		public StringValue? PlanOrderType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMRPSetup 
		/// Display Name: Purchase Calendar ID 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="PurchaseCalendarID", EmitDefaultValue=false)]
		public StringValue? PurchaseCalendarID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMRPSetup 
		/// Display Name: Stocking Method 
		/// </summary>
		[DataMember(Name="StockingMethod", EmitDefaultValue=false)]
		public StringValue? StockingMethod { get; set; }

		/// <summary>
		/// MPS Time Fence (days)
		/// DAC Field Name: MPSFence 
		/// DAC: PX.Objects.AM.AMRPSetup 
		/// Display Name: MPS Time Fence 
		/// </summary>
		[DataMember(Name="TimeFence", EmitDefaultValue=false)]
		public IntValue? TimeFence { get; set; }

		/// <summary>
		/// Flag indicating if the MRP regen process should use fixed manufacturing lead times if checkedPreviously AMRPDefaults.MFGLead
		/// DAC Field Name: UseFixMfgLeadTime 
		/// DAC: PX.Objects.AM.AMRPSetup 
		/// Display Name: Use Fixed Manufacturing Times 
		/// </summary>
		[DataMember(Name="UseFixedManufacturingTimes", EmitDefaultValue=false)]
		public BooleanValue? UseFixedManufacturingTimes { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}