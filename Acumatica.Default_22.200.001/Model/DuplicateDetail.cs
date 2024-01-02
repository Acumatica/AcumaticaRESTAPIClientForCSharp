using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class DuplicateDetail : Entity
	{

		[DataMember(Name="AccountName", EmitDefaultValue=false)]
		public StringValue? AccountName { get; set; }

		[DataMember(Name="BusinessAccount", EmitDefaultValue=false)]
		public StringValue? BusinessAccount { get; set; }

		[DataMember(Name="BusinessAccountType", EmitDefaultValue=false)]
		public StringValue? BusinessAccountType { get; set; }

		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue? ContactID { get; set; }

		[DataMember(Name="DisplayName", EmitDefaultValue=false)]
		public StringValue? DisplayName { get; set; }

		[DataMember(Name="Duplicate", EmitDefaultValue=false)]
		public StringValue? Duplicate { get; set; }

		[DataMember(Name="DuplicateContactID", EmitDefaultValue=false)]
		public IntValue? DuplicateContactID { get; set; }

		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		[DataMember(Name="EntityType", EmitDefaultValue=false)]
		public StringValue? EntityType { get; set; }

		[DataMember(Name="LastModifiedDate", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDate { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

	}
}