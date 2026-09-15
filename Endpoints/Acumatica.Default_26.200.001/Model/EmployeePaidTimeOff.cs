using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class EmployeePaidTimeOff : Entity
	{

		[DataMember(Name="PaidTimeOffDetails", EmitDefaultValue=false)]
		public List<EmployeePaidTimeOffDetail>? PaidTimeOffDetails { get; set; }

		/// <summary>
		/// Indicates (if set to true) that the employee is using customized paid-time-off banks instead of the default ones provided by their payroll class.
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Use Custom Settings</para>
		/// </summary>
		[DataMember(Name="UseCustomSettings", EmitDefaultValue=false)]
		public BooleanValue? UseCustomSettings { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string PaidTimeOffDetails = "PaidTimeOffDetails";

			//Intentionally excluded
			//public const string All = "PaidTimeOffDetails";
		}
	}
}