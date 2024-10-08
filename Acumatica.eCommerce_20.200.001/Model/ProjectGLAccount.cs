using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class ProjectGLAccount : Entity
	{

		[DataMember(Name="AccrualAccount", EmitDefaultValue=false)]
		public StringValue? AccrualAccount { get; set; }

		[DataMember(Name="AccrualSubaccount", EmitDefaultValue=false)]
		public StringValue? AccrualSubaccount { get; set; }

		[DataMember(Name="DefaultAccount", EmitDefaultValue=false)]
		public StringValue? DefaultAccount { get; set; }

		[DataMember(Name="DefaultSubaccount", EmitDefaultValue=false)]
		public StringValue? DefaultSubaccount { get; set; }

		[DataMember(Name="DefaultTaskForGLAccounts", EmitDefaultValue=false)]
		public List<DefaultTaskForGLAccount>? DefaultTaskForGLAccounts { get; set; }

	}
}