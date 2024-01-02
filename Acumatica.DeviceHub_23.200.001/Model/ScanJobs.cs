using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.DeviceHub_23_200_001.Model
{
	[DataContract]
	public class ScanJobs : Entity, ITopLevelEntity
	{

        [DataMember(Name = "DeviceHub", EmitDefaultValue = false)]
        public StringValue? DeviceHub { get; set; }

        [DataMember(Name = "Error", EmitDefaultValue = false)]
        public StringValue? Error { get; set; }

        [DataMember(Name = "ScanJobID", EmitDefaultValue = false)]
        public IntValue? ScanJobID { get; set; }

        [DataMember(Name = "Scanner", EmitDefaultValue = false)]
        public StringValue? Scanner { get; set; }

        [DataMember(Name = "Status", EmitDefaultValue = false)]
        public StringValue? Status { get; set; }

        [DataMember(Name = "ErrorTrace", EmitDefaultValue = false)]
        public StringValue? ErrorTrace { get; set; }
        public string GetEndpointPath()
        {
            return "entity/DeviceHub/23.200.001";
        }
    }
}