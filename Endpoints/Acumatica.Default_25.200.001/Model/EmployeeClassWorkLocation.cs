using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class EmployeeClassWorkLocation : Entity
	{

		public BooleanValue? DefaultWorkLocation { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public StringValue? LocationID { get; set; }

		public StringValue? LocationName { get; set; }

	}
}