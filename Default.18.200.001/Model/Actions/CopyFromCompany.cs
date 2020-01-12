
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class CopyFromCompany : EntityAction<Contact>
    {
 public CopyFromCompany(Contact entity) : base(entity)
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
