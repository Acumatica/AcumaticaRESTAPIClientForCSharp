
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class PutOnHoldExpenseReceipt : EntityAction<ExpenseReceipt>
    {
 public PutOnHoldExpenseReceipt(ExpenseReceipt entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public ExpenseReceipt Entity
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
