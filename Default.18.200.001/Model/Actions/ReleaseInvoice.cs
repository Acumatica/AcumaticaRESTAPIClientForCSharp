
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class ReleaseInvoice : EntityAction<Invoice>
    {
 public ReleaseInvoice(Invoice entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public Invoice Entity
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
