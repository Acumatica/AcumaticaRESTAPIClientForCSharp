
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class MarkContactAsValidated : EntityAction<Contact>
    {
 public MarkContactAsValidated(Contact entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public Contact Entity
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
