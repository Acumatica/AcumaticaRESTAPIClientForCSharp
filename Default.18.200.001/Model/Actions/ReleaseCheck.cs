
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class ReleaseCheck : EntityAction<Check>
    {
 public ReleaseCheck(Check entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public Check Entity
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
