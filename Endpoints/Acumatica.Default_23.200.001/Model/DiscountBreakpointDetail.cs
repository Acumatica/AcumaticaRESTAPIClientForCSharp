using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class DiscountBreakpointDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: Amount</para>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Break Amount</para>
		/// </summary>
		public DecimalValue? BreakAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Quantity</para>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Break Quantity</para>
		/// </summary>
		public DecimalValue? BreakQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Discount</para>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Discount Amount</para>
		/// </summary>
		public DecimalValue? DiscountAmount { get; set; }

		public IntValue? DiscountDetailID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Discount Percent</para>
		/// </summary>
		public DecimalValue? DiscountPercent { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LastDate</para>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Effective Date</para>
		/// </summary>
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Free Item Qty.</para>
		/// </summary>
		public DecimalValue? FreeItemQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LastAmount</para>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Last Break Amount</para>
		/// </summary>
		public DecimalValue? LastBreakAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LastQuantity</para>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Last Break Quantity</para>
		/// </summary>
		public DecimalValue? LastBreakQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LastDiscount</para>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Last Discount Amount</para>
		/// </summary>
		public DecimalValue? LastDiscountAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Last Discount Percent</para>
		/// </summary>
		public DecimalValue? LastDiscountPercent { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Last Free Item Qty.</para>
		/// </summary>
		public DecimalValue? LastFreeItemQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PendingAmount</para>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Pending Break Amount</para>
		/// </summary>
		public DecimalValue? PendingBreakAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PendingQuantity</para>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Pending Break Quantity</para>
		/// </summary>
		public DecimalValue? PendingBreakQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StartDate</para>
		/// <para>DAC: PX.Objects.AR.DiscountSequence</para>
		/// <para>Display Name: Effective Date</para>
		/// </summary>
		public DateTimeValue? PendingDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PendingDiscount</para>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Pending Discount Amount</para>
		/// </summary>
		public DecimalValue? PendingDiscountAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Pending Discount Percent</para>
		/// </summary>
		public DecimalValue? PendingDiscountPercent { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.DiscountDetail</para>
		/// <para>Display Name: Pending Free Item Qty.</para>
		/// </summary>
		public DecimalValue? PendingFreeItemQty { get; set; }

	}
}