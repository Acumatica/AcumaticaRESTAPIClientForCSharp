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
	/// Corresponds to the screen <c>AR209500</c> in the Acumatica ERP
	/// <para>Key Fields: DiscountCode, Sequence</para>
	/// </summary>
	[DataContract]
	public class Discount : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.AR.DiscountSequence</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.DiscountSequence</para>
		/// <para>Display Name: Break By</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="BreakBy", EmitDefaultValue=false)]
		public StringValue? BreakBy { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		[DataMember(Name="CustomerPriceClasses", EmitDefaultValue=false)]
		public List<DiscountCustomerPriceClassesDetail>? CustomerPriceClasses { get; set; }

		[DataMember(Name="Customers", EmitDefaultValue=false)]
		public List<DiscountCustomerDetail>? Customers { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.DiscountSequence</para>
		/// <para>SQL Type: nvarchar(250)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="DiscountBreakpoints", EmitDefaultValue=false)]
		public List<DiscountBreakpointDetail>? DiscountBreakpoints { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DiscountedFor</para>
		/// <para>DAC: PX.Objects.AR.DiscountSequence</para>
		/// <para>Display Name: Discount By</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="DiscountBy", EmitDefaultValue=false)]
		public StringValue? DiscountBy { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DiscountID</para>
		/// <para>DAC: PX.Objects.AR.DiscountSequence</para>
		/// <para>Display Name: Discount Code</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="DiscountCode", EmitDefaultValue=false)]
		public StringValue? DiscountCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StartDate</para>
		/// <para>DAC: PX.Objects.AR.DiscountSequence</para>
		/// <para>Display Name: Effective Date</para>
		/// </summary>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EndDate</para>
		/// <para>DAC: PX.Objects.AR.DiscountSequence</para>
		/// <para>Display Name: Expiration Date</para>
		/// </summary>
		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		[DataMember(Name="ItemPriceClasses", EmitDefaultValue=false)]
		public List<DiscountItemPriceClassesDetail>? ItemPriceClasses { get; set; }

		[DataMember(Name="Items", EmitDefaultValue=false)]
		public List<DiscountItemDetail>? Items { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsPromotion</para>
		/// <para>DAC: PX.Objects.AR.DiscountSequence</para>
		/// </summary>
		[DataMember(Name="Promotional", EmitDefaultValue=false)]
		public BooleanValue? Promotional { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Prorate</para>
		/// <para>DAC: PX.Objects.AR.DiscountSequence</para>
		/// <para>Display Name: Prorate Discount</para>
		/// </summary>
		[DataMember(Name="ProrateDiscount", EmitDefaultValue=false)]
		public BooleanValue? ProrateDiscount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DiscountSequenceID</para>
		/// <para>DAC: PX.Objects.AR.DiscountSequence</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="Sequence", EmitDefaultValue=false)]
		public StringValue? Sequence { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.DiscountSequence</para>
		/// </summary>
		[DataMember(Name="ShowFreeItem", EmitDefaultValue=false)]
		public BooleanValue? ShowFreeItem { get; set; }

		[DataMember(Name="Warehouses", EmitDefaultValue=false)]
		public List<DiscountWarehouseDetail>? Warehouses { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
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
			//public const string All = "Files,CustomerPriceClasses,CustomerPriceClasses/Files,Customers,Customers/Files,DiscountBreakpoints,DiscountBreakpoints/Files,ItemPriceClasses,ItemPriceClasses/Files,Items,Items/Files,Warehouses,Warehouses/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}