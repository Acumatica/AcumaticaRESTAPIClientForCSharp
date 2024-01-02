using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class WorkCenterCrewSchedule : Entity, ITopLevelEntity
	{

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<WorkCenterCrewScheduleDetail>? Details { get; set; }

		[DataMember(Name="FromDate", EmitDefaultValue=false)]
		public DateTimeValue? FromDate { get; set; }

		[DataMember(Name="Shift", EmitDefaultValue=false)]
		public StringValue? Shift { get; set; }

		[DataMember(Name="ShowAll", EmitDefaultValue=false)]
		public BooleanValue? ShowAll { get; set; }

		[DataMember(Name="ToDate", EmitDefaultValue=false)]
		public DateTimeValue? ToDate { get; set; }

		[DataMember(Name="WorkCenter", EmitDefaultValue=false)]
		public StringValue? WorkCenter { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/21.200.001";
		}
	}
}