using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CA306500</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class BankStatement : Entity, ITopLevelEntity
	{

		[DataMember(Name="BankTransactions", EmitDefaultValue=false)]
		public List<CABankTran>? BankTransactions { get; set; }

		[DataMember(Name="BeginningBalance", EmitDefaultValue=false)]
		public DecimalValue? BeginningBalance { get; set; }

		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue? CashAccount { get; set; }

		[DataMember(Name="EndBalanceDate", EmitDefaultValue=false)]
		public DateTimeValue? EndBalanceDate { get; set; }

		[DataMember(Name="EndingBalance", EmitDefaultValue=false)]
		public DecimalValue? EndingBalance { get; set; }

		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		[DataMember(Name="StartBalanceDate", EmitDefaultValue=false)]
		public DateTimeValue? StartBalanceDate { get; set; }

		[DataMember(Name="StatementDate", EmitDefaultValue=false)]
		public DateTimeValue? StatementDate { get; set; }

		[DataMember(Name="ExternalTranOrigin", EmitDefaultValue=false)]
		public IntValue? ExternalTranOrigin { get; set; }

		[DataMember(Name="ExternalReference", EmitDefaultValue=false)]
		public StringValue? ExternalReference { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		[DataMember(Name="ManualMatchingAllowed", EmitDefaultValue=false)]
		public BooleanValue? ManualMatchingAllowed { get; set; }

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