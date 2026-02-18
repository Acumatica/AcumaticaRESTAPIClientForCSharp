using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>IN201000</c> in the Acumatica ERP
	/// <para>Key Fields: ClassID</para>
	/// </summary>
	public class ItemClass : Entity, ITopLevelEntity
	{

		public List<ItemClassAtrribute>? Attributes { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AvailabilitySchemeID</para>
		/// <para>DAC: PX.Objects.IN.INItemClass</para>
		/// <para>Display Name: Availability Calculation Rule</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? AvailabilityCalculationRule { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BaseUnit</para>
		/// <para>DAC: PX.Objects.IN.INItemClass</para>
		/// <para>Display Name: Base Unit</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? BaseUOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemClassCD</para>
		/// <para>DAC: PX.Objects.IN.INItemClass</para>
		/// <para>Display Name: Class ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemClass</para>
		/// <para>Display Name: Country Of Origin</para>
		/// <para>SQL Type: nvarchar(2)</para>
		/// </summary>
		public StringValue? CountryOfOrigin { get; set; }

		/// <summary>
		/// The default Warehouse used to store the items of this kind.Applicable only for Stock Items (see StkItem) and when the Warehouses feature is enabled.
		/// <para>DAC Field Name: DfltSiteID</para>
		/// <para>DAC: PX.Objects.IN.INItemClassCurySettings</para>
		/// <para>Display Name: Default Warehouse</para>
		/// </summary>
		public StringValue? DefaultWarehouseID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.IN.INItemClass</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemClass</para>
		/// <para>Display Name: Item Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? ItemType { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LotSerClassID</para>
		/// <para>DAC: PX.Objects.IN.INItemClass</para>
		/// <para>Display Name: Lot/Serial Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? LotSerialClass { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PostClassID</para>
		/// <para>DAC: PX.Objects.IN.INItemClass</para>
		/// <para>Display Name: Posting Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? PostingClass { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PriceClassID</para>
		/// <para>DAC: PX.Objects.IN.INItemClass</para>
		/// <para>Display Name: Price Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? PriceClass { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PurchaseUnit</para>
		/// <para>DAC: PX.Objects.IN.INItemClass</para>
		/// <para>Display Name: Purchase Unit</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? PurchaseUOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SalesUnit</para>
		/// <para>DAC: PX.Objects.IN.INItemClass</para>
		/// <para>Display Name: Sales Unit</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? SalesUOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StkItem</para>
		/// <para>DAC: PX.Objects.IN.INItemClass</para>
		/// <para>Display Name: Stock Item</para>
		/// </summary>
		public BooleanValue? StockItem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: HSTariffCode</para>
		/// <para>DAC: PX.Objects.IN.INItemClass</para>
		/// <para>Display Name: Commodity Code</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? TariffCode { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemClass</para>
		/// <para>Display Name: Tax Category</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? TaxCategoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ValMethod</para>
		/// <para>DAC: PX.Objects.IN.INItemClass</para>
		/// <para>Display Name: Valuation Method</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? ValuationMethod { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Attributes = "Attributes";

			//Intentionally excluded
			//public const string All = "Files,Translations,Attributes";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}