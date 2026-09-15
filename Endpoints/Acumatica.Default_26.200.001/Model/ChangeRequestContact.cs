using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class ChangeRequestContact : Entity
	{

		[DataMember(Name="AccountName", EmitDefaultValue=false)]
		public StringValue? AccountName { get; set; }

		[DataMember(Name="Attention", EmitDefaultValue=false)]
		public StringValue? Attention { get; set; }

		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		[DataMember(Name="OverrideContact", EmitDefaultValue=false)]
		public BooleanValue? OverrideContact { get; set; }

		[DataMember(Name="Phone1", EmitDefaultValue=false)]
		public StringValue? Phone1 { get; set; }

		[DataMember(Name="Phone1Type", EmitDefaultValue=false)]
		public StringValue? Phone1Type { get; set; }

		[DataMember(Name="Phone2", EmitDefaultValue=false)]
		public StringValue? Phone2 { get; set; }

		[DataMember(Name="Phone2Type", EmitDefaultValue=false)]
		public StringValue? Phone2Type { get; set; }

	}
}