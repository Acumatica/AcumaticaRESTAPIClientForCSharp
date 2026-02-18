using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AR209500</c> in the Acumatica ERP
	/// <para>Key Fields: DiscountCode, Sequence</para>
	/// </summary>
	public class Discount : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.AR.DiscountSequence</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.DiscountSequence</para>
		/// <para>Display Name: Break By</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? BreakBy { get; set; }

		public DateTimeValue? CreatedDateTime { get; set; }

		public List<DiscountCustomerPriceClassesDetail>? CustomerPriceClasses { get; set; }

		public List<DiscountCustomerDetail>? Customers { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.DiscountSequence</para>
		/// <para>SQL Type: nvarchar(250)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public List<DiscountBreakpointDetail>? DiscountBreakpoints { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DiscountedFor</para>
		/// <para>DAC: PX.Objects.AR.DiscountSequence</para>
		/// <para>Display Name: Discount By</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? DiscountBy { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DiscountID</para>
		/// <para>DAC: PX.Objects.AR.DiscountSequence</para>
		/// <para>Display Name: Discount Code</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? DiscountCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StartDate</para>
		/// <para>DAC: PX.Objects.AR.DiscountSequence</para>
		/// <para>Display Name: Effective Date</para>
		/// </summary>
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EndDate</para>
		/// <para>DAC: PX.Objects.AR.DiscountSequence</para>
		/// <para>Display Name: Expiration Date</para>
		/// </summary>
		public DateTimeValue? ExpirationDate { get; set; }

		public List<DiscountItemPriceClassesDetail>? ItemPriceClasses { get; set; }

		public List<DiscountItemDetail>? Items { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsPromotion</para>
		/// <para>DAC: PX.Objects.AR.DiscountSequence</para>
		/// </summary>
		public BooleanValue? Promotional { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Prorate</para>
		/// <para>DAC: PX.Objects.AR.DiscountSequence</para>
		/// <para>Display Name: Prorate Discount</para>
		/// </summary>
		public BooleanValue? ProrateDiscount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DiscountSequenceID</para>
		/// <para>DAC: PX.Objects.AR.DiscountSequence</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? Sequence { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.DiscountSequence</para>
		/// </summary>
		public BooleanValue? ShowFreeItem { get; set; }

		public List<DiscountWarehouseDetail>? Warehouses { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string CustomerPriceClasses = "CustomerPriceClasses";
			public const string CustomerPriceClasses_Files = "CustomerPriceClasses/Files";
			public const string Customers = "Customers";
			public const string Customers_Files = "Customers/Files";
			public const string DiscountBreakpoints = "DiscountBreakpoints";
			public const string DiscountBreakpoints_Files = "DiscountBreakpoints/Files";
			public const string ItemPriceClasses = "ItemPriceClasses";
			public const string ItemPriceClasses_Files = "ItemPriceClasses/Files";
			public const string Items = "Items";
			public const string Items_Files = "Items/Files";
			public const string Warehouses = "Warehouses";
			public const string Warehouses_Files = "Warehouses/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,CustomerPriceClasses,CustomerPriceClasses/Files,Customers,Customers/Files,DiscountBreakpoints,DiscountBreakpoints/Files,ItemPriceClasses,ItemPriceClasses/Files,Items,Items/Files,Warehouses,Warehouses/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}