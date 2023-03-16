using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class SalesOrderCreditCardTransactionDetail : Entity
	{

		[DataMember(Name="AuthNbr", EmitDefaultValue=false)]
		public StringValue AuthNbr { get; set; }

		[DataMember(Name="ExtProfileId", EmitDefaultValue=false)]
		public StringValue ExtProfileId { get; set; }

		[DataMember(Name="NeedValidation", EmitDefaultValue=false)]
		public BooleanValue NeedValidation { get; set; }

		[DataMember(Name="TranDate", EmitDefaultValue=false)]
		public DateTimeValue TranDate { get; set; }

		[DataMember(Name="TranNbr", EmitDefaultValue=false)]
		public StringValue TranNbr { get; set; }

		[DataMember(Name="TranType", EmitDefaultValue=false)]
		public StringValue TranType { get; set; }

	}
}