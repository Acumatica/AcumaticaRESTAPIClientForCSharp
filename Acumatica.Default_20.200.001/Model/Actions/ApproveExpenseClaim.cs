using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ApproveExpenseClaim : EntityAction<ExpenseClaim>
	{
		public ApproveExpenseClaim(ExpenseClaim entity) : base(entity)
		{ }
		public ApproveExpenseClaim() : base()
		{ }
	}
}
