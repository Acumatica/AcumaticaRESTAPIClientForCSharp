
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class ReleaseCase : EntityAction<Case>
    {
 public ReleaseCase(Case entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public Case Entity
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
