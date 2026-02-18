using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class TaxesDecreasingApplWageDetail : Entity
	{

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public StringValue? TaxCategory { get; set; }

		public StringValue? TaxCode { get; set; }

		public StringValue? TaxName { get; set; }

	}
}