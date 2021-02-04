using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_20_200_001.Model
{
	[DataContract]
	public class RegenerateMRPMessage : Entity_v4
	{

		[DataMember(Name="CreatedAt", EmitDefaultValue=false)]
		public DateTimeValue CreatedAt { get; set; }

		[DataMember(Name="CreatedBy", EmitDefaultValue=false)]
		public StringValue CreatedBy { get; set; }

		[DataMember(Name="CreatedScreenID", EmitDefaultValue=false)]
		public StringValue CreatedScreenID { get; set; }

		[DataMember(Name="Message", EmitDefaultValue=false)]
		public StringValue Message { get; set; }

		[DataMember(Name="MessageType", EmitDefaultValue=false)]
		public StringValue MessageType { get; set; }

		[DataMember(Name="ProcessID", EmitDefaultValue=false)]
		public GuidValue ProcessID { get; set; }

		[DataMember(Name="Recno", EmitDefaultValue=false)]
		public IntValue Recno { get; set; }

	}
}