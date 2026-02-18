using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.DeviceHub_23_200_001.Model
{
	public class PrintJobParameter : Entity
	{

		public IntValue? JobID { get; set; }

		public StringValue? ParameterName { get; set; }

		public StringValue? ParameterValue { get; set; }

	}
}