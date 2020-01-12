
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class ApproveChangeOrder : EntityAction<ChangeOrder>
    {
 public ApproveChangeOrder(ChangeOrder entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public ChangeOrder Entity
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
