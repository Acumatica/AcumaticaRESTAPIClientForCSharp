using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class DirectDepositDetail : Entity
	{

		#region Fields
		/// <summary>
		/// <para>DAC Field Name: BankAcctNbr</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeDirectDeposit</para>
		/// <para>Display Name: Account Number</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? AccountNumber { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BankAcctType</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeDirectDeposit</para>
		/// <para>Display Name: Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? AccountType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeDirectDeposit</para>
		/// <para>Display Name: Bank Name</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? BankName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BankRoutingNbr</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeDirectDeposit</para>
		/// <para>Display Name: Bank Routing Number</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? BankRoutingNumber { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeDirectDeposit</para>
		/// </summary>
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeDirectDeposit</para>
		/// </summary>
		public DecimalValue? Percent { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SortOrder</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeDirectDeposit</para>
		/// <para>Display Name: Sequence</para>
		/// </summary>
		public IntValue? DepositSequenceNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeDirectDeposit</para>
		/// <para>Display Name: Gets Remainder</para>
		/// </summary>
		public BooleanValue? GetsRemainder { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

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