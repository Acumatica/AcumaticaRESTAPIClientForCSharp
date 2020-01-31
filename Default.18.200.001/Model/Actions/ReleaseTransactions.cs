
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class ReleaseTransactions : EntityAction<ProjectTransaction>
    {
 public ReleaseTransactions(ProjectTransaction entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public ProjectTransaction Entity
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
