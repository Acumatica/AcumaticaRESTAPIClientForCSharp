using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class DefaultTaskForGLAccount : Entity
	{

		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue Account { get; set; }

		[DataMember(Name="DefaultTask", EmitDefaultValue=false)]
		public StringValue DefaultTask { get; set; }

	}
}