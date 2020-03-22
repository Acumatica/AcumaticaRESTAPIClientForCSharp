using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class SalesOrderCreatePurchaseOrder : EntityAction<SalesOrder>
	{
		public SalesOrderCreatePurchaseOrder(SalesOrder entity) : base(entity)
		{ }
		public SalesOrderCreatePurchaseOrder() : base()
		{ }
	}
}
