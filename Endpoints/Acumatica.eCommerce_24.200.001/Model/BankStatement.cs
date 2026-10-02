using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
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

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string BankTransactions = "BankTransactions";
			public const string BankTransactions_Files = "BankTransactions/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,BankTransactions,BankTransactions/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/24.200.001";
		}
	}
}