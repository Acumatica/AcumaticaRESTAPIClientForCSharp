using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class SalesInvoiceDiscountDetails : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARInvoiceDiscountDetail</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryDiscountableAmt</para>
		/// <para>DAC: PX.Objects.AR.ARInvoiceDiscountDetail</para>
		/// <para>Display Name: Discountable Amt.</para>
		/// </summary>
		public DecimalValue? DiscountableAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARInvoiceDiscountDetail</para>
		/// <para>Display Name: Discountable Qty.</para>
		/// </summary>
		public DecimalValue? DiscountableQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryDiscountAmt</para>
		/// <para>DAC: PX.Objects.AR.ARInvoiceDiscountDetail</para>
		/// <para>Display Name: Discount Amt.</para>
		/// </summary>
		public DecimalValue? DiscountAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DiscountID</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>Display Name: Discount Code</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? DiscountCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DiscountPct</para>
		/// <para>DAC: PX.Objects.AR.ARInvoiceDiscountDetail</para>
		/// <para>Display Name: Discount Percent</para>
		/// </summary>
		public DecimalValue? DiscountPercent { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExtDiscCode</para>
		/// <para>DAC: PX.Objects.AR.ARInvoiceDiscountDetail</para>
		/// <para>Display Name: External Discount Code</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? ExternalDiscountCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FreeItemID</para>
		/// <para>DAC: PX.Objects.AR.ARInvoiceDiscountDetail</para>
		/// <para>Display Name: Free Item</para>
		/// </summary>
		public StringValue? FreeItem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARInvoiceDiscountDetail</para>
		/// <para>Display Name: Free Item Qty.</para>
		/// </summary>
		public DecimalValue? FreeItemQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsManual</para>
		/// <para>DAC: PX.Objects.AR.ARInvoiceDiscountDetail</para>
		/// <para>Display Name: Manual Discount</para>
		/// </summary>
		public BooleanValue? ManualDiscount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARInvoiceDiscountDetail</para>
		/// <para>Display Name: Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARInvoiceDiscountDetail</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DiscountSequenceID</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>Display Name: Discount Sequence</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? SequenceID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARInvoiceDiscountDetail</para>
		/// <para>Display Name: Skip Discount</para>
		/// </summary>
		public BooleanValue? SkipDiscount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARInvoiceDiscountDetail</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Type { get; set; }

	}
}