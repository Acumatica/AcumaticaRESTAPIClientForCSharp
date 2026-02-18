using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class TaxCodeSetting : Entity
	{

		public StringValue? AdditionalInformation { get; set; }

		public StringValue? CompanyNotes { get; set; }

		public StringValue? FormBox { get; set; }

		public StringValue? Name { get; set; }

		public BooleanValue? Required { get; set; }

		public BooleanValue? UseDefault { get; set; }

		public StringValue? Value { get; set; }

	}
}