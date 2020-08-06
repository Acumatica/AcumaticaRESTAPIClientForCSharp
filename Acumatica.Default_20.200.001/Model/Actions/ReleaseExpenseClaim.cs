using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ReleaseExpenseClaim : EntityAction<ExpenseClaim>
	{
		public ReleaseExpenseClaim(ExpenseClaim entity) : base(entity)
		{ }
		public ReleaseExpenseClaim() : base()
		{ }
	}
}
