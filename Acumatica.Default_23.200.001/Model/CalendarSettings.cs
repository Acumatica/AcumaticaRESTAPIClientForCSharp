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
	public class CalendarSettings : Entity
	{

		/// <summary>
		/// DAC Field Name: FriWorkDay 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// </summary>
		[DataMember(Name="Friday", EmitDefaultValue=false)]
		public BooleanValue? Friday { get; set; }

		/// <summary>
		/// DAC Field Name: FriEndTime 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// Display Name: Friday End Time 
		/// </summary>
		[DataMember(Name="FridayEndTime", EmitDefaultValue=false)]
		public DateTimeValue? FridayEndTime { get; set; }

		/// <summary>
		/// DAC Field Name: FriStartTime 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// Display Name: Friday Start Time 
		/// </summary>
		[DataMember(Name="FridayStartTime", EmitDefaultValue=false)]
		public DateTimeValue? FridayStartTime { get; set; }

		/// <summary>
		/// DAC Field Name: FriUnpaidTime 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// Display Name: Fri Unpaid Break Time 
		/// </summary>
		[DataMember(Name="FriUnpaidBreakTime", EmitDefaultValue=false)]
		public StringValue? FriUnpaidBreakTime { get; set; }

		/// <summary>
		/// DAC Field Name: MonWorkDay 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// </summary>
		[DataMember(Name="Monday", EmitDefaultValue=false)]
		public BooleanValue? Monday { get; set; }

		/// <summary>
		/// DAC Field Name: MonEndTime 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// Display Name: Monday End Time 
		/// </summary>
		[DataMember(Name="MondayEndTime", EmitDefaultValue=false)]
		public DateTimeValue? MondayEndTime { get; set; }

		/// <summary>
		/// DAC Field Name: MonStartTime 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// Display Name: Monday Start Time 
		/// </summary>
		[DataMember(Name="MondayStartTime", EmitDefaultValue=false)]
		public DateTimeValue? MondayStartTime { get; set; }

		/// <summary>
		/// DAC Field Name: MonUnpaidTime 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// Display Name: Mon Unpaid Break Time 
		/// </summary>
		[DataMember(Name="MonUnpaidBreakTime", EmitDefaultValue=false)]
		public StringValue? MonUnpaidBreakTime { get; set; }

		/// <summary>
		/// DAC Field Name: SatUnpaidTime 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// Display Name: Sat Unpaid Break Time 
		/// </summary>
		[DataMember(Name="SatUnpaidBreakTime", EmitDefaultValue=false)]
		public StringValue? SatUnpaidBreakTime { get; set; }

		/// <summary>
		/// DAC Field Name: SatWorkDay 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// </summary>
		[DataMember(Name="Saturday", EmitDefaultValue=false)]
		public BooleanValue? Saturday { get; set; }

		/// <summary>
		/// DAC Field Name: SatEndTime 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// Display Name: Saturday End Time 
		/// </summary>
		[DataMember(Name="SaturdayEndTime", EmitDefaultValue=false)]
		public DateTimeValue? SaturdayEndTime { get; set; }

		/// <summary>
		/// DAC Field Name: SatStartTime 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// Display Name: Saturday Start Time 
		/// </summary>
		[DataMember(Name="SaturdayStartTime", EmitDefaultValue=false)]
		public DateTimeValue? SaturdayStartTime { get; set; }

		/// <summary>
		/// DAC Field Name: SunWorkDay 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// </summary>
		[DataMember(Name="Sunday", EmitDefaultValue=false)]
		public BooleanValue? Sunday { get; set; }

		/// <summary>
		/// DAC Field Name: SunEndTime 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// Display Name: Sunday End Time 
		/// </summary>
		[DataMember(Name="SundayEndTime", EmitDefaultValue=false)]
		public DateTimeValue? SundayEndTime { get; set; }

		/// <summary>
		/// DAC Field Name: SunStartTime 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// Display Name: Sunday Start Time 
		/// </summary>
		[DataMember(Name="SundayStartTime", EmitDefaultValue=false)]
		public DateTimeValue? SundayStartTime { get; set; }

		/// <summary>
		/// DAC Field Name: SunUnpaidTime 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// Display Name: Sun Unpaid Break Time 
		/// </summary>
		[DataMember(Name="SunUnpaidBreakTime", EmitDefaultValue=false)]
		public StringValue? SunUnpaidBreakTime { get; set; }

		/// <summary>
		/// DAC Field Name: ThuWorkDay 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// </summary>
		[DataMember(Name="Thursday", EmitDefaultValue=false)]
		public BooleanValue? Thursday { get; set; }

		/// <summary>
		/// DAC Field Name: ThuEndTime 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// Display Name: Thursday End Time 
		/// </summary>
		[DataMember(Name="ThursdayEndTime", EmitDefaultValue=false)]
		public DateTimeValue? ThursdayEndTime { get; set; }

		/// <summary>
		/// DAC Field Name: ThuStartTime 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// Display Name: Thursday Start Time 
		/// </summary>
		[DataMember(Name="ThursdayStartTime", EmitDefaultValue=false)]
		public DateTimeValue? ThursdayStartTime { get; set; }

		/// <summary>
		/// DAC Field Name: ThuUnpaidTime 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// Display Name: Thu Unpaid Break Time 
		/// </summary>
		[DataMember(Name="ThuUnpaidBreakTime", EmitDefaultValue=false)]
		public StringValue? ThuUnpaidBreakTime { get; set; }

		/// <summary>
		/// DAC Field Name: TueWorkDay 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// </summary>
		[DataMember(Name="Tuesday", EmitDefaultValue=false)]
		public BooleanValue? Tuesday { get; set; }

		/// <summary>
		/// DAC Field Name: TueEndTime 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// Display Name: Tuesday End Time 
		/// </summary>
		[DataMember(Name="TuesdayEndTime", EmitDefaultValue=false)]
		public DateTimeValue? TuesdayEndTime { get; set; }

		/// <summary>
		/// DAC Field Name: TueStartTime 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// Display Name: Tuesday Start Time 
		/// </summary>
		[DataMember(Name="TuesdayStartTime", EmitDefaultValue=false)]
		public DateTimeValue? TuesdayStartTime { get; set; }

		/// <summary>
		/// DAC Field Name: TueUnpaidTime 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// Display Name: Tue Unpaid Break Time 
		/// </summary>
		[DataMember(Name="TueUnpaidBreakTime", EmitDefaultValue=false)]
		public StringValue? TueUnpaidBreakTime { get; set; }

		/// <summary>
		/// DAC Field Name: WedWorkDay 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// </summary>
		[DataMember(Name="Wednesday", EmitDefaultValue=false)]
		public BooleanValue? Wednesday { get; set; }

		/// <summary>
		/// DAC Field Name: WedEndTime 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// Display Name: Wednesday End Time 
		/// </summary>
		[DataMember(Name="WednesdayEndTime", EmitDefaultValue=false)]
		public DateTimeValue? WednesdayEndTime { get; set; }

		/// <summary>
		/// DAC Field Name: WedStartTime 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// Display Name: Wednesday Start Time 
		/// </summary>
		[DataMember(Name="WednesdayStartTime", EmitDefaultValue=false)]
		public DateTimeValue? WednesdayStartTime { get; set; }

		/// <summary>
		/// DAC Field Name: WedUnpaidTime 
		/// DAC: PX.Objects.CS.CSCalendar 
		/// Display Name: Wed Unpaid Break Time 
		/// </summary>
		[DataMember(Name="WedUnpaidBreakTime", EmitDefaultValue=false)]
		public StringValue? WedUnpaidBreakTime { get; set; }

	}
}