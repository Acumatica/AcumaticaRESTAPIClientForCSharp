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

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		[DataMember(Name="DayOfWeek", EmitDefaultValue=false)]
		public StringValue? DayOfWeek { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="EndTime", EmitDefaultValue=false)]
		public DateTimeValue? EndTime { get; set; }

		[DataMember(Name="StartTime", EmitDefaultValue=false)]
		public DateTimeValue? StartTime { get; set; }

		[DataMember(Name="UnpaidBreakTime", EmitDefaultValue=false)]
		public StringValue? UnpaidBreakTime { get; set; }

		[DataMember(Name="WorkDay", EmitDefaultValue=false)]
		public BooleanValue? WorkDay { get; set; }

	}
}