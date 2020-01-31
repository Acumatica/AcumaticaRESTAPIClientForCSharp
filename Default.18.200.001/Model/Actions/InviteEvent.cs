
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class InviteEvent : EntityAction<Event>
    {
 public InviteEvent(Event entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public Event Entity
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
