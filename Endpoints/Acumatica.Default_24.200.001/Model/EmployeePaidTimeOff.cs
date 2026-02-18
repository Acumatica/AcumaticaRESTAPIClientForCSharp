using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class EmployeePaidTimeOff : Entity
	{

		public List<EmployeePaidTimeOffDetail>? PaidTimeOffDetails { get; set; }

		/// <summary>
		/// Indicates (if set to true) that the employee is using customized paid-time-off banks instead of the default ones provided by their payroll class.
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Use Custom Settings</para>
		/// </summary>
		public BooleanValue? UseCustomSettings { get; set; }

	}
}