using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class DeductionDecreasingApplWageDetail : Entity
	{

		public StringValue? DeductionCode { get; set; }

		public StringValue? Description { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

	}
}