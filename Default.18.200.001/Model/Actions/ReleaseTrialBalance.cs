
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class ReleaseTrialBalance : EntityAction<TrialBalance>
    {
 public ReleaseTrialBalance(TrialBalance entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public TrialBalance Entity
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
