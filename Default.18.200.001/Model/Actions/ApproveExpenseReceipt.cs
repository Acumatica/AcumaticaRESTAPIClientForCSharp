
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class ApproveExpenseReceipt : EntityAction<ExpenseReceipt>
    {
 public ApproveExpenseReceipt(ExpenseReceipt entity) : base(entity)
        { }
 public ApproveExpenseReceipt() : base()
        { }
  }
}
