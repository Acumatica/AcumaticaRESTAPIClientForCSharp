
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class CompleteTask : EntityAction<Task>
    {
 public CompleteTask(Task entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public Task Entity
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
