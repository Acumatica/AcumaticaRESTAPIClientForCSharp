using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class EmployeeWorkLocations : Entity
	{

		#region Fields
		/// <summary>
		/// <para>DAC Field Name: UsePayrollProjectWorkLocation</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Use Payroll Work Location from Project</para>
		/// </summary>
		public BooleanValue? UsePayrollWorkLocationfromProject { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UsePayrollProjectWorkLocationUseDflt</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Use Class Default Value</para>
		/// </summary>
		public BooleanValue? UseClassDefaultValueUsePayrollProjectWorkLocationUseDflt { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LocationUseDflt</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Use Class Default Work Locations</para>
		/// </summary>
		public BooleanValue? WorkLocationClassDefaults { get; set; }

		#endregion

		#region Details
		public List<EmployeeWorkLocationDetail>? WorkLocationDetails { get; set; }

		#endregion

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string WorkLocationDetails = "WorkLocationDetails";

			//Intentionally excluded
			//public const string All = "WorkLocationDetails";
		}
	}
}