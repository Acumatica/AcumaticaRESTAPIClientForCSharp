using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.ISVCB_23_200_001.Model
{
	[DataContract]
	public class ISVContactsDetail : Entity
	{

		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue? ContactID { get; set; }

		[DataMember(Name="Contact", EmitDefaultValue=false)]
		public StringValue? Contact { get; set; }

		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		[DataMember(Name="EmployeeID", EmitDefaultValue=false)]
		public StringValue? EmployeeID { get; set; }

		[DataMember(Name="EmployeeName", EmitDefaultValue=false)]
		public StringValue? EmployeeName { get; set; }

		[DataMember(Name="ContactStatus", EmitDefaultValue=false)]
		public StringValue? ContactStatus { get; set; }

		[DataMember(Name="EmployeeStatus", EmitDefaultValue=false)]
		public StringValue? EmployeeStatus { get; set; }

		[DataMember(Name="Login", EmitDefaultValue=false)]
		public StringValue? Login { get; set; }

		[DataMember(Name="UserStatus", EmitDefaultValue=false)]
		public StringValue? UserStatus { get; set; }

	}
}