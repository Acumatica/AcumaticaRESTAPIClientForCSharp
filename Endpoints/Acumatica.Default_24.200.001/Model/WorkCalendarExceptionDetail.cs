using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class WorkCalendarExceptionDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSCalendarExceptions</para>
		/// Key Field
		/// </summary>
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSCalendarExceptions</para>
		/// <para>Display Name: Day Of Week</para>
		/// </summary>
		public StringValue? DayOfWeek { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSCalendarExceptions</para>
		/// <para>Display Name: End Time</para>
		/// </summary>
		public DateTimeValue? EndTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSCalendarExceptions</para>
		/// <para>Display Name: Start Time</para>
		/// </summary>
		public DateTimeValue? StartTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnpaidTime</para>
		/// <para>DAC: PX.Objects.CS.CSCalendarExceptions</para>
		/// <para>Display Name: Break Duration</para>
		/// </summary>
		public StringValue? UnpaidBreakTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSCalendarExceptions</para>
		/// <para>Display Name: Work Day</para>
		/// </summary>
		public BooleanValue? WorkDay { get; set; }

	}
}