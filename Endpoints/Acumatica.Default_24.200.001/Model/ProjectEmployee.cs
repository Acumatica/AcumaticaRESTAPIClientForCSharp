using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class ProjectEmployee : Entity
	{

		public StringValue? Department { get; set; }

		public StringValue? EmployeeID { get; set; }

		public StringValue? EmployeeName { get; set; }

	}
}