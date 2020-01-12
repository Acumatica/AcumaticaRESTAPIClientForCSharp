
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class ReleaseBill : EntityAction<Bill>
    {
 public ReleaseBill(Bill entity) : base(entity)
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
