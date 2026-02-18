using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class CreateContactFromVendorParameters
	{
		public CreateContactFromVendorParameters() { }


		public StringValue? FirstName { get; set; }

		public StringValue? LastName { get; set; }

		public StringValue? JobTitle { get; set; }

		public StringValue? Phone1Type { get; set; }

		public StringValue? Phone1 { get; set; }

		public StringValue? Phone2Type { get; set; }

		public StringValue? Phone2 { get; set; }

		public StringValue? Email { get; set; }

		public StringValue? ContactClass { get; set; }
	}
}