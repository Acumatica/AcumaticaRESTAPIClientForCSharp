using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen IN203000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class TemplateItems : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The Unit of Measure used as the sales unit for the Inventory Item.This field can be changed only if the Multiple Units of Measure feature is enabled.Otherwise, the sales unit is assumed to be the same as the Base Unit.
		/// DAC Field Name: SalesUnit 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Sales Unit 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="SalesUOM", EmitDefaultValue=false)]
		public StringValue? SalesUOM { get; set; }

		/// <summary>
		/// The manufacturer's suggested retail price of the item.
		/// DAC Field Name: RecPrice 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// Display Name: MSRP 
		/// </summary>
		[DataMember(Name="CurySpecificMSRP", EmitDefaultValue=false)]
		public DecimalValue? CurySpecificMSRP { get; set; }

		/// <summary>
		/// The price used as the default price, if there are no other prices defined for this item in any price list in the Accounts Receivable module.
		/// DAC Field Name: BasePrice 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// Display Name: Default Price 
		/// </summary>
		[DataMember(Name="CurySpecificPrice", EmitDefaultValue=false)]
		public DecimalValue? CurySpecificPrice { get; set; }

		/// <summary>
		/// The identifier of the Item Class, to which the Inventory Item belongs.Item Classes provide default settings for items, which belong to them, and are used to group items.
		/// DAC Field Name: ItemClassID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Item Class 
		/// </summary>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventoryItem 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Availability", EmitDefaultValue=false)]
		public StringValue? Availability { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// The Unit of Measure used as the base unit for the Inventory Item.
		/// DAC Field Name: BaseUnit 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Base Unit 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="BaseUOM", EmitDefaultValue=false)]
		public StringValue? BaseUOM { get; set; }

		[DataMember(Name="Categories", EmitDefaultValue=false)]
		public List<CategoryStockItem>? Categories { get; set; }

		/// <summary>
		/// Rich text description of the item.
		/// DAC Field Name: Body 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="Content", EmitDefaultValue=false)]
		public StringValue? Content { get; set; }

		/// <summary>
		/// The current standard cost of the item.
		/// DAC Field Name: StdCost 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// Display Name: Current Cost 
		/// </summary>
		[DataMember(Name="CurrentStdCost", EmitDefaultValue=false)]
		public DecimalValue? CurrentStdCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		[DataMember(Name="CustomURL", EmitDefaultValue=false)]
		public StringValue? CustomURL { get; set; }

		[DataMember(Name="DefaultIssueLocationID", EmitDefaultValue=false)]
		public StringValue? DefaultIssueLocationID { get; set; }

		/// <summary>
		/// The price used as the default price, if there are no other prices defined for this item in any price list in the Accounts Receivable module.
		/// DAC Field Name: BasePrice 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// Display Name: Default Price 
		/// </summary>
		[DataMember(Name="DefaultPrice", EmitDefaultValue=false)]
		public DecimalValue? DefaultPrice { get; set; }

		/// <summary>
		/// The description of the Inventory Item.
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The weight of the Base Unit of the item.
		/// DAC Field Name: BaseItemWeight 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Weight 
		/// </summary>
		[DataMember(Name="DimensionWeight", EmitDefaultValue=false)]
		public DecimalValue? DimensionWeight { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Export to External System 
		/// </summary>
		[DataMember(Name="ExportToExternal", EmitDefaultValue=false)]
		public BooleanValue? ExportToExternal { get; set; }

		[DataMember(Name="FileURLs", EmitDefaultValue=false)]
		public List<InventoryFileUrls>? FileURLs { get; set; }

		/// <summary>
		/// Key field.The user-friendly unique identifier of the Inventory Item.The structure of the identifier is determined by the INVENTORY Segmented Key.
		/// DAC Field Name: InventoryCD 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Inventory ID 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// When set to true, indicates that this item is a Stock Item.
		/// DAC Field Name: StkItem 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Stock Item 
		/// </summary>
		[DataMember(Name="IsStockItem", EmitDefaultValue=false)]
		public BooleanValue? IsStockItem { get; set; }

		[DataMember(Name="ItemStatus", EmitDefaultValue=false)]
		public StringValue? ItemStatus { get; set; }

		/// <summary>
		/// The date and time when the record was last modified.
		/// DAC Field Name: LastModifiedDateTime 
		/// DAC: PX.Objects.IN.Matrix.DAC.Unbound.MatrixInventoryItem 
		/// Display Name: Last Modified On 
		/// </summary>
		[DataMember(Name="LastModified", EmitDefaultValue=false)]
		public DateTimeValue? LastModified { get; set; }

		[DataMember(Name="Matrix", EmitDefaultValue=false)]
		public List<MatrixItems>? Matrix { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		[DataMember(Name="MetaDescription", EmitDefaultValue=false)]
		public StringValue? MetaDescription { get; set; }

		/// <summary>
		/// The manufacturer's suggested retail price of the item.
		/// DAC Field Name: RecPrice 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// </summary>
		[DataMember(Name="MSRP", EmitDefaultValue=false)]
		public DecimalValue? MSRP { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		[DataMember(Name="PageTitle", EmitDefaultValue=false)]
		public StringValue? PageTitle { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		[DataMember(Name="SearchKeywords", EmitDefaultValue=false)]
		public StringValue? SearchKeywords { get; set; }

		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventoryItem 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Visibility", EmitDefaultValue=false)]
		public StringValue? Visibility { get; set; }

		/// <summary>
		/// The Unit of Measure used for the Weight of the item.
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Weight UOM 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="WeightUOM", EmitDefaultValue=false)]
		public StringValue? WeightUOM { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		[DataMember(Name="MetaKeywords", EmitDefaultValue=false)]
		public StringValue? MetaKeywords { get; set; }

		/// <summary>
		/// Reserved for internal use.Indicates whether the item (assumed Non-Stock) requires shipment.
		/// DAC Field Name: NonStockShip 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Require Shipment 
		/// </summary>
		[DataMember(Name="RequireShipment", EmitDefaultValue=false)]
		public BooleanValue? RequireShipment { get; set; }

		/// <summary>
		/// DAC Field Name: NotAvailMode 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: When Qty Unavailable 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="NotAvailable", EmitDefaultValue=false)]
		public StringValue? NotAvailable { get; set; }

		[DataMember(Name="VendorDetails", EmitDefaultValue=false)]
		public List<TemplateItemVendorDetail>? VendorDetails { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}