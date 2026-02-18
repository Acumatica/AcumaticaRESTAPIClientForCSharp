using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class DuplicateDetail : Entity
	{

		public StringValue? AccountName { get; set; }

		public StringValue? BusinessAccount { get; set; }

		public StringValue? BusinessAccountType { get; set; }

		public IntValue? ContactID { get; set; }

		public StringValue? DisplayName { get; set; }

		public StringValue? Duplicate { get; set; }

		public IntValue? DuplicateContactID { get; set; }

		public StringValue? Email { get; set; }

		public StringValue? EntityType { get; set; }

		public DateTimeValue? LastModifiedDate { get; set; }

		public StringValue? Type { get; set; }

	}
}