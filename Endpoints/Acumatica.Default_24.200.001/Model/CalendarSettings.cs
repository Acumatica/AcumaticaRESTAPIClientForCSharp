using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class CalendarSettings : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: FriWorkDay</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// </summary>
		public BooleanValue? Friday { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FriEndTime</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// <para>Display Name: Friday End Time</para>
		/// </summary>
		public DateTimeValue? FridayEndTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FriStartTime</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// <para>Display Name: Friday Start Time</para>
		/// </summary>
		public DateTimeValue? FridayStartTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FriUnpaidTime</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// <para>Display Name: Fri Unpaid Break Time</para>
		/// </summary>
		public StringValue? FriUnpaidBreakTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MonWorkDay</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// </summary>
		public BooleanValue? Monday { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MonEndTime</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// <para>Display Name: Monday End Time</para>
		/// </summary>
		public DateTimeValue? MondayEndTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MonStartTime</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// <para>Display Name: Monday Start Time</para>
		/// </summary>
		public DateTimeValue? MondayStartTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MonUnpaidTime</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// <para>Display Name: Mon Unpaid Break Time</para>
		/// </summary>
		public StringValue? MonUnpaidBreakTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SatUnpaidTime</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// <para>Display Name: Sat Unpaid Break Time</para>
		/// </summary>
		public StringValue? SatUnpaidBreakTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SatWorkDay</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// </summary>
		public BooleanValue? Saturday { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SatEndTime</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// <para>Display Name: Saturday End Time</para>
		/// </summary>
		public DateTimeValue? SaturdayEndTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SatStartTime</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// <para>Display Name: Saturday Start Time</para>
		/// </summary>
		public DateTimeValue? SaturdayStartTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SunWorkDay</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// </summary>
		public BooleanValue? Sunday { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SunEndTime</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// <para>Display Name: Sunday End Time</para>
		/// </summary>
		public DateTimeValue? SundayEndTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SunStartTime</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// <para>Display Name: Sunday Start Time</para>
		/// </summary>
		public DateTimeValue? SundayStartTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SunUnpaidTime</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// <para>Display Name: Sun Unpaid Break Time</para>
		/// </summary>
		public StringValue? SunUnpaidBreakTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ThuWorkDay</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// </summary>
		public BooleanValue? Thursday { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ThuEndTime</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// <para>Display Name: Thursday End Time</para>
		/// </summary>
		public DateTimeValue? ThursdayEndTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ThuStartTime</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// <para>Display Name: Thursday Start Time</para>
		/// </summary>
		public DateTimeValue? ThursdayStartTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ThuUnpaidTime</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// <para>Display Name: Thu Unpaid Break Time</para>
		/// </summary>
		public StringValue? ThuUnpaidBreakTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TueWorkDay</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// </summary>
		public BooleanValue? Tuesday { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TueEndTime</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// <para>Display Name: Tuesday End Time</para>
		/// </summary>
		public DateTimeValue? TuesdayEndTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TueStartTime</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// <para>Display Name: Tuesday Start Time</para>
		/// </summary>
		public DateTimeValue? TuesdayStartTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TueUnpaidTime</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// <para>Display Name: Tue Unpaid Break Time</para>
		/// </summary>
		public StringValue? TueUnpaidBreakTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WedWorkDay</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// </summary>
		public BooleanValue? Wednesday { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WedEndTime</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// <para>Display Name: Wednesday End Time</para>
		/// </summary>
		public DateTimeValue? WednesdayEndTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WedStartTime</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// <para>Display Name: Wednesday Start Time</para>
		/// </summary>
		public DateTimeValue? WednesdayStartTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WedUnpaidTime</para>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// <para>Display Name: Wed Unpaid Break Time</para>
		/// </summary>
		public StringValue? WedUnpaidBreakTime { get; set; }

	}
}