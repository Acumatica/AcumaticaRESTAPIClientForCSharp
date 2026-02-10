using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.ISVCB_23_200_001.Model
{
	[DataContract]
	public class CloseParameters
	{
		public CloseParameters() { }

		[DataMember(Name="Reason", EmitDefaultValue=false)]
		public StringValue? Reason { get; set; }
	}
}