
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class EnterAPBill : EntityAction<PurchaseOrder>
    {
 public EnterAPBill(PurchaseOrder entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public PurchaseOrder Entity
        {
            get
            {
                return _Entity;
            }
            set
            {
                _Entity = value;
            }
        }
    }
}
