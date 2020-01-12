
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class CaptureCreditCardPayment : EntityAction<Payment>
    {
 public CaptureCreditCardPayment(Payment entity) : base(entity)
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
