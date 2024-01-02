using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class BCRoleAssignment : Entity
	{

		[DataMember(Name="RoleAssignmentID", EmitDefaultValue=false)]
		public IntValue? RoleAssignmentID { get; set; }

		[DataMember(Name="LocationCD", EmitDefaultValue=false)]
		public StringValue? LocationCD { get; set; }

		[DataMember(Name="Role", EmitDefaultValue=false)]
		public StringValue? Role { get; set; }

	}
}