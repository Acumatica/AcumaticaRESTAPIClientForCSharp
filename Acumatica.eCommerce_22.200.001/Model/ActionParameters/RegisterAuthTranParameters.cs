using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class RegisterAuthTranParameters
	{
		public RegisterAuthTranParameters() { }

		[DataMember(Name="PaymentGatewayCreateProfile", EmitDefaultValue=false)]
		public StringValue? PaymentGatewayCreateProfile { get; set; }
		[DataMember(Name="PaymentGatewayTranID", EmitDefaultValue=false)]
		public StringValue? PaymentGatewayTranID { get; set; }
	}
}