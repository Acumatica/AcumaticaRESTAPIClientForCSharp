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
	/// Corresponds to the screen <c>AM512000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class APSMaintenance : Entity, ITopLevelEntity
	{

		/// <summary>
		/// Cleanup History
		/// <para>DAC Field Name: IsHistoryCleanupProcess</para>
		/// <para>DAC: PX.Objects.AM.AMAPSMaintenanceFilter</para>
		/// <para>Display Name: Cleanup History</para>
		/// </summary>
		[DataMember(Name="CleanupHistory", EmitDefaultValue=false)]
		public BooleanValue? CleanupHistory { get; set; }

		[DataMember(Name="History", EmitDefaultValue=false)]
		public APSMaintenanceHistory? History { get; set; }

		/// <summary>
		/// Update Work Center Schedule from Calendar
		/// <para>DAC Field Name: IsWorkCenterCalendarProcess</para>
		/// <para>DAC: PX.Objects.AM.AMAPSMaintenanceFilter</para>
		/// <para>Display Name: Update Work Center Schedule from Calendar</para>
		/// </summary>
		[DataMember(Name="UpdateWorkCenterSchedulefromCalendar", EmitDefaultValue=false)]
		public BooleanValue? UpdateWorkCenterSchedulefromCalendar { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string History = "History";

			//Intentionally excluded
			//public const string All = "Files,History";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}