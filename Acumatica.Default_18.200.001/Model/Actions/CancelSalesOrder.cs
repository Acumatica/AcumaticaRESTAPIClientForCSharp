using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class CancelSalesOrder : EntityAction<SalesOrder>
	{
		public CancelSalesOrder(SalesOrder entity) : base(entity)
		{ }
		public CancelSalesOrder() : base()
		{ }
	}
}
