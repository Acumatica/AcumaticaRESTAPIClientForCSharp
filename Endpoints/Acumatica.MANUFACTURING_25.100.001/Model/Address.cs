using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class Address : Entity
	{

		public StringValue? AddressLine1 { get; set; }

		public StringValue? AddressLine2 { get; set; }

		public StringValue? City { get; set; }

		public StringValue? Country { get; set; }

		public StringValue? PostalCode { get; set; }

		public StringValue? State { get; set; }

		public BooleanValue? Validated { get; set; }

	}
}