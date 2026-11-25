using Acumatica.RESTClient.ContractBasedApi.Model;
using Acumatica.RESTClient.ContractBasedApi;

namespace RESTClientTests.Mocks
{
    public class Appointment : Entity, ITopLevelEntity
    {
        public DateTimeValue? DateTime { get; set; }

        public virtual string GetEndpointPath()
        {
            return "entity/Default/20.200.001";
        }
    }
}


