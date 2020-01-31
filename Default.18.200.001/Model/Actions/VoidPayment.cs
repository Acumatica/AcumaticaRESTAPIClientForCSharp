
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class VoidPayment : EntityAction<Payment>
    {
 public VoidPayment(Payment entity) : base(entity)
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
