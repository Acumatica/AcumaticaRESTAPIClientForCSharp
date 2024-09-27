using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class EmployeePaidTimeOff : Entity
	{

		[DataMember(Name="PaidTimeOffDetails", EmitDefaultValue=false)]
		public List<EmployeePaidTimeOffDetail>? PaidTimeOffDetails { get; set; }

		/// <summary>
		/// Indicates (if set to true) that the employee is using customized paid-time-off banks instead of the default ones provided by their payroll class.
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Use Custom Settings 
		/// </summary>
		[DataMember(Name="UseCustomSettings", EmitDefaultValue=false)]
		public BooleanValue? UseCustomSettings { get; set; }

	}
}