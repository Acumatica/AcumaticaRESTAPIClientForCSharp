using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public partial class RejectExpenseReceipt : EntityAction<ExpenseReceipt>
	{
		public RejectExpenseReceipt(ExpenseReceipt entity) : base(entity)
		{ }
		public RejectExpenseReceipt() : base()
		{ }
	}
}
