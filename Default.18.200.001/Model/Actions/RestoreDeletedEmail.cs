
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class RestoreDeletedEmail : EntityAction<Email>
    {
 public RestoreDeletedEmail(Email entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public Email Entity
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
