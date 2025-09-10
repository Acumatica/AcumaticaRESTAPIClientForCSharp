using Acumatica.RESTClient.ContractBasedApi.Model;
using Acumatica.RESTClient.ContractBasedApi;
using System.Runtime.Serialization;

namespace RESTClientTests.Mocks
{
    public class SalesOrder : Entity, ITopLevelEntity
    {
        [DataMember(Name = "Date", EmitDefaultValue = false)]
        public DateTimeValue? Date { get; set; }

        public virtual string GetEndpointPath()
        {
            return "entity/Default/20.200.001";
        }
    }
}


