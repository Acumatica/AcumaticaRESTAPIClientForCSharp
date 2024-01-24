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

		[DataMember(Name="Friday", EmitDefaultValue=false)]
		public BooleanValue? Friday { get; set; }

		[DataMember(Name="FridayEndTime", EmitDefaultValue=false)]
		public DateTimeValue? FridayEndTime { get; set; }

		[DataMember(Name="FridayStartTime", EmitDefaultValue=false)]
		public DateTimeValue? FridayStartTime { get; set; }

		[DataMember(Name="FriUnpaidBreakTime", EmitDefaultValue=false)]
		public StringValue? FriUnpaidBreakTime { get; set; }

		[DataMember(Name="Monday", EmitDefaultValue=false)]
		public BooleanValue? Monday { get; set; }

		[DataMember(Name="MondayEndTime", EmitDefaultValue=false)]
		public DateTimeValue? MondayEndTime { get; set; }

		[DataMember(Name="MondayStartTime", EmitDefaultValue=false)]
		public DateTimeValue? MondayStartTime { get; set; }

		[DataMember(Name="MonUnpaidBreakTime", EmitDefaultValue=false)]
		public StringValue? MonUnpaidBreakTime { get; set; }

		[DataMember(Name="SatUnpaidBreakTime", EmitDefaultValue=false)]
		public StringValue? SatUnpaidBreakTime { get; set; }

		[DataMember(Name="Saturday", EmitDefaultValue=false)]
		public BooleanValue? Saturday { get; set; }

		[DataMember(Name="SaturdayEndTime", EmitDefaultValue=false)]
		public DateTimeValue? SaturdayEndTime { get; set; }

		[DataMember(Name="SaturdayStartTime", EmitDefaultValue=false)]
		public DateTimeValue? SaturdayStartTime { get; set; }

		[DataMember(Name="Sunday", EmitDefaultValue=false)]
		public BooleanValue? Sunday { get; set; }

		[DataMember(Name="SundayEndTime", EmitDefaultValue=false)]
		public DateTimeValue? SundayEndTime { get; set; }

		[DataMember(Name="SundayStartTime", EmitDefaultValue=false)]
		public DateTimeValue? SundayStartTime { get; set; }

		[DataMember(Name="SunUnpaidBreakTime", EmitDefaultValue=false)]
		public StringValue? SunUnpaidBreakTime { get; set; }

		[DataMember(Name="Thursday", EmitDefaultValue=false)]
		public BooleanValue? Thursday { get; set; }

		[DataMember(Name="ThursdayEndTime", EmitDefaultValue=false)]
		public DateTimeValue? ThursdayEndTime { get; set; }

		[DataMember(Name="ThursdayStartTime", EmitDefaultValue=false)]
		public DateTimeValue? ThursdayStartTime { get; set; }

		[DataMember(Name="ThuUnpaidBreakTime", EmitDefaultValue=false)]
		public StringValue? ThuUnpaidBreakTime { get; set; }

		[DataMember(Name="Tuesday", EmitDefaultValue=false)]
		public BooleanValue? Tuesday { get; set; }

		[DataMember(Name="TuesdayEndTime", EmitDefaultValue=false)]
		public DateTimeValue? TuesdayEndTime { get; set; }

		[DataMember(Name="TuesdayStartTime", EmitDefaultValue=false)]
		public DateTimeValue? TuesdayStartTime { get; set; }

		[DataMember(Name="TueUnpaidBreakTime", EmitDefaultValue=false)]
		public StringValue? TueUnpaidBreakTime { get; set; }

		[DataMember(Name="Wednesday", EmitDefaultValue=false)]
		public BooleanValue? Wednesday { get; set; }

		[DataMember(Name="WednesdayEndTime", EmitDefaultValue=false)]
		public DateTimeValue? WednesdayEndTime { get; set; }

		[DataMember(Name="WednesdayStartTime", EmitDefaultValue=false)]
		public DateTimeValue? WednesdayStartTime { get; set; }

		[DataMember(Name="WedUnpaidBreakTime", EmitDefaultValue=false)]
		public StringValue? WedUnpaidBreakTime { get; set; }

	}
}