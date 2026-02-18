using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class EstimateTotal : Entity
	{

		/// <summary>
		/// Identifier of the base Currency.
		/// <para>DAC Field Name: BaseCuryID</para>
		/// <para>DAC: PX.Objects.CM.CurrencyInfo</para>
		/// <para>Display Name: Base Currency ID</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		public StringValue? BaseCurrencyID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		public StringValue? Currency { get; set; }

		/// <summary>
		/// The read-only property providing the Currency for display in the User Interface.
		/// <para>DAC Field Name: DisplayCuryID</para>
		/// <para>DAC: PX.Objects.CM.CurrencyInfo</para>
		/// <para>Display Name: Currency ID</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// The exchange rate used for calculations and determined by the values ofthe CuryMultDiv, CuryRate and RecipRate fields.
		/// <para>DAC Field Name: SampleCuryRate</para>
		/// <para>DAC: PX.Objects.CM.CurrencyInfo</para>
		/// <para>Display Name: Curr. Rate</para>
		/// </summary>
		public DecimalValue? CurrRate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// </summary>
		public BooleanValue? CuryViewState { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Labor Markup (%)</para>
		/// </summary>
		public DecimalValue? LaborMarkupPct { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Machine Markup (%)</para>
		/// </summary>
		public DecimalValue? MachineMarkupPct { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Material Markup (%)</para>
		/// </summary>
		public DecimalValue? MaterialMarkupPct { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Order Qty.</para>
		/// </summary>
		public DecimalValue? OrderQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MarkupPct</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Overall Markup (%)</para>
		/// </summary>
		public DecimalValue? OverallMarkupPct { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Overhead Markup (%)</para>
		/// </summary>
		public DecimalValue? OverheadMarkupPct { get; set; }

		/// <summary>
		/// The inverse of the SampleCuryRate. This value is also determined by the values ofthe CuryMultDiv, CuryRate and RecipRate fields.
		/// <para>DAC Field Name: SampleRecipRate</para>
		/// <para>DAC: PX.Objects.CM.CurrencyInfo</para>
		/// <para>Display Name: Reciprocal Rate</para>
		/// </summary>
		public DecimalValue? ReciprocalRate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Subcontract Markup (%)</para>
		/// </summary>
		public DecimalValue? SubcontractMarkupPct { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Tool Markup (%)</para>
		/// </summary>
		public DecimalValue? ToolMarkupPct { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryExtCost</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Total Cost</para>
		/// </summary>
		public DecimalValue? TotalCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryExtPrice</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Total Price</para>
		/// </summary>
		public DecimalValue? TotalPrice { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryUnitCost</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Unit Cost</para>
		/// </summary>
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryUnitPrice</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Unit Price</para>
		/// </summary>
		public DecimalValue? UnitPrice { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PriceOverride</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Override Unit Price</para>
		/// </summary>
		public BooleanValue? UnitPriceOverride { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

	}
}