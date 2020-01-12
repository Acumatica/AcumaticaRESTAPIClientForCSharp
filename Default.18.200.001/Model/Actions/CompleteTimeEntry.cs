
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class CompleteTimeEntry : EntityAction<TimeEntry>
    {
 public CompleteTimeEntry(TimeEntry entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public TimeEntry Entity
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
