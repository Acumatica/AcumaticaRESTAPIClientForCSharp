using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class InvoiceDiscountDetail : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.AR.ARInvoiceDiscountDetail 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: CuryDiscountableAmt 
		/// DAC: PX.Objects.AR.ARInvoiceDiscountDetail 
		/// Display Name: Discountable Amt. 
		/// </summary>
		[DataMember(Name="DiscountableAmount", EmitDefaultValue=false)]
		public DecimalValue? DiscountableAmount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARInvoiceDiscountDetail 
		/// Display Name: Discountable Qty. 
		/// </summary>
		[DataMember(Name="DiscountableQty", EmitDefaultValue=false)]
		public DecimalValue? DiscountableQty { get; set; }

		/// <summary>
		/// DAC Field Name: CuryDiscountAmt 
		/// DAC: PX.Objects.AR.ARInvoiceDiscountDetail 
		/// Display Name: Discount Amt. 
		/// </summary>
		[DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
		public DecimalValue? DiscountAmount { get; set; }

		/// <summary>
		/// DAC Field Name: DiscountID 
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Discount Code 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="DiscountCode", EmitDefaultValue=false)]
		public StringValue? DiscountCode { get; set; }

		/// <summary>
		/// DAC Field Name: DiscountPct 
		/// DAC: PX.Objects.AR.ARInvoiceDiscountDetail 
		/// Display Name: Discount Percent 
		/// </summary>
		[DataMember(Name="DiscountPercent", EmitDefaultValue=false)]
		public DecimalValue? DiscountPercent { get; set; }

		/// <summary>
		/// DAC Field Name: ExtDiscCode 
		/// DAC: PX.Objects.AR.ARInvoiceDiscountDetail 
		/// Display Name: External Discount Code 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ExternalDiscountCode", EmitDefaultValue=false)]
		public StringValue? ExternalDiscountCode { get; set; }

		/// <summary>
		/// DAC Field Name: IsManual 
		/// DAC: PX.Objects.AR.ARInvoiceDiscountDetail 
		/// Display Name: Manual Discount 
		/// </summary>
		[DataMember(Name="ManualDiscount", EmitDefaultValue=false)]
		public BooleanValue? ManualDiscount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARInvoiceDiscountDetail 
		/// Display Name: Order Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARInvoiceDiscountDetail 
		/// Display Name: Order Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// DAC Field Name: CuryRetainedDiscountAmt 
		/// DAC: PX.Objects.AR.ARInvoiceDiscountDetail 
		/// Display Name: Retained Discount 
		/// </summary>
		[DataMember(Name="RetainedDiscount", EmitDefaultValue=false)]
		public DecimalValue? RetainedDiscount { get; set; }

		/// <summary>
		/// DAC Field Name: DiscountSequenceID 
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Discount Sequence 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="SequenceID", EmitDefaultValue=false)]
		public StringValue? SequenceID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARInvoiceDiscountDetail 
		/// Display Name: Skip Discount 
		/// </summary>
		[DataMember(Name="SkipDiscount", EmitDefaultValue=false)]
		public BooleanValue? SkipDiscount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARInvoiceDiscountDetail 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

	}
}