using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	[DataContract]
	public class DirectDepositDetail : Entity
	{

		[DataMember(Name="AccountNumber", EmitDefaultValue=false)]
		public StringValue? AccountNumber { get; set; }

		[DataMember(Name="AccountType", EmitDefaultValue=false)]
		public StringValue? AccountType { get; set; }

		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		[DataMember(Name="BankName", EmitDefaultValue=false)]
		public StringValue? BankName { get; set; }

		[DataMember(Name="BankRoutingNumber", EmitDefaultValue=false)]
		public StringValue? BankRoutingNumber { get; set; }

		[DataMember(Name="DepositSequenceNbr", EmitDefaultValue=false)]
		public IntValue? DepositSequenceNbr { get; set; }

		[DataMember(Name="GetsRemainder", EmitDefaultValue=false)]
		public BooleanValue? GetsRemainder { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="Percent", EmitDefaultValue=false)]
		public DecimalValue? Percent { get; set; }

	}
}