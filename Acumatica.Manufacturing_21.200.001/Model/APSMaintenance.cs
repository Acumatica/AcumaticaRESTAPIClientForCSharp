using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class APSMaintenance : Entity
	{

		[DataMember(Name="CleanupHistory", EmitDefaultValue=false)]
		public BooleanValue CleanupHistory { get; set; }

		[DataMember(Name="History", EmitDefaultValue=false)]
		public APSMaintenanceHistory History { get; set; }

		[DataMember(Name="UpdateWorkCenterSchedulefromCalendar", EmitDefaultValue=false)]
		public BooleanValue UpdateWorkCenterSchedulefromCalendar { get; set; }

	}
}