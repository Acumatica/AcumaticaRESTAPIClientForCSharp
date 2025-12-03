using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>IN203000</c> in the Acumatica ERP
	/// <para>Key Fields: InventoryID</para>
	/// </summary>
	[DataContract]
	public class TemplateItems : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The Unit of Measure used as the sales unit for the Inventory Item.This field can be changed only if the Multiple Units of Measure feature is enabled.Otherwise, the sales unit is assumed to be the same as the Base Unit.
		/// <para>DAC Field Name: SalesUnit</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Sales Unit</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="SalesUOM", EmitDefaultValue=false)]
		public StringValue? SalesUOM { get; set; }

		/// <summary>
		/// The manufacturer's suggested retail price of the item.
		/// <para>DAC Field Name: RecPrice</para>
		/// <para>DAC: PX.Objects.IN.InventoryItemCurySettings</para>
		/// <para>Display Name: MSRP</para>
		/// </summary>
		[DataMember(Name="CurySpecificMSRP", EmitDefaultValue=false)]
		public DecimalValue? CurySpecificMSRP { get; set; }

		/// <summary>
		/// The price used as the default price, if there are no other prices defined for this item in any price list in the Accounts Receivable module.
		/// <para>DAC Field Name: BasePrice</para>
		/// <para>DAC: PX.Objects.IN.InventoryItemCurySettings</para>
		/// <para>Display Name: Default Price</para>
		/// </summary>
		[DataMember(Name="CurySpecificPrice", EmitDefaultValue=false)]
		public DecimalValue? CurySpecificPrice { get; set; }

		/// <summary>
		/// The identifier of the Item Class, to which the Inventory Item belongs.Item Classes provide default settings for items, which belong to them, and are used to group items.
		/// <para>DAC Field Name: ItemClassID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Item Class</para>
		/// </summary>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Availability", EmitDefaultValue=false)]
		public StringValue? Availability { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// The Unit of Measure used as the base unit for the Inventory Item.
		/// <para>DAC Field Name: BaseUnit</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Base Unit</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="BaseUOM", EmitDefaultValue=false)]
		public StringValue? BaseUOM { get; set; }

		[DataMember(Name="Categories", EmitDefaultValue=false)]
		public List<CategoryStockItem>? Categories { get; set; }

		/// <summary>
		/// Rich text description of the item.
		/// <para>DAC Field Name: Body</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="Content", EmitDefaultValue=false)]
		public StringValue? Content { get; set; }

		/// <summary>
		/// The current standard cost of the item.
		/// <para>DAC Field Name: StdCost</para>
		/// <para>DAC: PX.Objects.IN.InventoryItemCurySettings</para>
		/// <para>Display Name: Current Cost</para>
		/// </summary>
		[DataMember(Name="CurrentStdCost", EmitDefaultValue=false)]
		public DecimalValue? CurrentStdCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// </summary>
		[DataMember(Name="CustomURL", EmitDefaultValue=false)]
		public StringValue? CustomURL { get; set; }

		[DataMember(Name="DefaultIssueLocationID", EmitDefaultValue=false)]
		public StringValue? DefaultIssueLocationID { get; set; }

		/// <summary>
		/// The price used as the default price, if there are no other prices defined for this item in any price list in the Accounts Receivable module.
		/// <para>DAC Field Name: BasePrice</para>
		/// <para>DAC: PX.Objects.IN.InventoryItemCurySettings</para>
		/// <para>Display Name: Default Price</para>
		/// </summary>
		[DataMember(Name="DefaultPrice", EmitDefaultValue=false)]
		public DecimalValue? DefaultPrice { get; set; }

		/// <summary>
		/// The description of the Inventory Item.
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The weight of the Base Unit of the item.
		/// <para>DAC Field Name: BaseItemWeight</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Weight</para>
		/// </summary>
		[DataMember(Name="DimensionWeight", EmitDefaultValue=false)]
		public DecimalValue? DimensionWeight { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Export to External System</para>
		/// </summary>
		[DataMember(Name="ExportToExternal", EmitDefaultValue=false)]
		public BooleanValue? ExportToExternal { get; set; }

		[DataMember(Name="FileURLs", EmitDefaultValue=false)]
		public List<InventoryFileUrls>? FileURLs { get; set; }

		/// <summary>
		/// Key field.The user-friendly unique identifier of the Inventory Item.The structure of the identifier is determined by the INVENTORY Segmented Key.
		/// <para>DAC Field Name: InventoryCD</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Inventory ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// When set to true, indicates that this item is a Stock Item.
		/// <para>DAC Field Name: StkItem</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Stock Item</para>
		/// </summary>
		[DataMember(Name="IsStockItem", EmitDefaultValue=false)]
		public BooleanValue? IsStockItem { get; set; }

		/// <summary>
		/// The status of the Inventory Item.
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Item Status</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="ItemStatus", EmitDefaultValue=false)]
		public StringValue? ItemStatus { get; set; }

		/// <summary>
		/// The date and time when the record was last modified.
		/// <para>DAC Field Name: LastModifiedDateTime</para>
		/// <para>DAC: PX.Objects.IN.Matrix.DAC.Unbound.MatrixInventoryItem</para>
		/// <para>Display Name: Last Modified On</para>
		/// </summary>
		[DataMember(Name="LastModified", EmitDefaultValue=false)]
		public DateTimeValue? LastModified { get; set; }

		[DataMember(Name="Matrix", EmitDefaultValue=false)]
		public List<MatrixItems>? Matrix { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// </summary>
		[DataMember(Name="MetaDescription", EmitDefaultValue=false)]
		public StringValue? MetaDescription { get; set; }

		/// <summary>
		/// The manufacturer's suggested retail price of the item.
		/// <para>DAC Field Name: RecPrice</para>
		/// <para>DAC: PX.Objects.IN.InventoryItemCurySettings</para>
		/// </summary>
		[DataMember(Name="MSRP", EmitDefaultValue=false)]
		public DecimalValue? MSRP { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// </summary>
		[DataMember(Name="PageTitle", EmitDefaultValue=false)]
		public StringValue? PageTitle { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// </summary>
		[DataMember(Name="SearchKeywords", EmitDefaultValue=false)]
		public StringValue? SearchKeywords { get; set; }

		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Visibility", EmitDefaultValue=false)]
		public StringValue? Visibility { get; set; }

		/// <summary>
		/// The Unit of Measure used for the Weight of the item.
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Weight UOM</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="WeightUOM", EmitDefaultValue=false)]
		public StringValue? WeightUOM { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// </summary>
		[DataMember(Name="MetaKeywords", EmitDefaultValue=false)]
		public StringValue? MetaKeywords { get; set; }

		/// <summary>
		/// Reserved for internal use.Indicates whether the item (assumed Non-Stock) requires shipment.
		/// <para>DAC Field Name: NonStockShip</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Require Shipment</para>
		/// </summary>
		[DataMember(Name="RequireShipment", EmitDefaultValue=false)]
		public BooleanValue? RequireShipment { get; set; }

		/// <summary>
		/// <para>DAC Field Name: NotAvailMode</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: When Qty Unavailable</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="NotAvailable", EmitDefaultValue=false)]
		public StringValue? NotAvailable { get; set; }

		[DataMember(Name="VendorDetails", EmitDefaultValue=false)]
		public List<TemplateItemVendorDetail>? VendorDetails { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Attributes = "Attributes";
			public const string Categories = "Categories";
			public const string Categories_Files = "Categories/Files";
			public const string FileURLs = "FileURLs";
			public const string FileURLs_Files = "FileURLs/Files";
			public const string Matrix = "Matrix";
			public const string Matrix_Files = "Matrix/Files";
			public const string VendorDetails = "VendorDetails";
			public const string VendorDetails_Files = "VendorDetails/Files";

			//Intentionally excluded
			//public const string All = "Files,Attributes,Categories,Categories/Files,FileURLs,FileURLs/Files,Matrix,Matrix/Files,VendorDetails,VendorDetails/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}