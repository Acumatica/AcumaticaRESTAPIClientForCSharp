using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public partial class ReminderDetail : Entity
	{

		[DataMember(Name="IsActive", EmitDefaultValue=false)]
		public BooleanValue IsActive { get; set; }

		[DataMember(Name="RemindAtDate", EmitDefaultValue=false)]
		public DateTimeValue RemindAtDate { get; set; }

		[DataMember(Name="RemindAtTime", EmitDefaultValue=false)]
		public DateTimeValue RemindAtTime { get; set; }

	}
}