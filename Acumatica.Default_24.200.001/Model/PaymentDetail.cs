using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class PaymentDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: CuryAdjgAmt 
		/// DAC: PX.Objects.AR.ARAdjust 
		/// Display Name: Amount Paid 
		/// </summary>
		[DataMember(Name="AmountPaid", EmitDefaultValue=false)]
		public DecimalValue? AmountPaid { get; set; }

		/// <summary>
		/// DAC Field Name: CuryAdjgWOAmt 
		/// DAC: PX.Objects.AR.ARAdjust 
		/// Display Name: Write-Off Amount 
		/// </summary>
		[DataMember(Name="BalanceWriteOff", EmitDefaultValue=false)]
		public DecimalValue? BalanceWriteOff { get; set; }

		/// <summary>
		/// The cash discount amount displayed for the document.Given in the  currency of the adjusting document.
		/// DAC Field Name: CuryAdjgPPDAmt 
		/// DAC: PX.Objects.AR.ARAdjust 
		/// Display Name: Cash Discount Taken 
		/// </summary>
		[DataMember(Name="CashDiscountTaken", EmitDefaultValue=false)]
		public DecimalValue? CashDiscountTaken { get; set; }

		/// <summary>
		/// DAC Field Name: ARInvoice__InvoiceNbr 
		/// DAC: PX.Objects.AR.ARAdjust 
		/// </summary>
		[DataMember(Name="CustomerOrder", EmitDefaultValue=false)]
		public StringValue? CustomerOrder { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: AdjdLineNbr 
		/// DAC: PX.Objects.AR.ARAdjust 
		/// Display Name: Line Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="DocLineNbr", EmitDefaultValue=false)]
		public IntValue? DocLineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: AdjdDocType 
		/// DAC: PX.Objects.AR.ARAdjust 
		/// Display Name: Doc. Type 
		/// SQL Type: char(3) 
		/// Key Field
		/// </summary>
		[DataMember(Name="DocType", EmitDefaultValue=false)]
		public StringValue? DocType { get; set; }

		/// <summary>
		/// DAC Field Name: AdjdRefNbr 
		/// DAC: PX.Objects.AR.ARAdjust 
		/// Display Name: Reference Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARAdjust 
		/// Display Name: Write-Off Reason Code 
		/// SQL Type: nvarchar(20) 
		/// </summary>
		[DataMember(Name="WriteOffReasonCode", EmitDefaultValue=false)]
		public StringValue? WriteOffReasonCode { get; set; }

	}
}