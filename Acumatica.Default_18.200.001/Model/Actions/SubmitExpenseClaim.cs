using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class SubmitExpenseClaim : EntityAction<ExpenseClaim>
	{
		public SubmitExpenseClaim(ExpenseClaim entity) : base(entity)
		{ }
		public SubmitExpenseClaim() : base()
		{ }
	}
}
