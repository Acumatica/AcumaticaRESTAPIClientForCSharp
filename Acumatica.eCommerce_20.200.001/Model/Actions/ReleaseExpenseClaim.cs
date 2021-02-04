using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
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
