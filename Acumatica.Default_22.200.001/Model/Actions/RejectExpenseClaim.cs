using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class RejectExpenseClaim : EntityAction<ExpenseClaim>
	{
		public RejectExpenseClaim(ExpenseClaim entity) : base(entity)
		{ }
		public RejectExpenseClaim() : base()
		{ }
	}
}
