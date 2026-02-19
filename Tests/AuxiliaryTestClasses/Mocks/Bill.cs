using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

using System.Collections.Generic;

namespace RESTClientTests.Mocks
{
    public class Bill : Entity, ITopLevelEntity
    {
        public virtual string GetEndpointPath()
        {
            return "entity/Default/20.200.001";
        }
        public StringValue? ReferenceNbr { get; set; }
        public List<BillDetail>? Details { get; set; }
    }
    public class BillDetail : Entity
    {

        public StringValue? InventoryID { get; set; }

        public DecimalValue? Amount { get; set; }

        public StringValue? Project { get; set; }
    }
}
