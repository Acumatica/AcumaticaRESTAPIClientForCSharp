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
	public class ContactRoles : Entity
	{

		[DataMember(Name="RoleDescription", EmitDefaultValue=false)]
		public StringValue? RoleDescription { get; set; }

		[DataMember(Name="RoleName", EmitDefaultValue=false)]
		public StringValue? RoleName { get; set; }

		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue? Selected { get; set; }

		[DataMember(Name="UserType", EmitDefaultValue=false)]
		public IntValue? UserType { get; set; }

	}
}