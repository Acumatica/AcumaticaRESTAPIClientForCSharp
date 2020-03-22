using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class AccountDetailsRow : Entity
	{

		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue Account { get; set; }

		[DataMember(Name="BatchNbr", EmitDefaultValue=false)]
		public StringValue BatchNbr { get; set; }

		[DataMember(Name="BeginingBalance", EmitDefaultValue=false)]
		public DecimalValue BeginingBalance { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue Branch { get; set; }

		[DataMember(Name="CreditAmount", EmitDefaultValue=false)]
		public DecimalValue CreditAmount { get; set; }

		[DataMember(Name="CurrencyBeginingBalance", EmitDefaultValue=false)]
		public DecimalValue CurrencyBeginingBalance { get; set; }

		[DataMember(Name="CurrencyCreditAmount", EmitDefaultValue=false)]
		public DecimalValue CurrencyCreditAmount { get; set; }

		[DataMember(Name="CurrencyDebitAmount", EmitDefaultValue=false)]
		public DecimalValue CurrencyDebitAmount { get; set; }

		[DataMember(Name="CurrencyEndingBalance", EmitDefaultValue=false)]
		public DecimalValue CurrencyEndingBalance { get; set; }

		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue CurrencyID { get; set; }

		[DataMember(Name="DebitAmount", EmitDefaultValue=false)]
		public DecimalValue DebitAmount { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="EndingBalance", EmitDefaultValue=false)]
		public DecimalValue EndingBalance { get; set; }

		[DataMember(Name="IncludedinReclassHistory", EmitDefaultValue=false)]
		public BooleanValue IncludedinReclassHistory { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="Module", EmitDefaultValue=false)]
		public StringValue Module { get; set; }

		[DataMember(Name="Period", EmitDefaultValue=false)]
		public StringValue Period { get; set; }

		[DataMember(Name="ReclassBatchNbr", EmitDefaultValue=false)]
		public StringValue ReclassBatchNbr { get; set; }

		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue ReferenceNbr { get; set; }

		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue Selected { get; set; }

		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue Subaccount { get; set; }

		[DataMember(Name="TransactionDate", EmitDefaultValue=false)]
		public DateTimeValue TransactionDate { get; set; }

		[DataMember(Name="VendorOrCustomer", EmitDefaultValue=false)]
		public StringValue VendorOrCustomer { get; set; }

	}
}