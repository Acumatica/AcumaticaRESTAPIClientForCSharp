using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class EmployeePaidTimeOff : Entity_v4
	{

		[DataMember(Name="PaidTimeOffDetails", EmitDefaultValue=false)]
		public List<EmployeePaidTimeOffDetail> PaidTimeOffDetails { get; set; }

		[DataMember(Name="UsePTOBanksfromEmployeeClass", EmitDefaultValue=false)]
		public BooleanValue UsePTOBanksfromEmployeeClass { get; set; }

	}
}