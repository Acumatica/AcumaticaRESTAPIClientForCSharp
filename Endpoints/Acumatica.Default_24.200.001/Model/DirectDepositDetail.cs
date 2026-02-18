using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class DirectDepositDetail : Entity
	{

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
		/// </summary>
		public DecimalValue? Amount { get; set; }

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

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeDirectDeposit</para>
		/// </summary>
		public DecimalValue? Percent { get; set; }

	}
}