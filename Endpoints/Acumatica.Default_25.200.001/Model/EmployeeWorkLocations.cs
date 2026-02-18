using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class EmployeeWorkLocations : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: UsePayrollProjectWorkLocationUseDflt</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Use Class Default Value</para>
		/// </summary>
		public BooleanValue? UseClassDefaultValueUsePayrollProjectWorkLocationUseDflt { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UsePayrollProjectWorkLocation</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Use Payroll Work Location from Project</para>
		/// </summary>
		public BooleanValue? UsePayrollWorkLocationfromProject { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LocationUseDflt</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Use Class Default Work Locations</para>
		/// </summary>
		public BooleanValue? WorkLocationClassDefaults { get; set; }

		public List<EmployeeWorkLocationDetail>? WorkLocationDetails { get; set; }

	}
}