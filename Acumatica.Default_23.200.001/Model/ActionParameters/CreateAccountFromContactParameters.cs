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
	public class CreateAccountFromContactParameters
	{
		public CreateAccountFromContactParameters() { }

		[DataMember(Name="BusinessAccountID", EmitDefaultValue=false)]
		public StringValue? BusinessAccountID { get; set; }
		[DataMember(Name="BusinessAccountName", EmitDefaultValue=false)]
		public StringValue? BusinessAccountName { get; set; }
		[DataMember(Name="BusinessAccountClass", EmitDefaultValue=false)]
		public StringValue? BusinessAccountClass { get; set; }
	}
}