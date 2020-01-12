
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class CreateAPBill : EntityAction<PurchaseReceipt>
    {
 public CreateAPBill(PurchaseReceipt entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public PurchaseReceipt Entity
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
