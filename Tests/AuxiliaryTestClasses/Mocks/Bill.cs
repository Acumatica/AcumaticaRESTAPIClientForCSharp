using System.Collections.Generic;
using System.Runtime.Serialization;

using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace RESTClientTests.Mocks
{
    [DataContract]
    public class Bill : Entity, ITopLevelEntity
    {
        public virtual string GetEndpointPath()
        {
            return "entity/Default/20.200.001";
        }
        [DataMember(Name = "ReferenceNbr", EmitDefaultValue = false)]
        public StringValue? ReferenceNbr { get; set; }
        [DataMember(Name = "Details", EmitDefaultValue = false)]
        public List<BillDetail>? Details { get; set; }
    }
    public class BillDetail : Entity
    {

        [DataMember(Name = "InventoryID", EmitDefaultValue = false)]
        public StringValue? InventoryID { get; set; }
        [DataMember(Name = "Amount", EmitDefaultValue = false)]
        public DecimalValue? Amount { get; set; }

        [DataMember(Name = "Project", EmitDefaultValue = false)]
        public StringValue? Project { get; set; }
    }
}
