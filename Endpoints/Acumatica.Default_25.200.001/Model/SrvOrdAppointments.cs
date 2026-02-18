using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class SrvOrdAppointments : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? AppointmentNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		public BooleanValue? Confirmed { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ScheduledDateTimeEnd_Date</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		public DateTimeValue? ScheduledEndDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ScheduledDateTimeEnd_Time</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		public DateTimeValue? ScheduledEndTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ScheduledDateTimeBegin_Date</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		public DateTimeValue? ScheduledStartDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ScheduledDateTimeBegin_Time</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		public DateTimeValue? ScheduledStartTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SrvOrdType</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(4)</para>
		/// Key Field
		/// </summary>
		public StringValue? ServiceOrderType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

	}
}