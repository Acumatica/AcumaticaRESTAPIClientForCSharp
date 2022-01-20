using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.DeviceHub_19_200_001.Model
{
	[DataContract]
	public class PrintJobParameter : Entity_v3
	{

		[DataMember(Name="JobID", EmitDefaultValue=false)]
		public IntValue JobID { get; set; }

		[DataMember(Name="ParameterName", EmitDefaultValue=false)]
		public StringValue ParameterName { get; set; }

		[DataMember(Name="ParameterValue", EmitDefaultValue=false)]
		public StringValue ParameterValue { get; set; }

	}
}