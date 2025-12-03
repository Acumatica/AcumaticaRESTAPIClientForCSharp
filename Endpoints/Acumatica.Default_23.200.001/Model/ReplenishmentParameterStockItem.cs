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
		/// <para>DAC Field Name: ForecastModelType</para>
		/// <para>DAC: PX.Objects.IN.INItemRep</para>
		/// <para>Display Name: Demand Forecast Model</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="DemandForecastModel", EmitDefaultValue=false)]
		public StringValue? DemandForecastModel { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemRep</para>
		/// <para>Display Name: Forecast Period Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="ForecastPeriodType", EmitDefaultValue=false)]
		public StringValue? ForecastPeriodType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemRep</para>
		/// <para>Display Name: Launch Date</para>
		/// </summary>
		[DataMember(Name="LaunchDate", EmitDefaultValue=false)]
		public DateTimeValue? LaunchDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemRep</para>
		/// <para>Display Name: Max Qty.</para>
		/// </summary>
		[DataMember(Name="MaxQty", EmitDefaultValue=false)]
		public DecimalValue? MaxQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MaxShelfLife</para>
		/// <para>DAC: PX.Objects.IN.INItemRep</para>
		/// <para>Display Name: Max. Shelf Life (Days)</para>
		/// </summary>
		[DataMember(Name="MaxShelfLifeInDays", EmitDefaultValue=false)]
		public IntValue? MaxShelfLifeInDays { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReplenishmentMethod</para>
		/// <para>DAC: PX.Objects.IN.INItemRep</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Method", EmitDefaultValue=false)]
		public StringValue? Method { get; set; }

		/// <summary>
		/// <para>DAC Field Name: HistoryDepth</para>
		/// <para>DAC: PX.Objects.IN.INItemRep</para>
		/// <para>Display Name: Periods to Analyze</para>
		/// </summary>
		[DataMember(Name="PeriodsToAnalyze", EmitDefaultValue=false)]
		public IntValue? PeriodsToAnalyze { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MinQty</para>
		/// <para>DAC: PX.Objects.IN.INItemRep</para>
		/// <para>Display Name: Reorder Point</para>
		/// </summary>
		[DataMember(Name="ReorderPoint", EmitDefaultValue=false)]
		public DecimalValue? ReorderPoint { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReplenishmentClassID</para>
		/// <para>DAC: PX.Objects.IN.INItemRep</para>
		/// <para>Display Name: Repl. Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ReplenishmentClass", EmitDefaultValue=false)]
		public StringValue? ReplenishmentClass { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReplenishmentSourceSiteID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Replenishment Warehouse</para>
		/// </summary>
		[DataMember(Name="ReplenishmentWarehouse", EmitDefaultValue=false)]
		public StringValue? ReplenishmentWarehouse { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemRep</para>
		/// <para>Display Name: Safety Stock</para>
		/// </summary>
		[DataMember(Name="SafetyStock", EmitDefaultValue=false)]
		public DecimalValue? SafetyStock { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReplenishmentPolicyID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="Seasonality", EmitDefaultValue=false)]
		public StringValue? Seasonality { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ServiceLevelPct</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Service Level (%)</para>
		/// </summary>
		[DataMember(Name="ServiceLevel", EmitDefaultValue=false)]
		public DecimalValue? ServiceLevel { get; set; }

		/// <summary>
		/// Replenishment source
		/// <para>DAC Field Name: ReplenishmentSource</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Source", EmitDefaultValue=false)]
		public StringValue? Source { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemRep</para>
		/// <para>Display Name: Termination Date</para>
		/// </summary>
		[DataMember(Name="TerminationDate", EmitDefaultValue=false)]
		public DateTimeValue? TerminationDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemRep</para>
		/// <para>Display Name: Transfer ERQ</para>
		/// </summary>
		[DataMember(Name="TransferERQ", EmitDefaultValue=false)]
		public DecimalValue? TransferERQ { get; set; }

	}
}