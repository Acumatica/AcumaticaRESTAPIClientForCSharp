using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.DeviceHub_23_200_001.Model
{
	[DataContract]
	public class PrintJobs : Entity, ITopLevelEntity
	{

        [DataMember(Name = "Jobs", EmitDefaultValue = false)]
        public List<PrintJob>? Jobs { get; set; }

        [DataMember(Name = "EndDate", EmitDefaultValue = false)]
        public DateTimeValue? EndDate { get; set; }

        [DataMember(Name = "HideProcessed", EmitDefaultValue = false)]
        public BooleanValue? HideProcessed { get; set; }

        [DataMember(Name = "StartDate", EmitDefaultValue = false)]
        public DateTimeValue? StartDate { get; set; }

        [DataMember(Name = "JobID", EmitDefaultValue = false)]
        public IntValue? JobID { get; set; }

        [DataMember(Name = "StartModifiedDateTime", EmitDefaultValue = false)]
        public DateTimeValue? StartModifiedDateTime { get; set; }

        [DataMember(Name = "EndModifiedDateTime", EmitDefaultValue = false)]
        public DateTimeValue? EndModifiedDateTime { get; set; }
        public string GetEndpointPath()
        {
            return "entity/DeviceHub/23.200.001";
        }

    }
}