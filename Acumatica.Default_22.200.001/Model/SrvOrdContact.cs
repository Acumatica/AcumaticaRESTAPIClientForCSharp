using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class SrvOrdContact : Entity
	{

		[DataMember(Name="Attention", EmitDefaultValue=false)]
		public StringValue? Attention { get; set; }

		[DataMember(Name="CompanyName", EmitDefaultValue=false)]
		public StringValue? CompanyName { get; set; }

		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		[DataMember(Name="Phone1", EmitDefaultValue=false)]
		public StringValue? Phone1 { get; set; }

		[DataMember(Name="Phone1Type", EmitDefaultValue=false)]
		public StringValue? Phone1Type { get; set; }

	}
}