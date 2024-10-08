using Acumatica.RESTClient.ContractBasedApi.Model;
using Acumatica.RESTClient.ContractBasedApi;

namespace RESTClientTests.Mocks
{
    public class SalesOrder : Entity, ITopLevelEntity
    {

        public virtual string GetEndpointPath()
        {
            return "entity/Default/20.200.001";
        }
    }
}


