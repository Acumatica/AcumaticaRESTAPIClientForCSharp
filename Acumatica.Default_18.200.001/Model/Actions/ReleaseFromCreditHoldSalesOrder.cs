using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class ReleaseFromCreditHoldSalesOrder : EntityAction<SalesOrder>
	{
		public ReleaseFromCreditHoldSalesOrder(SalesOrder entity) : base(entity)
		{ }
		public ReleaseFromCreditHoldSalesOrder() : base()
		{ }
	}
}
