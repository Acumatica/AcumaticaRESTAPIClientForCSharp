using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_18_200_001.Model
{
	[DataContract]
	public class StepDetail : Entity_v3
	{

		[DataMember(Name="Descr", EmitDefaultValue=false)]
		public StringValue Descr { get; set; }

	}
}