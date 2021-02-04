using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class OpenSalesOrder : EntityAction<SalesOrder>
	{
		public OpenSalesOrder(SalesOrder entity) : base(entity)
		{ }
		public OpenSalesOrder() : base()
		{ }
	}
}
