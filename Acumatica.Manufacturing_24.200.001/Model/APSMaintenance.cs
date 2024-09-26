using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM512000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class APSMaintenance : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsHistoryCleanupProcess 
		/// DAC: PX.Objects.AM.AMAPSMaintenanceFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CleanupHistory", EmitDefaultValue=false)]
		public BooleanValue? CleanupHistory { get; set; }

		[DataMember(Name="History", EmitDefaultValue=false)]
		public APSMaintenanceHistory? History { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsWorkCenterCalendarProcess 
		/// DAC: PX.Objects.AM.AMAPSMaintenanceFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UpdateWorkCenterSchedulefromCalendar", EmitDefaultValue=false)]
		public BooleanValue? UpdateWorkCenterSchedulefromCalendar { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}