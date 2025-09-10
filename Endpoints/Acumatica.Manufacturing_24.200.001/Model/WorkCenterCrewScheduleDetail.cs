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

		/// <summary>
		/// DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleDetail 
		/// </summary>
		[DataMember(Name="CrewSize", EmitDefaultValue=false)]
		public DecimalValue? CrewSize { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleDetail 
		/// </summary>
		[DataMember(Name="CrewSizeShortage", EmitDefaultValue=false)]
		public DecimalValue? CrewSizeShortage { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleDetail 
		/// </summary>
		[DataMember(Name="EndTime", EmitDefaultValue=false)]
		public DateTimeValue? EndTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleDetail 
		/// </summary>
		[DataMember(Name="OperationID", EmitDefaultValue=false)]
		public StringValue? OperationID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleDetail 
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// DAC Field Name: ProdOrdID 
		/// DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleDetail 
		/// </summary>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// DAC Field Name: SchdDate 
		/// DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleDetail 
		/// </summary>
		[DataMember(Name="ScheduleDate", EmitDefaultValue=false)]
		public DateTimeValue? ScheduleDate { get; set; }

		/// <summary>
		/// DAC Field Name: SchdBlocks 
		/// DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleDetail 
		/// </summary>
		[DataMember(Name="ScheduledBlocks", EmitDefaultValue=false)]
		public IntValue? ScheduledBlocks { get; set; }

		/// <summary>
		/// DAC Field Name: ShiftCD 
		/// DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleFilter 
		/// </summary>
		[DataMember(Name="Shift", EmitDefaultValue=false)]
		public StringValue? Shift { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleDetail 
		/// </summary>
		[DataMember(Name="ShiftCrewSize", EmitDefaultValue=false)]
		public DecimalValue? ShiftCrewSize { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleDetail 
		/// </summary>
		[DataMember(Name="StartTime", EmitDefaultValue=false)]
		public DateTimeValue? StartTime { get; set; }

		/// <summary>
		/// DAC Field Name: WcID 
		/// DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleFilter 
		/// </summary>
		[DataMember(Name="WorkCenter", EmitDefaultValue=false)]
		public StringValue? WorkCenter { get; set; }

	}
}