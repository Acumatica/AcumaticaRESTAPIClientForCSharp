
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class CloseLeadAsDuplicate : EntityAction<Lead>
    {
 public CloseLeadAsDuplicate(Lead entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public Lead Entity
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
