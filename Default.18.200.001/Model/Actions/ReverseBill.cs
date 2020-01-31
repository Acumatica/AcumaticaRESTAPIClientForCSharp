
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class ReverseBill : EntityAction<Bill>
    {
 public ReverseBill(Bill entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public Bill Entity
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
