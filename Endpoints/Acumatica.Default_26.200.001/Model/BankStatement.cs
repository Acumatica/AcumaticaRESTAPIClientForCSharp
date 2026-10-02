using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CA306500</c> in the Acumatica ERP
	/// </summary>
	public class BankStatement : Entity, ITopLevelEntity
	{

		#region Fields
		public DecimalValue? BeginningBalance { get; set; }

		public StringValue? CashAccount { get; set; }

		public DateTimeValue? EndBalanceDate { get; set; }

		public DecimalValue? EndingBalance { get; set; }

		public StringValue? ReferenceNbr { get; set; }

		public DateTimeValue? StartBalanceDate { get; set; }

		public DateTimeValue? StatementDate { get; set; }

		public IntValue? ExternalTranOrigin { get; set; }

		public StringValue? ExternalReference { get; set; }

		public StringValue? Type { get; set; }

		public GuidValue? NoteID { get; set; }

		public BooleanValue? ManualMatchingAllowed { get; set; }

		#endregion

		#region Details
		public List<CABankTran>? BankTransactions { get; set; }

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
			public const string Translations = "Translations";
			public const string BankTransactions = "BankTransactions";

			//Intentionally excluded
			//public const string All = "Files,Translations,BankTransactions";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}