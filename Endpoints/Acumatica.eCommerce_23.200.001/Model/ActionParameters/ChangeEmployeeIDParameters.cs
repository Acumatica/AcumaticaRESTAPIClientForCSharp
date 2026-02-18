using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	public class ChangeEmployeeIDParameters
	{
		public ChangeEmployeeIDParameters() { }


		public StringValue? EmployeeID { get; set; }
	}
}