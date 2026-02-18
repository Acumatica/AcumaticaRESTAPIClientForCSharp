using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class EstimateMaterialDetail : Entity
	{

		/// <summary>
		/// Determine whether user need to release material manually or not 
		/// <para>DAC Field Name: BackFlush</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Backflush Materials</para>
		/// </summary>
		public BooleanValue? Backflush { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Batch Size</para>
		/// </summary>
		public DecimalValue? BatchSize { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemDesc</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryCD</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Inventory ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemClassID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Item Class</para>
		/// </summary>
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LineID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		public IntValue? LineNbr { get; set; }

		public IntValue? LineOrder { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Material Type</para>
		/// </summary>
		public StringValue? MaterialType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsNonInventory</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Non-Inventory</para>
		/// </summary>
		public BooleanValue? NonInventory { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Phantom Routing</para>
		/// </summary>
		public StringValue? PhantomRouting { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyReq</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Required Qty.</para>
		/// </summary>
		public DecimalValue? QtyRequired { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Round Qty. Up</para>
		/// </summary>
		public BooleanValue? QtyRoundUp { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Scrap Factor</para>
		/// </summary>
		public DecimalValue? ScrapFactor { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Subcontract Source</para>
		/// </summary>
		public StringValue? SubcontractSource { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MaterialOperCost</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Total Cost</para>
		/// </summary>
		public DecimalValue? TotalCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TotalQtyRequired</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Total Required</para>
		/// </summary>
		public DecimalValue? TotalRequired { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Unit Cost</para>
		/// </summary>
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

	}
}