
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class ReleaseKitAssembly : EntityAction<KitAssembly>
    {
 public ReleaseKitAssembly(KitAssembly entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public KitAssembly Entity
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
