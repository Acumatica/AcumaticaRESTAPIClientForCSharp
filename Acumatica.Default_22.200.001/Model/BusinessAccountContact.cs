using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class BusinessAccountContact : Entity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="City", EmitDefaultValue=false)]
		public StringValue? City { get; set; }

		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue? ContactID { get; set; }

		[DataMember(Name="DisplayName", EmitDefaultValue=false)]
		public StringValue? DisplayName { get; set; }

		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		[DataMember(Name="JobTitle", EmitDefaultValue=false)]
		public StringValue? JobTitle { get; set; }

		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		[DataMember(Name="Phone1", EmitDefaultValue=false)]
		public StringValue? Phone1 { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue? Workgroup { get; set; }

	}
}