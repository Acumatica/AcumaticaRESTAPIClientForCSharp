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
	public class ChangeProjectIDParameters
	{
		public ChangeProjectIDParameters() { }

		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue? ProjectID { get; set; }
	}
}