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
	public class WorkCalendarExceptionDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSCalendarExceptions</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSCalendarExceptions</para>
		/// <para>Display Name: Day Of Week</para>
		/// </summary>
		[DataMember(Name="DayOfWeek", EmitDefaultValue=false)]
		public StringValue? DayOfWeek { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSCalendar</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSCalendarExceptions</para>
		/// <para>Display Name: End Time</para>
		/// </summary>
		[DataMember(Name="EndTime", EmitDefaultValue=false)]
		public DateTimeValue? EndTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSCalendarExceptions</para>
		/// <para>Display Name: Start Time</para>
		/// </summary>
		[DataMember(Name="StartTime", EmitDefaultValue=false)]
		public DateTimeValue? StartTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnpaidTime</para>
		/// <para>DAC: PX.Objects.CS.CSCalendarExceptions</para>
		/// <para>Display Name: Break Duration</para>
		/// </summary>
		[DataMember(Name="UnpaidBreakTime", EmitDefaultValue=false)]
		public StringValue? UnpaidBreakTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CSCalendarExceptions</para>
		/// <para>Display Name: Work Day</para>
		/// </summary>
		[DataMember(Name="WorkDay", EmitDefaultValue=false)]
		public BooleanValue? WorkDay { get; set; }

	}
}