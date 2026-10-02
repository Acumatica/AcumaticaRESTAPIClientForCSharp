using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class CABankTran : Entity
	{

		#region Fields
		public IntValue? AppliedRule { get; set; }

		public StringValue? AppliedRuleRuleDescription { get; set; }

		public GuidValue? BankFeedAccount { get; set; }

		public StringValue? BankFeedAccountaccountNameMask { get; set; }

		public StringValue? BusinessAccount { get; set; }

		public StringValue? BusinessAccountName { get; set; }

		public StringValue? CardNumber { get; set; }

		public IntValue? CashAccountID { get; set; }

		public StringValue? CustomTranDesc { get; set; }

		public DecimalValue? Disbursement { get; set; }

		public StringValue? EntryTypeID { get; set; }

		public StringValue? ExtRefNbr { get; set; }

		public StringValue? ExtTranID { get; set; }

		public StringValue? HeaderRefNbr { get; set; }

		public BooleanValue? Hidden { get; set; }

		public StringValue? InvoiceNbr { get; set; }

		public StringValue? Location { get; set; }

		public BooleanValue? MatchedDocumentMatched { get; set; }

		public StringValue? Module { get; set; }

		public StringValue? PayeePayer { get; set; }

		public StringValue? PaymentMethod { get; set; }

		public BooleanValue? ProcessedProcessed { get; set; }

		public DecimalValue? Receipt { get; set; }

		public StringValue? TranCode { get; set; }

		public DateTimeValue? TranDate { get; set; }

		public StringValue? TranType { get; set; }

		public StringValue? TranDesc { get; set; }

		public IntValue? TranID { get; set; }

		#endregion

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