
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class ExportCardEvent : EntityAction<Event>
    {
 public ExportCardEvent(Event entity) : base(entity)
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
