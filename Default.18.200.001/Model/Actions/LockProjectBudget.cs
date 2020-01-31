
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class LockProjectBudget : EntityAction<Project>
    {
 public LockProjectBudget(Project entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public Project Entity
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
