using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM512000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class APSMaintenance : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: IsHistoryCleanupProcess</para>
		/// <para>DAC: PX.Objects.AM.AMAPSMaintenanceFilter</para>
		/// </summary>
		[DataMember(Name="CleanupHistory", EmitDefaultValue=false)]
		public BooleanValue? CleanupHistory { get; set; }

		[DataMember(Name="History", EmitDefaultValue=false)]
		public APSMaintenanceHistory? History { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsWorkCenterCalendarProcess</para>
		/// <para>DAC: PX.Objects.AM.AMAPSMaintenanceFilter</para>
		/// </summary>
		[DataMember(Name="UpdateWorkCenterSchedulefromCalendar", EmitDefaultValue=false)]
		public BooleanValue? UpdateWorkCenterSchedulefromCalendar { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string History = "History";

			//Intentionally excluded
			//public const string All = "Files,Translations,History";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/26.200.001";
		}
	}
}