using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class DirectDepositDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: BankAcctNbr 
		/// DAC: PX.Objects.PR.PREmployeeDirectDeposit 
		/// Display Name: Account Number 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="AccountNumber", EmitDefaultValue=false)]
		public StringValue? AccountNumber { get; set; }

		/// <summary>
		/// DAC Field Name: BankAcctType 
		/// DAC: PX.Objects.PR.PREmployeeDirectDeposit 
		/// Display Name: Type 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="AccountType", EmitDefaultValue=false)]
		public StringValue? AccountType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PREmployeeDirectDeposit 
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PREmployeeDirectDeposit 
		/// Display Name: Bank Name 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="BankName", EmitDefaultValue=false)]
		public StringValue? BankName { get; set; }

		/// <summary>
		/// DAC Field Name: BankRoutingNbr 
		/// DAC: PX.Objects.PR.PREmployeeDirectDeposit 
		/// Display Name: Bank Routing Number 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="BankRoutingNumber", EmitDefaultValue=false)]
		public StringValue? BankRoutingNumber { get; set; }

		/// <summary>
		/// DAC Field Name: SortOrder 
		/// DAC: PX.Objects.PR.PREmployeeDirectDeposit 
		/// Display Name: Sequence 
		/// </summary>
		[DataMember(Name="DepositSequenceNbr", EmitDefaultValue=false)]
		public IntValue? DepositSequenceNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PREmployeeDirectDeposit 
		/// Display Name: Gets Remainder 
		/// </summary>
		[DataMember(Name="GetsRemainder", EmitDefaultValue=false)]
		public BooleanValue? GetsRemainder { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PREmployeeDirectDeposit 
		/// </summary>
		[DataMember(Name="Percent", EmitDefaultValue=false)]
		public DecimalValue? Percent { get; set; }

	}
}