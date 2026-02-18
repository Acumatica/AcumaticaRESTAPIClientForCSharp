using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	public class ItemWhereUsedRow : Entity
	{

		/// <summary>
		/// The additional parameter that you can use to flexibly set up the required material quantity. The system uses this value to calculate the final quantity of the material.
		/// <para>DAC: PX.Objects.AM.BomWhereUsedDetail</para>
		/// <para>Display Name: Batch Size</para>
		/// </summary>
		public DecimalValue? BatchSize { get; set; }

		/// <summary>
		/// The identifier of the bill of material.
		/// <para>DAC: PX.Objects.AM.BomWhereUsedDetail</para>
		/// <para>Display Name: BOM ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.BomWhereUsedDetail</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.BomWhereUsedFilter</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemClassID</para>
		/// <para>DAC: PX.Objects.AM.BomWhereUsedFilter</para>
		/// <para>Display Name: Item Class</para>
		/// </summary>
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.BomWhereUsedDetail</para>
		/// </summary>
		public IntValue? Level { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ParentDescription</para>
		/// <para>DAC: PX.Objects.AM.BomWhereUsedDetail</para>
		/// <para>Display Name: Parent Desc.</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? ParentDesc { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.BomWhereUsedDetail</para>
		/// <para>Display Name: Parent Inventory ID</para>
		/// </summary>
		public StringValue? ParentInventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ParentItemClassID</para>
		/// <para>DAC: PX.Objects.AM.BomWhereUsedDetail</para>
		/// <para>Display Name: Parent Item Class</para>
		/// </summary>
		public StringValue? ParentItemClass { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ParentSubItemID</para>
		/// <para>DAC: PX.Objects.AM.BomWhereUsedDetail</para>
		/// <para>Display Name: Parent Subitem</para>
		/// </summary>
		public StringValue? ParentSubitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.BomWhereUsedDetail</para>
		/// <para>Display Name: Required Qty.</para>
		/// </summary>
		public DecimalValue? QtyRequired { get; set; }

		/// <summary>
		/// The identifier of the BOM revision, which is the modification of the bill of material.
		/// <para>DAC Field Name: RevisionID</para>
		/// <para>DAC: PX.Objects.AM.BomWhereUsedDetail</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? Revision { get; set; }

		/// <summary>
		/// Keep track of the records being inserted into the rows for display/sort order
		/// <para>DAC: PX.Objects.AM.BomWhereUsedDetail</para>
		/// Key Field
		/// </summary>
		public IntValue? Sequence { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.BomWhereUsedDetail</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? Source { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the material is a stock item.
		/// <para>DAC Field Name: IsStockItem</para>
		/// <para>DAC: PX.Objects.AM.BomWhereUsedDetail</para>
		/// <para>Display Name: Stock</para>
		/// </summary>
		public BooleanValue? StockItem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.BomWhereUsedFilter</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// The unit of measure for the quantity specified in QtyReq.
		/// <para>DAC: PX.Objects.AM.BomWhereUsedDetail</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.BomWhereUsedFilter</para>
		/// <para>Display Name: BOM Warehouse</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

	}
}