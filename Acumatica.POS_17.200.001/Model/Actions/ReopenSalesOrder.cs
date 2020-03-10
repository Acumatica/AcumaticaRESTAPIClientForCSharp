using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public partial class ReopenSalesOrder : EntityAction<SalesOrder>
	{
		public ReopenSalesOrder(SalesOrder entity) : base(entity)
		{ }
		public ReopenSalesOrder() : base()
		{ }
	}
}
