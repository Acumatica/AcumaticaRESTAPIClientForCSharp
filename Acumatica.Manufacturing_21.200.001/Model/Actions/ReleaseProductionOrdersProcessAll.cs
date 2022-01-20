using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class ReleaseProductionOrdersProcessAll : EntityAction<ReleaseProductionOrders>
	{
		public ReleaseProductionOrdersProcessAll(ReleaseProductionOrders entity) : base(entity)
		{ }
		public ReleaseProductionOrdersProcessAll() : base()
		{ }
	}
}
