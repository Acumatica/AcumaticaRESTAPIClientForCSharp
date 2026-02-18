using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class BillToSettings : Entity
	{

		public Address? BillToAddress { get; set; }

		public BooleanValue? BillToAddressOverride { get; set; }

		public DocContact? BillToContact { get; set; }

		public BooleanValue? BillToContactOverride { get; set; }

		public StringValue? CustomerLocation { get; set; }

	}
}