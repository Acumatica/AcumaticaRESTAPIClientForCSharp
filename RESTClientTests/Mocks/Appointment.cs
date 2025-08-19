using Acumatica.RESTClient.ContractBasedApi.Model;
using Acumatica.RESTClient.ContractBasedApi;
using System.Runtime.Serialization;

namespace RESTClientTests.Mocks
{
    public class Appointment : Entity, ITopLevelEntity
    {
        [DataMember(Name = "DateTime", EmitDefaultValue = false)]
        public DateTimeValue? DateTime { get; set; }

        public virtual string GetEndpointPath()
        {
            return "entity/Default/20.200.001";
        }
    }
}


