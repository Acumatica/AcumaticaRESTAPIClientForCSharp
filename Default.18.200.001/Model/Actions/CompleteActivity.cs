
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class CompleteActivity : EntityAction<Activity>
    {
 public CompleteActivity(Activity entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public Activity Entity
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
