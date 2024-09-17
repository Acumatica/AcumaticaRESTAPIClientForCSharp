using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	[DataContract]
	public class WorkCenterCrewScheduleDetail : Entity
	{

		[DataMember(Name="CrewSize", EmitDefaultValue=false)]
		public DecimalValue? CrewSize { get; set; }

		[DataMember(Name="CrewSizeShortage", EmitDefaultValue=false)]
		public DecimalValue? CrewSizeShortage { get; set; }

		[DataMember(Name="EndTime", EmitDefaultValue=false)]
		public DateTimeValue? EndTime { get; set; }

		[DataMember(Name="OperationID", EmitDefaultValue=false)]
		public StringValue? OperationID { get; set; }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		[DataMember(Name="ScheduleDate", EmitDefaultValue=false)]
		public DateTimeValue? ScheduleDate { get; set; }

		[DataMember(Name="ScheduledBlocks", EmitDefaultValue=false)]
		public IntValue? ScheduledBlocks { get; set; }

		[DataMember(Name="Shift", EmitDefaultValue=false)]
		public StringValue? Shift { get; set; }

		[DataMember(Name="ShiftCrewSize", EmitDefaultValue=false)]
		public DecimalValue? ShiftCrewSize { get; set; }

		[DataMember(Name="StartTime", EmitDefaultValue=false)]
		public DateTimeValue? StartTime { get; set; }

		[DataMember(Name="WorkCenter", EmitDefaultValue=false)]
		public StringValue? WorkCenter { get; set; }

	}
}