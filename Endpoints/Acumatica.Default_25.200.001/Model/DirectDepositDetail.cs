using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	[DataContract]
	public class DirectDepositDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: BankAcctNbr</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeDirectDeposit</para>
		/// <para>Display Name: Account Number</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="AccountNumber", EmitDefaultValue=false)]
		public StringValue? AccountNumber { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BankAcctType</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeDirectDeposit</para>
		/// <para>Display Name: Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="AccountType", EmitDefaultValue=false)]
		public StringValue? AccountType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeDirectDeposit</para>
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeDirectDeposit</para>
		/// <para>Display Name: Bank Name</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="BankName", EmitDefaultValue=false)]
		public StringValue? BankName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BankRoutingNbr</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeDirectDeposit</para>
		/// <para>Display Name: Bank Routing Number</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="BankRoutingNumber", EmitDefaultValue=false)]
		public StringValue? BankRoutingNumber { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SortOrder</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeDirectDeposit</para>
		/// <para>Display Name: Sequence</para>
		/// </summary>
		[DataMember(Name="DepositSequenceNbr", EmitDefaultValue=false)]
		public IntValue? DepositSequenceNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeDirectDeposit</para>
		/// <para>Display Name: Gets Remainder</para>
		/// </summary>
		[DataMember(Name="GetsRemainder", EmitDefaultValue=false)]
		public BooleanValue? GetsRemainder { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeDirectDeposit</para>
		/// </summary>
		[DataMember(Name="Percent", EmitDefaultValue=false)]
		public DecimalValue? Percent { get; set; }

	}
}