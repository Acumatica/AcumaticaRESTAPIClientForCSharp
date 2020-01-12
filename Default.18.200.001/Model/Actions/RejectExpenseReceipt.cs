
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class RejectExpenseReceipt : EntityAction<ExpenseReceipt>
    {
 public RejectExpenseReceipt(ExpenseReceipt entity) : base(entity)
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
