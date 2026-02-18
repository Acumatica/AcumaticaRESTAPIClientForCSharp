using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class ReplenishmentParameterStockItem : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: ForecastModelType</para>
		/// <para>DAC: PX.Objects.IN.INItemRep</para>
		/// <para>Display Name: Demand Forecast Model</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? DemandForecastModel { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemRep</para>
		/// <para>Display Name: Forecast Period Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? ForecastPeriodType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemRep</para>
		/// <para>Display Name: Launch Date</para>
		/// </summary>
		public DateTimeValue? LaunchDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemRep</para>
		/// <para>Display Name: Max Qty.</para>
		/// </summary>
		public DecimalValue? MaxQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MaxShelfLife</para>
		/// <para>DAC: PX.Objects.IN.INItemRep</para>
		/// <para>Display Name: Max. Shelf Life (Days)</para>
		/// </summary>
		public IntValue? MaxShelfLifeInDays { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReplenishmentMethod</para>
		/// <para>DAC: PX.Objects.IN.INItemRep</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Method { get; set; }

		/// <summary>
		/// <para>DAC Field Name: HistoryDepth</para>
		/// <para>DAC: PX.Objects.IN.INItemRep</para>
		/// <para>Display Name: Periods to Analyze</para>
		/// </summary>
		public IntValue? PeriodsToAnalyze { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MinQty</para>
		/// <para>DAC: PX.Objects.IN.INItemRep</para>
		/// <para>Display Name: Reorder Point</para>
		/// </summary>
		public DecimalValue? ReorderPoint { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReplenishmentClassID</para>
		/// <para>DAC: PX.Objects.IN.INItemRep</para>
		/// <para>Display Name: Repl. Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? ReplenishmentClass { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReplenishmentSourceSiteID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Replenishment Warehouse</para>
		/// </summary>
		public StringValue? ReplenishmentWarehouse { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemRep</para>
		/// <para>Display Name: Safety Stock</para>
		/// </summary>
		public DecimalValue? SafetyStock { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReplenishmentPolicyID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? Seasonality { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ServiceLevelPct</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Service Level (%)</para>
		/// </summary>
		public DecimalValue? ServiceLevel { get; set; }

		/// <summary>
		/// Replenishment source
		/// <para>DAC Field Name: ReplenishmentSource</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Source { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemRep</para>
		/// <para>Display Name: Termination Date</para>
		/// </summary>
		public DateTimeValue? TerminationDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemRep</para>
		/// <para>Display Name: Transfer ERQ</para>
		/// </summary>
		public DecimalValue? TransferERQ { get; set; }

	}
}