using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace RESTClientTests.Mocks
{
    public class SalesOrder : Entity, ITopLevelEntity
    {
        public DateTimeValue? Date { get; set; }

        public virtual string GetEndpointPath()
        {
            return "entity/Default/20.200.001";
        }
    }
}


