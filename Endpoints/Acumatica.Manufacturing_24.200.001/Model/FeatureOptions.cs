using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	public class FeatureOptions : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: BFlush</para>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// </summary>
		public BooleanValue? Backflush { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Batch Size</para>
		/// </summary>
		public DecimalValue? BatchSize { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMFeature</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeature</para>
		/// <para>Display Name: Feature ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? FeatureID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Fixed Include</para>
		/// </summary>
		public BooleanValue? FixedInclude { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? Label { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Lot Qty.</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? LotQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Material Type</para>
		/// </summary>
		public StringValue? MaterialType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Max. Qty.</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? MaxQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Min. Qty.</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? MinQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Phantom Routing</para>
		/// </summary>
		public StringValue? PhantomRouting { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Price Factor</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? PriceFactor { get; set; }

		/// <summary>
		/// Flag used for reporting
		/// <para>DAC: PX.Objects.AM.AMFeature</para>
		/// <para>Display Name: Print Results</para>
		/// </summary>
		public BooleanValue? PrintResults { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Enabled Qty.</para>
		/// </summary>
		public BooleanValue? QtyEnabled { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Required Qty.</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? QtyRequired { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Round Qty. Up</para>
		/// </summary>
		public BooleanValue? QtyRoundUp { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Results Copy</para>
		/// </summary>
		public BooleanValue? ResultsCopy { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Scrap Factor</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? ScrapFactor { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>Display Name: Subcontract Source</para>
		/// </summary>
		public StringValue? SubcontractSource { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFeatureOption</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

	}
}