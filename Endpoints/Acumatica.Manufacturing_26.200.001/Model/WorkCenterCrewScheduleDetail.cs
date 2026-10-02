using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
{
	public class WorkCenterCrewScheduleDetail : Entity
	{

		#region Fields
		/// <summary>
		/// <para>DAC Field Name: WcID</para>
		/// <para>DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleFilter</para>
		/// </summary>
		public StringValue? WorkCenter { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShiftCD</para>
		/// <para>DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleFilter</para>
		/// </summary>
		public StringValue? Shift { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SchdBlocks</para>
		/// <para>DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleDetail</para>
		/// </summary>
		public IntValue? ScheduledBlocks { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SchdDate</para>
		/// <para>DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleDetail</para>
		/// </summary>
		public DateTimeValue? ScheduleDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleDetail</para>
		/// </summary>
		public DateTimeValue? StartTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleDetail</para>
		/// </summary>
		public DateTimeValue? EndTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleDetail</para>
		/// </summary>
		public DecimalValue? CrewSize { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleDetail</para>
		/// </summary>
		public DecimalValue? ShiftCrewSize { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleDetail</para>
		/// </summary>
		public DecimalValue? CrewSizeShortage { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleDetail</para>
		/// </summary>
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleDetail</para>
		/// </summary>
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleDetail</para>
		/// </summary>
		public StringValue? OperationID { get; set; }

		#endregion

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

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}