using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class CreditCardTransactionDetail : Entity
	{

		[DataMember(Name="TranNbr", EmitDefaultValue=false)]
		public StringValue? TranNbr { get; set; }

		[DataMember(Name="TranType", EmitDefaultValue=false)]
		public StringValue? TranType { get; set; }

		[DataMember(Name="AuthNbr", EmitDefaultValue=false)]
		public StringValue? AuthNbr { get; set; }

		[DataMember(Name="TranDate", EmitDefaultValue=false)]
		public DateTimeValue? TranDate { get; set; }

		[DataMember(Name="ExtProfileId", EmitDefaultValue=false)]
		public StringValue? ExtProfileId { get; set; }

		[DataMember(Name="NeedValidation", EmitDefaultValue=false)]
		public BooleanValue? NeedValidation { get; set; }

		[DataMember(Name="OrigTranNbr", EmitDefaultValue=false)]
		public StringValue? OrigTranNbr { get; set; }

		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		[DataMember(Name="CardType", EmitDefaultValue=false)]
		public StringValue? CardType { get; set; }

	}
}