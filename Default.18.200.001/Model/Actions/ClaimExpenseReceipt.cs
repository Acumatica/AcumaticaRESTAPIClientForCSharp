
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class ClaimExpenseReceipt : EntityAction<ExpenseReceipt>
    {
 public ClaimExpenseReceipt(ExpenseReceipt entity) : base(entity)
        { }
 public ClaimExpenseReceipt() : base()
        { }
  }
}
