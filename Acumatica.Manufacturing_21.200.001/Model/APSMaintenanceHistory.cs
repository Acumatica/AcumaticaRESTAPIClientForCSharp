using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class APSMaintenanceHistory : Entity
	{

		[DataMember(Name="BlockSizeChangeLastRunBy", EmitDefaultValue=false)]
		public StringValue? BlockSizeChangeLastRunBy { get; set; }

		[DataMember(Name="BlockSizeChangeLastRunDate", EmitDefaultValue=false)]
		public DateTimeValue? BlockSizeChangeLastRunDate { get; set; }

		[DataMember(Name="CurrentBlockSize", EmitDefaultValue=false)]
		public StringValue? CurrentBlockSize { get; set; }

		[DataMember(Name="HistoryCleanupLastRunBy", EmitDefaultValue=false)]
		public StringValue? HistoryCleanupLastRunBy { get; set; }

		[DataMember(Name="HistoryCleanupLastRunDate", EmitDefaultValue=false)]
		public DateTimeValue? HistoryCleanupLastRunDate { get; set; }

		[DataMember(Name="LastBlockSize", EmitDefaultValue=false)]
		public StringValue? LastBlockSize { get; set; }

		[DataMember(Name="WorkCalendarLastRunBy", EmitDefaultValue=false)]
		public StringValue? WorkCalendarLastRunBy { get; set; }

		[DataMember(Name="WorkCalendarLastRunDate", EmitDefaultValue=false)]
		public DateTimeValue? WorkCalendarLastRunDate { get; set; }

		[DataMember(Name="WorkCenterScheduleLastRunBy", EmitDefaultValue=false)]
		public StringValue? WorkCenterScheduleLastRunBy { get; set; }

		[DataMember(Name="WorkCenterScheduleLastRunDate", EmitDefaultValue=false)]
		public DateTimeValue? WorkCenterScheduleLastRunDate { get; set; }

	}
}