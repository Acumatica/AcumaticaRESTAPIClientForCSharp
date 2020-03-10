using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public partial class PutOnHoldExpenseReceipt : EntityAction<ExpenseReceipt>
	{
		public PutOnHoldExpenseReceipt(ExpenseReceipt entity) : base(entity)
		{ }
		public PutOnHoldExpenseReceipt() : base()
		{ }
	}
}
