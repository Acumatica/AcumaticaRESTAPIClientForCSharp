using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_26_200_001.Model
{
	public class UnlinkFileParameters
	{
		public UnlinkFileParameters() { }


		public GuidValue? Document { get; set; }

		public StringValue? DocumentNumber { get; set; }

		public GuidValue? FileID { get; set; }

		public StringValue? ProjectID { get; set; }

		public StringSingleSelectValue? RecordType { get; set; }
	}
}