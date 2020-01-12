
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class TakeCase : EntityAction<Case>
    {
 public TakeCase(Case entity) : base(entity)
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
