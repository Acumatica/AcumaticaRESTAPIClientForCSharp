using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class RejectExpenseReceipt : EntityAction<ExpenseReceipt>
	{
		public RejectExpenseReceipt(ExpenseReceipt entity) : base(entity)
		{ }
		public RejectExpenseReceipt() : base()
		{ }
	}
}
