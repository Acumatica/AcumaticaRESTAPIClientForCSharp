using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class ReplenishmentParameterStockItem : Entity
	{

		/// <summary>
		/// DAC Field Name: ForecastModelType 
		/// DAC: PX.Objects.IN.INItemRep 
		/// Display Name: Demand Forecast Model 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="DemandForecastModel", EmitDefaultValue=false)]
		public StringValue? DemandForecastModel { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INItemRep 
		/// Display Name: Forecast Period Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="ForecastPeriodType", EmitDefaultValue=false)]
		public StringValue? ForecastPeriodType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INItemRep 
		/// Display Name: Launch Date 
		/// </summary>
		[DataMember(Name="LaunchDate", EmitDefaultValue=false)]
		public DateTimeValue? LaunchDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INItemRep 
		/// Display Name: Max Qty. 
		/// </summary>
		[DataMember(Name="MaxQty", EmitDefaultValue=false)]
		public DecimalValue? MaxQty { get; set; }

		/// <summary>
		/// DAC Field Name: MaxShelfLife 
		/// DAC: PX.Objects.IN.INItemRep 
		/// Display Name: Max. Shelf Life (Days) 
		/// </summary>
		[DataMember(Name="MaxShelfLifeInDays", EmitDefaultValue=false)]
		public IntValue? MaxShelfLifeInDays { get; set; }

		/// <summary>
		/// DAC Field Name: ReplenishmentMethod 
		/// DAC: PX.Objects.IN.INItemRep 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Method", EmitDefaultValue=false)]
		public StringValue? Method { get; set; }

		/// <summary>
		/// DAC Field Name: HistoryDepth 
		/// DAC: PX.Objects.IN.INItemRep 
		/// Display Name: Periods to Analyze 
		/// </summary>
		[DataMember(Name="PeriodsToAnalyze", EmitDefaultValue=false)]
		public IntValue? PeriodsToAnalyze { get; set; }

		/// <summary>
		/// DAC Field Name: MinQty 
		/// DAC: PX.Objects.IN.INItemRep 
		/// Display Name: Reorder Point 
		/// </summary>
		[DataMember(Name="ReorderPoint", EmitDefaultValue=false)]
		public DecimalValue? ReorderPoint { get; set; }

		/// <summary>
		/// DAC Field Name: ReplenishmentClassID 
		/// DAC: PX.Objects.IN.INItemRep 
		/// Display Name: Repl. Class 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ReplenishmentClass", EmitDefaultValue=false)]
		public StringValue? ReplenishmentClass { get; set; }

		/// <summary>
		/// DAC Field Name: ReplenishmentSourceSiteID 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Replenishment Warehouse 
		/// </summary>
		[DataMember(Name="ReplenishmentWarehouse", EmitDefaultValue=false)]
		public StringValue? ReplenishmentWarehouse { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INItemRep 
		/// Display Name: Safety Stock 
		/// </summary>
		[DataMember(Name="SafetyStock", EmitDefaultValue=false)]
		public DecimalValue? SafetyStock { get; set; }

		/// <summary>
		/// DAC Field Name: ReplenishmentPolicyID 
		/// DAC: PX.Objects.IN.INItemSite 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="Seasonality", EmitDefaultValue=false)]
		public StringValue? Seasonality { get; set; }

		/// <summary>
		/// DAC Field Name: ServiceLevelPct 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Service Level (%) 
		/// </summary>
		[DataMember(Name="ServiceLevel", EmitDefaultValue=false)]
		public DecimalValue? ServiceLevel { get; set; }

		/// <summary>
		/// Replenishment source
		/// DAC Field Name: ReplenishmentSource 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Source", EmitDefaultValue=false)]
		public StringValue? Source { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INItemRep 
		/// Display Name: Termination Date 
		/// </summary>
		[DataMember(Name="TerminationDate", EmitDefaultValue=false)]
		public DateTimeValue? TerminationDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INItemRep 
		/// Display Name: Transfer ERQ 
		/// </summary>
		[DataMember(Name="TransferERQ", EmitDefaultValue=false)]
		public DecimalValue? TransferERQ { get; set; }

	}
}