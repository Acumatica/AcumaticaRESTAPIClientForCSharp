using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM405100 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class WorkCenterCrewSchedule : Entity, ITopLevelEntity
	{

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<WorkCenterCrewScheduleDetail>? Details { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleFilter 
		/// </summary>
		[DataMember(Name="FromDate", EmitDefaultValue=false)]
		public DateTimeValue? FromDate { get; set; }

		/// <summary>
		/// DAC Field Name: ShiftCD 
		/// DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleFilter 
		/// </summary>
		[DataMember(Name="Shift", EmitDefaultValue=false)]
		public StringValue? Shift { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleFilter 
		/// </summary>
		[DataMember(Name="ShowAll", EmitDefaultValue=false)]
		public BooleanValue? ShowAll { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleFilter 
		/// </summary>
		[DataMember(Name="ToDate", EmitDefaultValue=false)]
		public DateTimeValue? ToDate { get; set; }

		/// <summary>
		/// DAC Field Name: WcID 
		/// DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleFilter 
		/// </summary>
		[DataMember(Name="WorkCenter", EmitDefaultValue=false)]
		public StringValue? WorkCenter { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.100.001";
		}
	}
}