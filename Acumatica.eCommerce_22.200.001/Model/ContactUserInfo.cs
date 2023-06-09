using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
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