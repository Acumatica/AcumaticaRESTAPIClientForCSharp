using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class EmployeePaidTimeOff : Entity
	{

		#region Fields
		[DataMember(Name="UsePTOBanksfromEmployeeClass", EmitDefaultValue=false)]
		public BooleanValue? UsePTOBanksfromEmployeeClass { get; set; }

		#endregion

		#region Details
		[DataMember(Name="PaidTimeOffDetails", EmitDefaultValue=false)]
		public List<EmployeePaidTimeOffDetail>? PaidTimeOffDetails { get; set; }

		#endregion

	}
}