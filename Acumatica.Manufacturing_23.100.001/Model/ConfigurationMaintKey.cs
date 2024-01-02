using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class ConfigurationMaintKey : Entity
	{

		[DataMember(Name="Format", EmitDefaultValue=false)]
		public StringValue? Format { get; set; }

		[DataMember(Name="Formula", EmitDefaultValue=false)]
		public StringValue? Formula { get; set; }

		[DataMember(Name="KeyDescription", EmitDefaultValue=false)]
		public StringValue? KeyDescription { get; set; }

		[DataMember(Name="NumberSequence", EmitDefaultValue=false)]
		public StringValue? NumberSequence { get; set; }

		[DataMember(Name="TranDescription", EmitDefaultValue=false)]
		public StringValue? TranDescription { get; set; }

	}
}