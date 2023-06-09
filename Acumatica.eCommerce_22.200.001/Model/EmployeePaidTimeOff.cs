using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class EmployeePaidTimeOff : Entity
	{

		[DataMember(Name="PaidTimeOffDetails", EmitDefaultValue=false)]
		public List<EmployeePaidTimeOffDetail> PaidTimeOffDetails { get; set; }

		[DataMember(Name="UsePTOBanksfromEmployeeClass", EmitDefaultValue=false)]
		public BooleanValue UsePTOBanksfromEmployeeClass { get; set; }

	}
}