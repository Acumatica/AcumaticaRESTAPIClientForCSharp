using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class SrvOrdAppointments : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="AppointmentNbr", EmitDefaultValue=false)]
		public StringValue? AppointmentNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		[DataMember(Name="Confirmed", EmitDefaultValue=false)]
		public BooleanValue? Confirmed { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ScheduledDateTimeEnd_Date</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		[DataMember(Name="ScheduledEndDate", EmitDefaultValue=false)]
		public DateTimeValue? ScheduledEndDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ScheduledDateTimeEnd_Time</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		[DataMember(Name="ScheduledEndTime", EmitDefaultValue=false)]
		public DateTimeValue? ScheduledEndTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ScheduledDateTimeBegin_Date</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		[DataMember(Name="ScheduledStartDate", EmitDefaultValue=false)]
		public DateTimeValue? ScheduledStartDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ScheduledDateTimeBegin_Time</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		[DataMember(Name="ScheduledStartTime", EmitDefaultValue=false)]
		public DateTimeValue? ScheduledStartTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SrvOrdType</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(4)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ServiceOrderType", EmitDefaultValue=false)]
		public StringValue? ServiceOrderType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

	}
}