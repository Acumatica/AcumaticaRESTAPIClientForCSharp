using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class AccountBySubaccountRow : Entity
	{

		[DataMember(Name="BeginingBalance", EmitDefaultValue=false)]
		public DecimalValue BeginingBalance { get; set; }

		[DataMember(Name="CreditTotal", EmitDefaultValue=false)]
		public DecimalValue CreditTotal { get; set; }

		[DataMember(Name="CurrencyBeginingBalance", EmitDefaultValue=false)]
		public DecimalValue CurrencyBeginingBalance { get; set; }

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

		[DataMember(Name="EndingBalance", EmitDefaultValue=false)]
		public DecimalValue EndingBalance { get; set; }

		[DataMember(Name="LedgerID", EmitDefaultValue=false)]
		public IntValue LedgerID { get; set; }

		[DataMember(Name="PtdTotal", EmitDefaultValue=false)]
		public DecimalValue PtdTotal { get; set; }

		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue Subaccount { get; set; }

	}
}