
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class ReleaseAdjustment : EntityAction<Adjustment>
    {
 public ReleaseAdjustment(Adjustment entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public Adjustment Entity
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
