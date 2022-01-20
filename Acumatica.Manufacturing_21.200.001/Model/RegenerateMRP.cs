using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class RegenerateMRP : Entity_v4
	{

		[DataMember(Name="LastCompletedAt", EmitDefaultValue=false)]
		public DateTimeValue LastCompletedAt { get; set; }

		[DataMember(Name="LastCompletedBy", EmitDefaultValue=false)]
		public StringValue LastCompletedBy { get; set; }

		[DataMember(Name="Messages", EmitDefaultValue=false)]
		public List<RegenerateMRPMessage> Messages { get; set; }

	}
}