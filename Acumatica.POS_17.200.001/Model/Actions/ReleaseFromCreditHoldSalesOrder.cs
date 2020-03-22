using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
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
