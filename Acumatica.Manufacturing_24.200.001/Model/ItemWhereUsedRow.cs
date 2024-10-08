using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	[DataContract]
	public class ItemWhereUsedRow : Entity
	{

		/// <summary>
		/// The additional parameter that you can use to flexibly set up the required material quantity. The system uses this value to calculate the final quantity of the material.
		/// DAC: PX.Objects.AM.BomWhereUsedDetail 
		/// Display Name: Batch Size 
		/// </summary>
		[DataMember(Name="BatchSize", EmitDefaultValue=false)]
		public DecimalValue? BatchSize { get; set; }

		/// <summary>
		/// The identifier of the bill of material.
		/// DAC: PX.Objects.AM.BomWhereUsedDetail 
		/// Display Name: BOM ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.BomWhereUsedDetail 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.BomWhereUsedFilter 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: ItemClassID 
		/// DAC: PX.Objects.AM.BomWhereUsedFilter 
		/// Display Name: Item Class 
		/// </summary>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.BomWhereUsedDetail 
		/// </summary>
		[DataMember(Name="Level", EmitDefaultValue=false)]
		public IntValue? Level { get; set; }

		/// <summary>
		/// DAC Field Name: ParentDescription 
		/// DAC: PX.Objects.AM.BomWhereUsedDetail 
		/// Display Name: Parent Desc. 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="ParentDesc", EmitDefaultValue=false)]
		public StringValue? ParentDesc { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.BomWhereUsedDetail 
		/// Display Name: Parent Inventory ID 
		/// </summary>
		[DataMember(Name="ParentInventoryID", EmitDefaultValue=false)]
		public StringValue? ParentInventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: ParentItemClassID 
		/// DAC: PX.Objects.AM.BomWhereUsedDetail 
		/// Display Name: Parent Item Class 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="ParentItemClass", EmitDefaultValue=false)]
		public StringValue? ParentItemClass { get; set; }

		/// <summary>
		/// DAC Field Name: ParentSubItemID 
		/// DAC: PX.Objects.AM.BomWhereUsedDetail 
		/// Display Name: Parent Subitem 
		/// </summary>
		[DataMember(Name="ParentSubitem", EmitDefaultValue=false)]
		public StringValue? ParentSubitem { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.BomWhereUsedDetail 
		/// Display Name: Qty Required 
		/// </summary>
		[DataMember(Name="QtyRequired", EmitDefaultValue=false)]
		public DecimalValue? QtyRequired { get; set; }

		/// <summary>
		/// The identifier of the BOM revision, which is the modification of the bill of material.
		/// DAC Field Name: RevisionID 
		/// DAC: PX.Objects.AM.BomWhereUsedDetail 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		/// <summary>
		/// Keep track of the records being inserted into the rows for display/sort order
		/// DAC: PX.Objects.AM.BomWhereUsedDetail 
		/// Key Field
		/// </summary>
		[DataMember(Name="Sequence", EmitDefaultValue=false)]
		public IntValue? Sequence { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.BomWhereUsedDetail 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="Source", EmitDefaultValue=false)]
		public StringValue? Source { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the material is a stock item.
		/// DAC Field Name: IsStockItem 
		/// DAC: PX.Objects.AM.BomWhereUsedDetail 
		/// Display Name: Is stock 
		/// </summary>
		[DataMember(Name="StockItem", EmitDefaultValue=false)]
		public BooleanValue? StockItem { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.BomWhereUsedFilter 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// The unit of measure for the quantity specified in QtyReq.
		/// DAC: PX.Objects.AM.BomWhereUsedDetail 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.BomWhereUsedFilter 
		/// Display Name: BOM Warehouse 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}