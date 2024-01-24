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
	public class EmployeeDelegate : Entity
	{

		[DataMember(Name="Delegate", EmitDefaultValue=false)]
		public StringValue? Delegate { get; set; }

		[DataMember(Name="EmployeeName", EmitDefaultValue=false)]
		public StringValue? EmployeeName { get; set; }

		[DataMember(Name="DelegationOf", EmitDefaultValue=false)]
		public StringValue? DelegationOf { get; set; }

		[DataMember(Name="StartsOn", EmitDefaultValue=false)]
		public DateTimeValue? StartsOn { get; set; }

		[DataMember(Name="ExpiresOn", EmitDefaultValue=false)]
		public DateTimeValue? ExpiresOn { get; set; }

		[DataMember(Name="IsActive", EmitDefaultValue=false)]
		public BooleanValue? IsActive { get; set; }

	}
}