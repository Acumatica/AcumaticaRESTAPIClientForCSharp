using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ReminderDetail : Entity_v4
	{

		[DataMember(Name="IsActive", EmitDefaultValue=false)]
		public BooleanValue IsActive { get; set; }

		[DataMember(Name="RemindAtDate", EmitDefaultValue=false)]
		public DateTimeValue RemindAtDate { get; set; }

		[DataMember(Name="RemindAtTime", EmitDefaultValue=false)]
		public DateTimeValue RemindAtTime { get; set; }

	}
}