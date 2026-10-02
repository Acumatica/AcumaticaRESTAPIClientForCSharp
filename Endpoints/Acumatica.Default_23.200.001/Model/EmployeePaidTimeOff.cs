using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class EmployeePaidTimeOff : Entity
	{

		#region Fields
		public BooleanValue? UsePTOBanksfromEmployeeClass { get; set; }

		#endregion

		#region Details
		public List<EmployeePaidTimeOffDetail>? PaidTimeOffDetails { get; set; }

		#endregion

	}
}