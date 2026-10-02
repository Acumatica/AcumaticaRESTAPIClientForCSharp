using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.DeviceHub_26_100_001.Model
{
	public class PrintJobParameter : Entity
	{

		#region Fields
		public IntValue? JobID { get; set; }

		public StringValue? ParameterName { get; set; }

		public StringValue? ParameterValue { get; set; }

		#endregion

	}
}