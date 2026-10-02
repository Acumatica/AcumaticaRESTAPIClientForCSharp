using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	[DataContract]
	public class EmployeePaidTimeOff : Entity
	{

		#region Fields
		/// <summary>
		/// Indicates (if set to true) that the employee is using customized paid-time-off banks instead of the default ones provided by their payroll class.
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Use Custom Settings</para>
		/// </summary>
		[DataMember(Name="UseCustomSettings", EmitDefaultValue=false)]
		public BooleanValue? UseCustomSettings { get; set; }

		#endregion

		#region Details
		[DataMember(Name="PaidTimeOffDetails", EmitDefaultValue=false)]
		public List<EmployeePaidTimeOffDetail>? PaidTimeOffDetails { get; set; }

		#endregion

	}
}