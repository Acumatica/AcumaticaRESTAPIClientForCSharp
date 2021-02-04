using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class SubmitExpenseReceipt : EntityAction<ExpenseReceipt>
	{
		public SubmitExpenseReceipt(ExpenseReceipt entity) : base(entity)
		{ }
		public SubmitExpenseReceipt() : base()
		{ }
	}
}
