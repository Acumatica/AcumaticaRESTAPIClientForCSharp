using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class WorkCalendarExceptionDetail : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.CS.CSCalendarExceptions 
		/// Key Field
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.CSCalendarExceptions 
		/// Display Name: Day Of Week 
		/// </summary>
		[DataMember(Name="DayOfWeek", EmitDefaultValue=false)]
		public StringValue? DayOfWeek { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.CSCalendar 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.CSCalendarExceptions 
		/// Display Name: End Time 
		/// </summary>
		[DataMember(Name="EndTime", EmitDefaultValue=false)]
		public DateTimeValue? EndTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.CSCalendarExceptions 
		/// Display Name: Start Time 
		/// </summary>
		[DataMember(Name="StartTime", EmitDefaultValue=false)]
		public DateTimeValue? StartTime { get; set; }

		/// <summary>
		/// DAC Field Name: UnpaidTime 
		/// DAC: PX.Objects.CS.CSCalendarExceptions 
		/// Display Name: Break Duration 
		/// </summary>
		[DataMember(Name="UnpaidBreakTime", EmitDefaultValue=false)]
		public StringValue? UnpaidBreakTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.CSCalendarExceptions 
		/// Display Name: Work Day 
		/// </summary>
		[DataMember(Name="WorkDay", EmitDefaultValue=false)]
		public BooleanValue? WorkDay { get; set; }

	}
}