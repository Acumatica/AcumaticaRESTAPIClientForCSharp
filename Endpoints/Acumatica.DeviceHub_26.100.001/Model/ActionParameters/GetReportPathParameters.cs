using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.DeviceHub_26_100_001.Model
{
	[DataContract]
	public class GetReportPathParameters
	{
		public GetReportPathParameters() { }

		[DataMember(Name="JobID", EmitDefaultValue=false)]
		public IntValue? JobID { get; set; }
	}
}