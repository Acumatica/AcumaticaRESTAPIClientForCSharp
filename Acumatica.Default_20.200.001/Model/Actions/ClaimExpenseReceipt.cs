using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ClaimExpenseReceipt : EntityAction<ExpenseReceipt>
	{
		public ClaimExpenseReceipt(ExpenseReceipt entity) : base(entity)
		{ }
		public ClaimExpenseReceipt() : base()
		{ }
	}
}
