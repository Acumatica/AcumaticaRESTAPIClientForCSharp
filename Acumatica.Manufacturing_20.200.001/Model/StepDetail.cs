using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_20_200_001.Model
{
	[DataContract]
	public class StepDetail : Entity
	{

		[DataMember(Name="Descr", EmitDefaultValue=false)]
		public StringValue Descr { get; set; }

	}
}