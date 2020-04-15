using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class ContactUserInfo : Entity
	{

		[DataMember(Name="GeneratePassword", EmitDefaultValue=false)]
		public BooleanValue GeneratePassword { get; set; }

		[DataMember(Name="Login", EmitDefaultValue=false)]
		public StringValue Login { get; set; }

		[DataMember(Name="Password", EmitDefaultValue=false)]
		public StringValue Password { get; set; }

		[DataMember(Name="Roles", EmitDefaultValue=false)]
		public List<ContactRoles> Roles { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="UserType", EmitDefaultValue=false)]
		public StringValue UserType { get; set; }

	}
}