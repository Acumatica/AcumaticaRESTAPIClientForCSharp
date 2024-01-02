using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.DeviceHub_23_200_001.Model
{
	[DataContract]
	public class PrintJobParameter : Entity
	{

        [DataMember(Name = "JobID", EmitDefaultValue = false)]
        public IntValue? JobID { get; set; }

        [DataMember(Name = "ParameterName", EmitDefaultValue = false)]
        public StringValue? ParameterName { get; set; }

        [DataMember(Name = "ParameterValue", EmitDefaultValue = false)]
        public StringValue? ParameterValue { get; set; }

    }
}