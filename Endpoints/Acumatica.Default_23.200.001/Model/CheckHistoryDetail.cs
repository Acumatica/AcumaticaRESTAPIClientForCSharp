using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class CheckHistoryDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: CuryAmt 
		/// DAC: PX.Objects.AP.APTranPostBal 
		/// Display Name: Amount 
		/// </summary>
		[DataMember(Name="AmountPaid", EmitDefaultValue=false)]
		public DecimalValue? AmountPaid { get; set; }

		/// <summary>
		/// DAC Field Name: CuryBalanceAmt 
		/// DAC: PX.Objects.AP.APTranPostBal 
		/// </summary>
		[DataMember(Name="Balance", EmitDefaultValue=false)]
		public DecimalValue? Balance { get; set; }

		/// <summary>
		/// DAC Field Name: CuryDiscBalanceAmt 
		/// DAC: PX.Objects.AP.APTranPostBal 
		/// Display Name: Cash Discount Balance 
		/// </summary>
		[DataMember(Name="CashDiscountBalance", EmitDefaultValue=false)]
		public DecimalValue? CashDiscountBalance { get; set; }

		/// <summary>
		/// DAC Field Name: CuryPPDAmt 
		/// DAC: PX.Objects.AP.APTranPostBal 
		/// Display Name: Cash Discount Taken 
		/// </summary>
		[DataMember(Name="CashDiscountTaken", EmitDefaultValue=false)]
		public DecimalValue? CashDiscountTaken { get; set; }

		/// <summary>
		/// DAC Field Name: SourceDocType 
		/// DAC: PX.Objects.AP.APTranPostBal 
		/// Display Name: Source Doc. Type 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="DocType", EmitDefaultValue=false)]
		public StringValue? DocType { get; set; }

		/// <summary>
		/// DAC Field Name: SourceRefNbr 
		/// DAC: PX.Objects.AP.APTranPostBal 
		/// Display Name: Source Ref. Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// DAC Field Name: APInvoice__InvoiceNbr 
		/// DAC: PX.Objects.AP.APAdjust 
		/// </summary>
		[DataMember(Name="VendorRef", EmitDefaultValue=false)]
		public StringValue? VendorRef { get; set; }

	}
}