using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
{
	[DataContract]
	public class ItemWhereUsedRow : Entity
	{

		/// <summary>
		/// The additional parameter that you can use to flexibly set up the required material quantity. The system uses this value to calculate the final quantity of the material.
		/// <para>DAC: PX.Objects.AM.BomWhereUsedDetail</para>
		/// <para>Display Name: Batch Size</para>
		/// </summary>
		[DataMember(Name="BatchSize", EmitDefaultValue=false)]
		public DecimalValue? BatchSize { get; set; }

		/// <summary>
		/// The identifier of the bill of material.
		/// <para>DAC: PX.Objects.AM.BomWhereUsedDetail</para>
		/// <para>Display Name: BOM ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.BomWhereUsedDetail</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.BomWhereUsedFilter</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemClassID</para>
		/// <para>DAC: PX.Objects.AM.BomWhereUsedFilter</para>
		/// <para>Display Name: Item Class</para>
		/// </summary>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.BomWhereUsedDetail</para>
		/// </summary>
		[DataMember(Name="Level", EmitDefaultValue=false)]
		public IntValue? Level { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ParentDescription</para>
		/// <para>DAC: PX.Objects.AM.BomWhereUsedDetail</para>
		/// <para>Display Name: Parent Desc.</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="ParentDesc", EmitDefaultValue=false)]
		public StringValue? ParentDesc { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.BomWhereUsedDetail</para>
		/// <para>Display Name: Parent Inventory ID</para>
		/// </summary>
		[DataMember(Name="ParentInventoryID", EmitDefaultValue=false)]
		public StringValue? ParentInventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ParentItemClassID</para>
		/// <para>DAC: PX.Objects.AM.BomWhereUsedDetail</para>
		/// <para>Display Name: Parent Item Class</para>
		/// </summary>
		[DataMember(Name="ParentItemClass", EmitDefaultValue=false)]
		public StringValue? ParentItemClass { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ParentSubItemID</para>
		/// <para>DAC: PX.Objects.AM.BomWhereUsedDetail</para>
		/// <para>Display Name: Parent Subitem</para>
		/// </summary>
		[DataMember(Name="ParentSubitem", EmitDefaultValue=false)]
		public StringValue? ParentSubitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.BomWhereUsedDetail</para>
		/// <para>Display Name: Required Qty.</para>
		/// </summary>
		[DataMember(Name="QtyRequired", EmitDefaultValue=false)]
		public DecimalValue? QtyRequired { get; set; }

		/// <summary>
		/// The identifier of the BOM revision, which is the modification of the bill of material.
		/// <para>DAC Field Name: RevisionID</para>
		/// <para>DAC: PX.Objects.AM.BomWhereUsedDetail</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		/// <summary>
		/// Keep track of the records being inserted into the rows for display/sort order
		/// <para>DAC: PX.Objects.AM.BomWhereUsedDetail</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="Sequence", EmitDefaultValue=false)]
		public IntValue? Sequence { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.BomWhereUsedDetail</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="Source", EmitDefaultValue=false)]
		public StringValue? Source { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the material is a stock item.
		/// <para>DAC Field Name: IsStockItem</para>
		/// <para>DAC: PX.Objects.AM.BomWhereUsedDetail</para>
		/// <para>Display Name: Stock</para>
		/// </summary>
		[DataMember(Name="StockItem", EmitDefaultValue=false)]
		public BooleanValue? StockItem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.BomWhereUsedFilter</para>
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// The unit of measure for the quantity specified in QtyReq.
		/// <para>DAC: PX.Objects.AM.BomWhereUsedDetail</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.BomWhereUsedFilter</para>
		/// <para>Display Name: BOM Warehouse</para>
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}