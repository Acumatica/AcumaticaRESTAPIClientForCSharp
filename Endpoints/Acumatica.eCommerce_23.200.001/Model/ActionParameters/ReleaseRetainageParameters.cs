using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	public class ReleaseRetainageParameters
	{
		public ReleaseRetainageParameters() { }


		public DecimalValue? AmtToRelease { get; set; }

		public DateTimeValue? Date { get; set; }

		public StringValue? PostPeriod { get; set; }
	}
}