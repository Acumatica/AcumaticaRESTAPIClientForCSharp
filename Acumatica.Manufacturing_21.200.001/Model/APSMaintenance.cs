using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class APSMaintenance : Entity, ITopLevelEntity
	{

		[DataMember(Name="CleanupHistory", EmitDefaultValue=false)]
		public BooleanValue? CleanupHistory { get; set; }

		[DataMember(Name="History", EmitDefaultValue=false)]
		public APSMaintenanceHistory? History { get; set; }

		[DataMember(Name="UpdateWorkCenterSchedulefromCalendar", EmitDefaultValue=false)]
		public BooleanValue? UpdateWorkCenterSchedulefromCalendar { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/21.200.001";
		}
	}
}