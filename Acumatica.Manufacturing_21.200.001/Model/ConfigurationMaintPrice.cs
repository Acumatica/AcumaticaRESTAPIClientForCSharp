using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class ConfigurationMaintPrice : Entity_v4
	{

		[DataMember(Name="Calculate", EmitDefaultValue=false)]
		public StringValue Calculate { get; set; }

		[DataMember(Name="Rollup", EmitDefaultValue=false)]
		public StringValue Rollup { get; set; }

	}
}