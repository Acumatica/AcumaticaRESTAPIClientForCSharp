using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AR202000</c> in the Acumatica ERP
	/// </summary>
	public class SalesPricesInquiry : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARSalesPriceFilter</para>
		/// <para>Display Name: Price Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? PriceType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARSalesPriceFilter</para>
		/// <para>Display Name: Price Code</para>
		/// <para>SQL Type: varchar(30)</para>
		/// </summary>
		public StringValue? PriceCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxCalcMode</para>
		/// <para>DAC: PX.Objects.AR.ARSalesPriceFilter</para>
		/// <para>Display Name: Tax Calculation Mode</para>
		/// <para>SQL Type: nchar(1)</para>
		/// </summary>
		public StringValue? TaxCalculationMode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EffectiveAsOfDate</para>
		/// <para>DAC: PX.Objects.AR.ARSalesPriceFilter</para>
		/// <para>Display Name: Effective As Of</para>
		/// </summary>
		public DateOnlyValue? EffectiveAsOf { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemClassCD</para>
		/// <para>DAC: PX.Objects.AR.ARSalesPriceFilter</para>
		/// <para>Display Name: Item Class ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? ItemClassID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARSalesPriceFilter</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryPriceClassID</para>
		/// <para>DAC: PX.Objects.AR.ARSalesPriceFilter</para>
		/// <para>Display Name: Price Class</para>
		/// <para>SQL Type: varchar(10)</para>
		/// </summary>
		public StringValue? PriceClass { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.AR.ARSalesPriceFilter</para>
		/// <para>Display Name: Price Manager</para>
		/// </summary>
		public StringValue? PriceManager { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MyOwner</para>
		/// <para>DAC: PX.Objects.AR.ARSalesPriceFilter</para>
		/// <para>Display Name: Me</para>
		/// </summary>
		public BooleanValue? PriceManagerIsMe { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WorkGroupID</para>
		/// <para>DAC: PX.Objects.AR.ARSalesPriceFilter</para>
		/// <para>Display Name: Price Workgroup</para>
		/// </summary>
		public StringValue? PriceWorkgroup { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MyWorkGroup</para>
		/// <para>DAC: PX.Objects.AR.ARSalesPriceFilter</para>
		/// <para>Display Name: My</para>
		/// </summary>
		public BooleanValue? PriceWorkgroupIsMine { get; set; }

		#endregion

		#region Details
		public List<SalesPriceDetail>? SalesPriceDetails { get; set; }

		#endregion

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
			public const string Translations = "Translations";
			public const string SalesPriceDetails = "SalesPriceDetails";

			//Intentionally excluded
			//public const string All = "Files,Translations,SalesPriceDetails";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}