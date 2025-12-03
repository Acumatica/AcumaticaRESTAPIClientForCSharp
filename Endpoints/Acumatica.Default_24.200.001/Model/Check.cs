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
	/// Corresponds to the screen <c>AP302000</c> in the Acumatica ERP
	/// <para>Key Fields: ReferenceNbr, Type</para>
	/// </summary>
	[DataContract]
	public class Check : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The date when the payment is applied.
		/// <para>DAC Field Name: AdjDate</para>
		/// <para>DAC: PX.Objects.AP.APPayment</para>
		/// <para>Display Name: Application Date</para>
		/// </summary>
		[DataMember(Name="ApplicationDate", EmitDefaultValue=false)]
		public DateTimeValue? ApplicationDate { get; set; }

		/// <summary>
		/// The cash account associated with the payment method.The field is irrelevant for debit adjustments.
		/// <para>DAC Field Name: CashAccountID</para>
		/// <para>DAC: PX.Objects.AP.APPayment</para>
		/// <para>Display Name: Cash Account</para>
		/// </summary>
		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue? CashAccount { get; set; }

		/// <summary>
		/// Code of the Currency of the document.
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.AP.APPayment</para>
		/// <para>Display Name: Currency</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// Description of the document.
		/// <para>DAC Field Name: DocDesc</para>
		/// <para>DAC: PX.Objects.AP.APPayment</para>
		/// <para>SQL Type: nvarchar(512)</para>
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
		/// <para>DAC Field Name: CuryOrigDocAmt</para>
		/// <para>DAC: PX.Objects.AP.APPayment</para>
		/// <para>Display Name: Payment Amount</para>
		/// </summary>
		[DataMember(Name="PaymentAmount", EmitDefaultValue=false)]
		public DecimalValue? PaymentAmount { get; set; }

		/// <summary>
		/// The payment method used for the document.
		/// <para>DAC Field Name: PaymentMethodID</para>
		/// <para>DAC: PX.Objects.AP.APPayment</para>
		/// <para>Display Name: Payment Method</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// A payment reference number, which can be a system-generated number or an external reference number (such as a wire transfer number or a bank check number) entered manually.Irrelevant for Debit Adjustments.
		/// <para>DAC Field Name: ExtRefNbr</para>
		/// <para>DAC: PX.Objects.AP.APPayment</para>
		/// <para>Display Name: Payment Ref.</para>
		/// <para>SQL Type: nvarchar(40)</para>
		/// </summary>
		[DataMember(Name="PaymentRef", EmitDefaultValue=false)]
		public StringValue? PaymentRef { get; set; }

		/// <summary>
		/// Reference number of the document.
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.AP.APPayment</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// Status of the document. The field is calculated based on the values of status flag. It can't be changed directly.The fields tht determine status of a document are: Hold, Released, Voided, Scheduled, Prebooked, Printed
		/// <para>DAC: PX.Objects.AP.APPayment</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// Type of the document.
		/// <para>DAC Field Name: DocType</para>
		/// <para>DAC: PX.Objects.AP.APPayment</para>
		/// <para>SQL Type: char(3)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// The balance that has not been applied. This will be a nonzero value if the payment amount is not equal to a document’s total amount.Checks shall always have a zero unapplied balance.(Presented in the currency of the document, see CuryID)
		/// <para>DAC Field Name: CuryUnappliedBal</para>
		/// <para>DAC: PX.Objects.AP.APPayment</para>
		/// <para>Display Name: Unapplied Balance</para>
		/// </summary>
		[DataMember(Name="UnappliedBalance", EmitDefaultValue=false)]
		public DecimalValue? UnappliedBalance { get; set; }

		/// <summary>
		/// Identifier of the Vendor, whom the document belongs to.
		/// <para>DAC Field Name: VendorID</para>
		/// <para>DAC: PX.Objects.AP.APPayment</para>
		/// </summary>
		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Details = "Details";
			public const string Details_Files = "Details/Files";
			public const string History = "History";
			public const string History_Files = "History/Files";

			//Intentionally excluded
			//public const string All = "Files,Details,Details/Files,History,History/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}