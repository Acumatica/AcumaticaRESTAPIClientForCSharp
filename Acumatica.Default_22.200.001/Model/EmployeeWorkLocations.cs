using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class EmployeeWorkLocations : Entity
	{

		/// <summary>
		/// DAC Field Name: UsePayrollProjectWorkLocationUseDflt 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Use Class Default Value 
		/// </summary>
		[DataMember(Name="UseClassDefaultValueUsePayrollProjectWorkLocationUseDflt", EmitDefaultValue=false)]
		public BooleanValue? UseClassDefaultValueUsePayrollProjectWorkLocationUseDflt { get; set; }

		/// <summary>
		/// DAC Field Name: UsePayrollProjectWorkLocation 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Use Payroll Work Location from Project 
		/// </summary>
		[DataMember(Name="UsePayrollWorkLocationfromProject", EmitDefaultValue=false)]
		public BooleanValue? UsePayrollWorkLocationfromProject { get; set; }

		/// <summary>
		/// DAC Field Name: LocationUseDflt 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Use Class Default Work Locations 
		/// </summary>
		[DataMember(Name="WorkLocationClassDefaults", EmitDefaultValue=false)]
		public BooleanValue? WorkLocationClassDefaults { get; set; }

		[DataMember(Name="WorkLocationDetails", EmitDefaultValue=false)]
		public List<EmployeeWorkLocationDetail>? WorkLocationDetails { get; set; }

	}
}