using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class DocContact : Entity
	{

		[DataMember(Name="Attention", EmitDefaultValue=false)]
		public StringValue Attention { get; set; }

		[DataMember(Name="BusinessName", EmitDefaultValue=false)]
		public StringValue BusinessName { get; set; }

		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue Email { get; set; }

		[DataMember(Name="Phone1", EmitDefaultValue=false)]
		public StringValue Phone1 { get; set; }

	}
}