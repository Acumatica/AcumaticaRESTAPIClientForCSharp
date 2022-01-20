using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class CloseProductionOrdersProcessAll : EntityAction<CloseProductionOrders>
	{
		public CloseProductionOrdersProcessAll(CloseProductionOrders entity) : base(entity)
		{ }
		public CloseProductionOrdersProcessAll() : base()
		{ }
	}
}
