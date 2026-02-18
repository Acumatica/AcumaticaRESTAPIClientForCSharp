using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class EarningIncreasingApplWageDetail : Entity
	{

		public StringValue? Description { get; set; }

		public StringValue? EarningTypeCategory { get; set; }

		public StringValue? EarningTypeCode { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

	}
}