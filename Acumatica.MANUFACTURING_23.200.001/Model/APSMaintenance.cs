using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM512000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class APSMaintenance : Entity, ITopLevelEntity
	{

		/// <summary>
		/// Cleanup History
		/// DAC Field Name: IsHistoryCleanupProcess 
		/// DAC: PX.Objects.AM.AMAPSMaintenanceFilter 
		/// Display Name: Cleanup History 
		/// </summary>
		[DataMember(Name="CleanupHistory", EmitDefaultValue=false)]
		public BooleanValue? CleanupHistory { get; set; }

		[DataMember(Name="History", EmitDefaultValue=false)]
		public APSMaintenanceHistory? History { get; set; }

		/// <summary>
		/// Update Work Center Schedule from Calendar
		/// DAC Field Name: IsWorkCenterCalendarProcess 
		/// DAC: PX.Objects.AM.AMAPSMaintenanceFilter 
		/// Display Name: Update Work Center Schedule from Calendar 
		/// </summary>
		[DataMember(Name="UpdateWorkCenterSchedulefromCalendar", EmitDefaultValue=false)]
		public BooleanValue? UpdateWorkCenterSchedulefromCalendar { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}