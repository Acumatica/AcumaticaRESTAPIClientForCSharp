using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM100000</c> in the Acumatica ERP
	/// </summary>
	public class MRPPreferences : Entity, ITopLevelEntity
	{

		/// <summary>
		/// Exception days afterPreviously AMRPDefaults.EXWin1
		/// <para>DAC Field Name: ExceptionDaysAfter</para>
		/// <para>DAC: PX.Objects.AM.AMRPSetup</para>
		/// <para>Display Name: Days After</para>
		/// </summary>
		public IntValue? DaysAfter { get; set; }

		/// <summary>
		/// Exception days beforePreviously AMRPDefaults.EXWin
		/// <para>DAC Field Name: ExceptionDaysBefore</para>
		/// <para>DAC: PX.Objects.AM.AMRPSetup</para>
		/// <para>Display Name: Days Before</para>
		/// </summary>
		public IntValue? DaysBefore { get; set; }

		/// <summary>
		/// Default MPS Type ID when creating new MPS entires
		/// <para>DAC Field Name: DefaultMPSTypeID</para>
		/// <para>DAC: PX.Objects.AM.AMRPSetup</para>
		/// <para>Display Name: Default Type</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		public StringValue? DefaultType { get; set; }

		/// <summary>
		/// Demand Time Fence (days)
		/// <para>DAC Field Name: ForecastPlanHorizon</para>
		/// <para>DAC: PX.Objects.AM.AMRPSetup</para>
		/// <para>Display Name: Demand Time Fence</para>
		/// </summary>
		public IntValue? DemandTimeFence { get; set; }

		/// <summary>
		/// MRP Grace Period (days)Previously AMRPDefaults.PlnH
		/// <para>DAC: PX.Objects.AM.AMRPSetup</para>
		/// <para>Display Name: Grace Period</para>
		/// </summary>
		public IntValue? GracePeriod { get; set; }

		/// <summary>
		/// Include on hold kit assemblies
		/// <para>DAC: PX.Objects.AM.AMRPSetup</para>
		/// <para>Display Name: Include On-Hold Kit Assemblies</para>
		/// </summary>
		public BooleanValue? IncludeOnHoldKitAssemblies { get; set; }

		/// <summary>
		/// Defines if a production order on hold should be included as supply (Item) and demand (material) in MRP
		/// <para>DAC Field Name: IncludeOnHoldProductionOrder</para>
		/// <para>DAC: PX.Objects.AM.AMRPSetup</para>
		/// <para>Display Name: Include On-Hold Production Orders</para>
		/// </summary>
		public BooleanValue? IncludeOnHoldProductionOrders { get; set; }

		/// <summary>
		/// Defines if a purchase order on hold should be included as Supply in MRP
		/// <para>DAC Field Name: IncludeOnHoldPurchaseOrder</para>
		/// <para>DAC: PX.Objects.AM.AMRPSetup</para>
		/// <para>Display Name: Include On-Hold Purchase Orders</para>
		/// </summary>
		public BooleanValue? IncludeOnHoldPurchaseOrders { get; set; }

		/// <summary>
		/// Defines if a sales order on hold should be included as Demand in MRPPreviously AMRPDefaults.Admin
		/// <para>DAC Field Name: IncludeOnHoldSalesOrder</para>
		/// <para>DAC: PX.Objects.AM.AMRPSetup</para>
		/// <para>Display Name: Include On-Hold Sales Orders</para>
		/// </summary>
		public BooleanValue? IncludeOnHoldSalesOrders { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ForecastNumberingID</para>
		/// <para>DAC: PX.Objects.AM.AMRPSetup</para>
		/// <para>Display Name: Numbering Sequence</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? NumberingSequence { get; set; }

		/// <summary>
		/// Users shall be able to specify how many calendar days into the future all supply/demand records should not be processed.
		/// <para>DAC Field Name: AMPlanningHorizon</para>
		/// <para>DAC: PX.Objects.AM.AMRPSetup</para>
		/// <para>Display Name: Planning Horizon</para>
		/// </summary>
		public IntValue? PlanningHorizon { get; set; }

		/// <summary>
		/// Plan order type
		/// <para>DAC: PX.Objects.AM.AMRPSetup</para>
		/// <para>Display Name: Plan Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? PlanOrderType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPSetup</para>
		/// <para>Display Name: Purchase Calendar ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? PurchaseCalendarID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPSetup</para>
		/// <para>Display Name: Stocking Method</para>
		/// </summary>
		public StringValue? StockingMethod { get; set; }

		/// <summary>
		/// MPS Time Fence (days)
		/// <para>DAC Field Name: MPSFence</para>
		/// <para>DAC: PX.Objects.AM.AMRPSetup</para>
		/// <para>Display Name: MPS Time Fence</para>
		/// </summary>
		public IntValue? TimeFence { get; set; }

		/// <summary>
		/// Flag indicating if the MRP regen process should use fixed manufacturing lead times if checkedPreviously AMRPDefaults.MFGLead
		/// <para>DAC Field Name: UseFixMfgLeadTime</para>
		/// <para>DAC: PX.Objects.AM.AMRPSetup</para>
		/// <para>Display Name: Use Fixed Manufacturing Times</para>
		/// </summary>
		public BooleanValue? UseFixedManufacturingTimes { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}