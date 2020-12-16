using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class AccountDetailsForPeriodInquiryDetail : Entity_v4
	{

		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue Account { get; set; }

		[DataMember(Name="BatchNumber", EmitDefaultValue=false)]
		public StringValue BatchNumber { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue Branch { get; set; }

		[DataMember(Name="CreditAmount", EmitDefaultValue=false)]
		public DecimalValue CreditAmount { get; set; }

		[DataMember(Name="CreditAmountInBaseCurrency", EmitDefaultValue=false)]
		public DecimalValue CreditAmountInBaseCurrency { get; set; }

		[DataMember(Name="Currency", EmitDefaultValue=false)]
		public StringValue Currency { get; set; }

		[DataMember(Name="CustomerVendor", EmitDefaultValue=false)]
		public StringValue CustomerVendor { get; set; }

		[DataMember(Name="DebitAmount", EmitDefaultValue=false)]
		public DecimalValue DebitAmount { get; set; }

		[DataMember(Name="DebitAmountInBaseCurrency", EmitDefaultValue=false)]
		public DecimalValue DebitAmountInBaseCurrency { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="Ledger", EmitDefaultValue=false)]
		public StringValue Ledger { get; set; }

		[DataMember(Name="Module", EmitDefaultValue=false)]
		public StringValue Module { get; set; }

		[DataMember(Name="PeriodID", EmitDefaultValue=false)]
		public StringValue PeriodID { get; set; }

		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue Project { get; set; }

		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue ProjectTask { get; set; }

		[DataMember(Name="RefNumber", EmitDefaultValue=false)]
		public StringValue RefNumber { get; set; }

		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue Subaccount { get; set; }

		[DataMember(Name="TransactionDate", EmitDefaultValue=false)]
		public DateTimeValue TransactionDate { get; set; }

		[DataMember(Name="TransactionDescription", EmitDefaultValue=false)]
		public StringValue TransactionDescription { get; set; }

		[DataMember(Name="TransactionType", EmitDefaultValue=false)]
		public StringValue TransactionType { get; set; }

		[DataMember(Name="Posted", EmitDefaultValue=false)]
		public BooleanValue Posted { get; set; }

		[DataMember(Name="Released", EmitDefaultValue=false)]
		public BooleanValue Released { get; set; }

	}
}