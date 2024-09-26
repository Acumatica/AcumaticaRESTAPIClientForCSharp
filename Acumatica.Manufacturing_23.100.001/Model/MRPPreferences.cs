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
	/// Corresponds to the screen AM100000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class MRPPreferences : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ExceptionDaysAfter 
		/// DAC: PX.Objects.AM.AMRPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DaysAfter", EmitDefaultValue=false)]
		public IntValue? DaysAfter { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ExceptionDaysBefore 
		/// DAC: PX.Objects.AM.AMRPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DaysBefore", EmitDefaultValue=false)]
		public IntValue? DaysBefore { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DefaultMPSTypeID 
		/// DAC: PX.Objects.AM.AMRPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultType", EmitDefaultValue=false)]
		public StringValue? DefaultType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ForecastPlanHorizon 
		/// DAC: PX.Objects.AM.AMRPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DemandTimeFence", EmitDefaultValue=false)]
		public IntValue? DemandTimeFence { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: GracePeriod 
		/// DAC: PX.Objects.AM.AMRPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="GracePeriod", EmitDefaultValue=false)]
		public IntValue? GracePeriod { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IncludeOnHoldProductionOrder 
		/// DAC: PX.Objects.AM.AMRPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="IncludeOnHoldProductionOrders", EmitDefaultValue=false)]
		public BooleanValue? IncludeOnHoldProductionOrders { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IncludeOnHoldPurchaseOrder 
		/// DAC: PX.Objects.AM.AMRPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="IncludeOnHoldPurchaseOrders", EmitDefaultValue=false)]
		public BooleanValue? IncludeOnHoldPurchaseOrders { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IncludeOnHoldSalesOrder 
		/// DAC: PX.Objects.AM.AMRPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="IncludeOnHoldSalesOrders", EmitDefaultValue=false)]
		public BooleanValue? IncludeOnHoldSalesOrders { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ForecastNumberingID 
		/// DAC: PX.Objects.AM.AMRPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="NumberingSequence", EmitDefaultValue=false)]
		public StringValue? NumberingSequence { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PlanOrderType 
		/// DAC: PX.Objects.AM.AMRPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PlanOrderType", EmitDefaultValue=false)]
		public StringValue? PlanOrderType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PurchaseCalendarID 
		/// DAC: PX.Objects.AM.AMRPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PurchaseCalendarID", EmitDefaultValue=false)]
		public StringValue? PurchaseCalendarID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StockingMethod 
		/// DAC: PX.Objects.AM.AMRPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="StockingMethod", EmitDefaultValue=false)]
		public StringValue? StockingMethod { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MPSFence 
		/// DAC: PX.Objects.AM.AMRPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TimeFence", EmitDefaultValue=false)]
		public IntValue? TimeFence { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UseFixMfgLeadTime 
		/// DAC: PX.Objects.AM.AMRPSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UseFixedManufacturingTimes", EmitDefaultValue=false)]
		public BooleanValue? UseFixedManufacturingTimes { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.100.001";
		}
	}
}