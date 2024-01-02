using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class CardOperationParameters
	{
		public CardOperationParameters() { }

		[DataMember(Name="TranType", EmitDefaultValue=false)]
		public StringValue? TranType { get; set; }
		[DataMember(Name="TranNbr", EmitDefaultValue=false)]
		public StringValue? TranNbr { get; set; }
		[DataMember(Name="AuthNumber", EmitDefaultValue=false)]
		public StringValue? AuthNumber { get; set; }
		[DataMember(Name="ExtProfileId", EmitDefaultValue=false)]
		public StringValue? ExtProfileId { get; set; }
		[DataMember(Name="TranDate", EmitDefaultValue=false)]
		public DateTimeValue? TranDate { get; set; }
		[DataMember(Name="OrigTranNbr", EmitDefaultValue=false)]
		public StringValue? OrigTranNbr { get; set; }
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }
	}
}