using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class CABankTran : Entity
	{

		[DataMember(Name="AppliedRule", EmitDefaultValue=false)]
		public IntValue? AppliedRule { get; set; }

		[DataMember(Name="AppliedRuleRuleDescription", EmitDefaultValue=false)]
		public StringValue? AppliedRuleRuleDescription { get; set; }

		[DataMember(Name="BankFeedAccount", EmitDefaultValue=false)]
		public GuidValue? BankFeedAccount { get; set; }

		[DataMember(Name="BankFeedAccountaccountNameMask", EmitDefaultValue=false)]
		public StringValue? BankFeedAccountaccountNameMask { get; set; }

		[DataMember(Name="BusinessAccount", EmitDefaultValue=false)]
		public StringValue? BusinessAccount { get; set; }

		[DataMember(Name="BusinessAccountName", EmitDefaultValue=false)]
		public StringValue? BusinessAccountName { get; set; }

		[DataMember(Name="CardNumber", EmitDefaultValue=false)]
		public StringValue? CardNumber { get; set; }

		[DataMember(Name="CashAccountID", EmitDefaultValue=false)]
		public IntValue? CashAccountID { get; set; }

		[DataMember(Name="CustomTranDesc", EmitDefaultValue=false)]
		public StringValue? CustomTranDesc { get; set; }

		[DataMember(Name="Disbursement", EmitDefaultValue=false)]
		public DecimalValue? Disbursement { get; set; }

		[DataMember(Name="EntryTypeID", EmitDefaultValue=false)]
		public StringValue? EntryTypeID { get; set; }

		[DataMember(Name="ExtRefNbr", EmitDefaultValue=false)]
		public StringValue? ExtRefNbr { get; set; }

		[DataMember(Name="ExtTranID", EmitDefaultValue=false)]
		public StringValue? ExtTranID { get; set; }

		[DataMember(Name="HeaderRefNbr", EmitDefaultValue=false)]
		public StringValue? HeaderRefNbr { get; set; }

		[DataMember(Name="Hidden", EmitDefaultValue=false)]
		public BooleanValue? Hidden { get; set; }

		[DataMember(Name="InvoiceNbr", EmitDefaultValue=false)]
		public StringValue? InvoiceNbr { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		[DataMember(Name="MatchedDocumentMatched", EmitDefaultValue=false)]
		public BooleanValue? MatchedDocumentMatched { get; set; }

		[DataMember(Name="Module", EmitDefaultValue=false)]
		public StringValue? Module { get; set; }

		[DataMember(Name="PayeePayer", EmitDefaultValue=false)]
		public StringValue? PayeePayer { get; set; }

		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		[DataMember(Name="ProcessedProcessed", EmitDefaultValue=false)]
		public BooleanValue? ProcessedProcessed { get; set; }

		[DataMember(Name="Receipt", EmitDefaultValue=false)]
		public DecimalValue? Receipt { get; set; }

		[DataMember(Name="TranCode", EmitDefaultValue=false)]
		public StringValue? TranCode { get; set; }

		[DataMember(Name="TranDate", EmitDefaultValue=false)]
		public DateTimeValue? TranDate { get; set; }

		[DataMember(Name="TranType", EmitDefaultValue=false)]
		public StringValue? TranType { get; set; }

		[DataMember(Name="TranDesc", EmitDefaultValue=false)]
		public StringValue? TranDesc { get; set; }

		[DataMember(Name="TranID", EmitDefaultValue=false)]
		public IntValue? TranID { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}