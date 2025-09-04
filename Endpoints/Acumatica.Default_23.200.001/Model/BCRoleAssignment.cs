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
	public class BCRoleAssignment : Entity
	{

		[DataMember(Name="RoleAssignmentID", EmitDefaultValue=false)]
		public IntValue? RoleAssignmentID { get; set; }

		[DataMember(Name="BAccountID", EmitDefaultValue=false)]
		public IntValue? BAccountID { get; set; }

		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue? ContactID { get; set; }

		[DataMember(Name="LocationCD", EmitDefaultValue=false)]
		public StringValue? LocationCD { get; set; }

		[DataMember(Name="Role", EmitDefaultValue=false)]
		public StringValue? Role { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

	}
}