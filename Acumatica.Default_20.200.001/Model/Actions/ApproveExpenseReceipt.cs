using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ApproveExpenseReceipt : EntityAction<ExpenseReceipt>
	{
		public ApproveExpenseReceipt(ExpenseReceipt entity) : base(entity)
		{ }
		public ApproveExpenseReceipt() : base()
		{ }
	}
}
