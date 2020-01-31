
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class ReleasePayment : EntityAction<Payment>
    {
 public ReleasePayment(Payment entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public Payment Entity
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
