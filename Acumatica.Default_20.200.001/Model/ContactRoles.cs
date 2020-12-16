using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ContactRoles : Entity_v4
	{

		[DataMember(Name="RoleDescription", EmitDefaultValue=false)]
		public StringValue RoleDescription { get; set; }

		[DataMember(Name="RoleName", EmitDefaultValue=false)]
		public StringValue RoleName { get; set; }

		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue Selected { get; set; }

		[DataMember(Name="UserType", EmitDefaultValue=false)]
		public IntValue UserType { get; set; }

	}
}