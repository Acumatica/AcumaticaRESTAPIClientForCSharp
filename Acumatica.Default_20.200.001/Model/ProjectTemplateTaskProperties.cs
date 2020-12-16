using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ProjectTemplateTaskProperties : Entity_v4
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