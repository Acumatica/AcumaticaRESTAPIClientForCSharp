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
	public class PaymentCharge : Entity
	{

		[DataMember(Name="AccountID", EmitDefaultValue=false)]
		public StringValue? AccountID { get; set; }

		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="DocType", EmitDefaultValue=false)]
		public StringValue? DocType { get; set; }

		[DataMember(Name="EntryTypeID", EmitDefaultValue=false)]
		public StringValue? EntryTypeID { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="RefNbr", EmitDefaultValue=false)]
		public StringValue? RefNbr { get; set; }

		[DataMember(Name="SubID", EmitDefaultValue=false)]
		public StringValue? SubID { get; set; }

	}
}