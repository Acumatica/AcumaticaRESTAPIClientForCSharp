using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class AccountSummaryRow : Entity_v4
	{

		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue Account { get; set; }

		[DataMember(Name="AccountClass", EmitDefaultValue=false)]
		public StringValue AccountClass { get; set; }

		[DataMember(Name="BeginningBalance", EmitDefaultValue=false)]
		public DecimalValue BeginningBalance { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue Branch { get; set; }

		[DataMember(Name="ConsolidationAccount", EmitDefaultValue=false)]
		public StringValue ConsolidationAccount { get; set; }

		[DataMember(Name="CreditTotal", EmitDefaultValue=false)]
		public DecimalValue CreditTotal { get; set; }

		[DataMember(Name="CurrencyBeginningBalance", EmitDefaultValue=false)]
		public DecimalValue CurrencyBeginningBalance { get; set; }

		[DataMember(Name="CurrencyCreditTotal", EmitDefaultValue=false)]
		public DecimalValue CurrencyCreditTotal { get; set; }

		[DataMember(Name="CurrencyDebitTotal", EmitDefaultValue=false)]
		public DecimalValue CurrencyDebitTotal { get; set; }

		[DataMember(Name="CurrencyEndingBalance", EmitDefaultValue=false)]
		public DecimalValue CurrencyEndingBalance { get; set; }

		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue CurrencyID { get; set; }

		[DataMember(Name="CurrencyPtdTotal", EmitDefaultValue=false)]
		public DecimalValue CurrencyPtdTotal { get; set; }

		[DataMember(Name="DebitTotal", EmitDefaultValue=false)]
		public DecimalValue DebitTotal { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="EndingBalance", EmitDefaultValue=false)]
		public DecimalValue EndingBalance { get; set; }

		[DataMember(Name="LastActivity", EmitDefaultValue=false)]
		public StringValue LastActivity { get; set; }

		[DataMember(Name="LedgerID", EmitDefaultValue=false)]
		public IntValue LedgerID { get; set; }

		[DataMember(Name="PtdTotal", EmitDefaultValue=false)]
		public DecimalValue PtdTotal { get; set; }

		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue Subaccount { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

	}
}