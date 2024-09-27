using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AP302000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Check : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The date when the payment is applied.
		/// DAC Field Name: AdjDate 
		/// DAC: PX.Objects.AP.APPayment 
		/// Display Name: Application Date 
		/// </summary>
		[DataMember(Name="ApplicationDate", EmitDefaultValue=false)]
		public DateTimeValue? ApplicationDate { get; set; }

		/// <summary>
		/// The cash account associated with the payment method.The field is irrelevant for debit adjustments.
		/// DAC Field Name: CashAccountID 
		/// DAC: PX.Objects.AP.APPayment 
		/// Display Name: Cash Account 
		/// </summary>
		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue? CashAccount { get; set; }

		/// <summary>
		/// Code of the Currency of the document.
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.AP.APPayment 
		/// Display Name: Currency 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// Description of the document.
		/// DAC Field Name: DocDesc 
		/// DAC: PX.Objects.AP.APPayment 
		/// SQL Type: nvarchar(512) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<CheckDetail>? Details { get; set; }

		[DataMember(Name="History", EmitDefaultValue=false)]
		public List<CheckHistoryDetail>? History { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// The total payment amount that should be applied to the documents.(Presented in the currency of the document, see CuryID)
		/// DAC Field Name: CuryOrigDocAmt 
		/// DAC: PX.Objects.AP.APPayment 
		/// Display Name: Payment Amount 
		/// </summary>
		[DataMember(Name="PaymentAmount", EmitDefaultValue=false)]
		public DecimalValue? PaymentAmount { get; set; }

		/// <summary>
		/// The payment method used for the document.
		/// DAC Field Name: PaymentMethodID 
		/// DAC: PX.Objects.AP.APPayment 
		/// Display Name: Payment Method 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// A payment reference number, which can be a system-generated number or an external reference number (such as a wire transfer number or a bank check number) entered manually.Irrelevant for Debit Adjustments.
		/// DAC Field Name: ExtRefNbr 
		/// DAC: PX.Objects.AP.APPayment 
		/// Display Name: Payment Ref. 
		/// SQL Type: nvarchar(40) 
		/// </summary>
		[DataMember(Name="PaymentRef", EmitDefaultValue=false)]
		public StringValue? PaymentRef { get; set; }

		/// <summary>
		/// Reference number of the document.
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.AP.APPayment 
		/// Display Name: Reference Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// Status of the document. The field is calculated based on the values of status flag. It can't be changed directly.The fields tht determine status of a document are: Hold, Released, Voided, Scheduled, Prebooked, Printed
		/// DAC: PX.Objects.AP.APPayment 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// Type of the document.
		/// DAC Field Name: DocType 
		/// DAC: PX.Objects.AP.APPayment 
		/// SQL Type: char(3) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// The balance that has not been applied. This will be a nonzero value if the payment amount is not equal to a document’s total amount.Checks shall always have a zero unapplied balance.(Presented in the currency of the document, see CuryID)
		/// DAC Field Name: CuryUnappliedBal 
		/// DAC: PX.Objects.AP.APPayment 
		/// Display Name: Unapplied Balance 
		/// </summary>
		[DataMember(Name="UnappliedBalance", EmitDefaultValue=false)]
		public DecimalValue? UnappliedBalance { get; set; }

		/// <summary>
		/// Identifier of the Vendor, whom the document belongs to.
		/// DAC Field Name: VendorID 
		/// DAC: PX.Objects.AP.APPayment 
		/// </summary>
		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}