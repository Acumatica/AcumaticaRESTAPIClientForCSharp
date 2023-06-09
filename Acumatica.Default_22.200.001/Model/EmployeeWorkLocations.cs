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

		[DataMember(Name="UseClassDefaultValueUsePayrollProjectWorkLocationUseDflt", EmitDefaultValue=false)]
		public BooleanValue UseClassDefaultValueUsePayrollProjectWorkLocationUseDflt { get; set; }

		[DataMember(Name="UsePayrollWorkLocationfromProject", EmitDefaultValue=false)]
		public BooleanValue UsePayrollWorkLocationfromProject { get; set; }

		[DataMember(Name="WorkLocationClassDefaults", EmitDefaultValue=false)]
		public BooleanValue WorkLocationClassDefaults { get; set; }

		[DataMember(Name="WorkLocationDetails", EmitDefaultValue=false)]
		public List<EmployeeWorkLocationDetail> WorkLocationDetails { get; set; }

	}
}