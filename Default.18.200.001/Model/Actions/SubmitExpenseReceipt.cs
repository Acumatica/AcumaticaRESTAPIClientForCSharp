
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class SubmitExpenseReceipt : EntityAction<ExpenseReceipt>
    {
 public SubmitExpenseReceipt(ExpenseReceipt entity) : base(entity)
        { }
 public SubmitExpenseReceipt() : base()
        { }
  }
}
