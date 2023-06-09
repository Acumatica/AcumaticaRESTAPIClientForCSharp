using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class ProjectTemplateTaskProperties : Entity
	{

		[DataMember(Name="Approver", EmitDefaultValue=false)]
		public StringValue Approver { get; set; }

		[DataMember(Name="AutomaticallyIncludeInProject", EmitDefaultValue=false)]
		public BooleanValue AutomaticallyIncludeInProject { get; set; }

		[DataMember(Name="CompletionMethod", EmitDefaultValue=false)]
		public StringValue CompletionMethod { get; set; }

		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue Default { get; set; }

	}
}