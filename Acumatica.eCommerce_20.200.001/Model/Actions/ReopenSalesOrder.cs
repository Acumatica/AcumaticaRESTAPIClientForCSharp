using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class ReopenSalesOrder : EntityAction<SalesOrder>
	{
		public ReopenSalesOrder(SalesOrder entity) : base(entity)
		{ }
		public ReopenSalesOrder() : base()
		{ }
	}
}
