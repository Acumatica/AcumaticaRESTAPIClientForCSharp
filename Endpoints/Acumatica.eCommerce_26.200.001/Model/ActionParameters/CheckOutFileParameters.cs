using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_26_200_001.Model
{
	public class CheckOutFileParameters
	{
		public CheckOutFileParameters() { }


		public StringValue? Comment { get; set; }

		public GuidValue? FileID { get; set; }
	}
}