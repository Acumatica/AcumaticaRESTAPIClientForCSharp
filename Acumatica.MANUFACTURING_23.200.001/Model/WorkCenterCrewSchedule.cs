using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
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
		/// 
		/// Display Name:
		/// DAC Field Name: FromDate 
		/// DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FromDate", EmitDefaultValue=false)]
		public DateTimeValue? FromDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ShiftCD 
		/// DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Shift", EmitDefaultValue=false)]
		public StringValue? Shift { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ShowAll 
		/// DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShowAll", EmitDefaultValue=false)]
		public BooleanValue? ShowAll { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ToDate 
		/// DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ToDate", EmitDefaultValue=false)]
		public DateTimeValue? ToDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WcID 
		/// DAC: PX.Objects.AM.WorkCenterCrewScheduleInq+WorkCenterCrewScheduleFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WorkCenter", EmitDefaultValue=false)]
		public StringValue? WorkCenter { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}