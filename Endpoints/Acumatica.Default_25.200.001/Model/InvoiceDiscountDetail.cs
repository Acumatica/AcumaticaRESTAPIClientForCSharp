using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	[DataContract]
	public class InvoiceDiscountDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARInvoiceDiscountDetail</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryDiscountableAmt</para>
		/// <para>DAC: PX.Objects.AR.ARInvoiceDiscountDetail</para>
		/// <para>Display Name: Discountable Amt.</para>
		/// </summary>
		[DataMember(Name="DiscountableAmount", EmitDefaultValue=false)]
		public DecimalValue? DiscountableAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARInvoiceDiscountDetail</para>
		/// <para>Display Name: Discountable Qty.</para>
		/// </summary>
		[DataMember(Name="DiscountableQty", EmitDefaultValue=false)]
		public DecimalValue? DiscountableQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryDiscountAmt</para>
		/// <para>DAC: PX.Objects.AR.ARInvoiceDiscountDetail</para>
		/// <para>Display Name: Discount Amt.</para>
		/// </summary>
		[DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
		public DecimalValue? DiscountAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DiscountID</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>Display Name: Discount Code</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="DiscountCode", EmitDefaultValue=false)]
		public StringValue? DiscountCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DiscountPct</para>
		/// <para>DAC: PX.Objects.AR.ARInvoiceDiscountDetail</para>
		/// <para>Display Name: Discount Percent</para>
		/// </summary>
		[DataMember(Name="DiscountPercent", EmitDefaultValue=false)]
		public DecimalValue? DiscountPercent { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExtDiscCode</para>
		/// <para>DAC: PX.Objects.AR.ARInvoiceDiscountDetail</para>
		/// <para>Display Name: External Discount Code</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="ExternalDiscountCode", EmitDefaultValue=false)]
		public StringValue? ExternalDiscountCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsManual</para>
		/// <para>DAC: PX.Objects.AR.ARInvoiceDiscountDetail</para>
		/// <para>Display Name: Manual Discount</para>
		/// </summary>
		[DataMember(Name="ManualDiscount", EmitDefaultValue=false)]
		public BooleanValue? ManualDiscount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARInvoiceDiscountDetail</para>
		/// <para>Display Name: Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARInvoiceDiscountDetail</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryRetainedDiscountAmt</para>
		/// <para>DAC: PX.Objects.AR.ARInvoiceDiscountDetail</para>
		/// <para>Display Name: Retained Discount</para>
		/// </summary>
		[DataMember(Name="RetainedDiscount", EmitDefaultValue=false)]
		public DecimalValue? RetainedDiscount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DiscountSequenceID</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>Display Name: Discount Sequence</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="SequenceID", EmitDefaultValue=false)]
		public StringValue? SequenceID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARInvoiceDiscountDetail</para>
		/// <para>Display Name: Skip Discount</para>
		/// </summary>
		[DataMember(Name="SkipDiscount", EmitDefaultValue=false)]
		public BooleanValue? SkipDiscount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARInvoiceDiscountDetail</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

	}
}