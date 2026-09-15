using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class DiscountBreakpointDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: Amount</para>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Break Amount</para>
		/// </summary>
		[DataMember(Name="BreakAmount", EmitDefaultValue=false)]
		public DecimalValue? BreakAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Quantity</para>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Break Quantity</para>
		/// </summary>
		[DataMember(Name="BreakQty", EmitDefaultValue=false)]
		public DecimalValue? BreakQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Discount</para>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Discount Amount</para>
		/// </summary>
		[DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
		public DecimalValue? DiscountAmount { get; set; }

		[DataMember(Name="DiscountDetailID", EmitDefaultValue=false)]
		public IntValue? DiscountDetailID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Discount Percent</para>
		/// </summary>
		[DataMember(Name="DiscountPercent", EmitDefaultValue=false)]
		public DecimalValue? DiscountPercent { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LastDate</para>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Effective Date</para>
		/// </summary>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateOnlyValue? EffectiveDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Free Item Qty.</para>
		/// </summary>
		[DataMember(Name="FreeItemQty", EmitDefaultValue=false)]
		public DecimalValue? FreeItemQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LastAmount</para>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Last Break Amount</para>
		/// </summary>
		[DataMember(Name="LastBreakAmount", EmitDefaultValue=false)]
		public DecimalValue? LastBreakAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LastQuantity</para>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Last Break Quantity</para>
		/// </summary>
		[DataMember(Name="LastBreakQty", EmitDefaultValue=false)]
		public DecimalValue? LastBreakQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LastDiscount</para>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Last Discount Amount</para>
		/// </summary>
		[DataMember(Name="LastDiscountAmount", EmitDefaultValue=false)]
		public DecimalValue? LastDiscountAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Last Discount Percent</para>
		/// </summary>
		[DataMember(Name="LastDiscountPercent", EmitDefaultValue=false)]
		public DecimalValue? LastDiscountPercent { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Last Free Item Qty.</para>
		/// </summary>
		[DataMember(Name="LastFreeItemQty", EmitDefaultValue=false)]
		public DecimalValue? LastFreeItemQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PendingAmount</para>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Pending Break Amount</para>
		/// </summary>
		[DataMember(Name="PendingBreakAmount", EmitDefaultValue=false)]
		public DecimalValue? PendingBreakAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PendingQuantity</para>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Pending Break Quantity</para>
		/// </summary>
		[DataMember(Name="PendingBreakQty", EmitDefaultValue=false)]
		public DecimalValue? PendingBreakQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StartDate</para>
		/// <para>DAC: PX.Objects.AR.DiscountSequence</para>
		/// <para>Display Name: Effective Date</para>
		/// </summary>
		[DataMember(Name="PendingDate", EmitDefaultValue=false)]
		public DateOnlyValue? PendingDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PendingDiscount</para>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Pending Discount Amount</para>
		/// </summary>
		[DataMember(Name="PendingDiscountAmount", EmitDefaultValue=false)]
		public DecimalValue? PendingDiscountAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Pending Discount Percent</para>
		/// </summary>
		[DataMember(Name="PendingDiscountPercent", EmitDefaultValue=false)]
		public DecimalValue? PendingDiscountPercent { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Pending Free Item Qty.</para>
		/// </summary>
		[DataMember(Name="PendingFreeItemQty", EmitDefaultValue=false)]
		public DecimalValue? PendingFreeItemQty { get; set; }

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