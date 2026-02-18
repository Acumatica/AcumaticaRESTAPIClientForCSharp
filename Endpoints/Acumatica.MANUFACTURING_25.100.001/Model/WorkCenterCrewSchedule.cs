using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM405100</c> in the Acumatica ERP
	/// </summary>
	public class WorkCenterCrewSchedule : Entity, ITopLevelEntity
	{

		public List<WorkCenterCrewScheduleDetail>? Details { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleFilter</para>
		/// </summary>
		public DateTimeValue? FromDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShiftCD</para>
		/// <para>DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleFilter</para>
		/// </summary>
		public StringValue? Shift { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleFilter</para>
		/// </summary>
		public BooleanValue? ShowAll { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleFilter</para>
		/// </summary>
		public DateTimeValue? ToDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WcID</para>
		/// <para>DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleFilter</para>
		/// </summary>
		public StringValue? WorkCenter { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Details = "Details";
			public const string Details_Files = "Details/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Details,Details/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/25.100.001";
		}
	}
}