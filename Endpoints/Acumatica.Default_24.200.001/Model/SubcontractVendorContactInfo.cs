using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class SubcontractVendorContactInfo : Entity
	{

		public StringValue? AccountName { get; set; }

		public StringValue? Email { get; set; }

		public StringValue? JobTitle { get; set; }

		public BooleanValue? VendorContactOverride { get; set; }

		public StringValue? Phone { get; set; }

	}
}