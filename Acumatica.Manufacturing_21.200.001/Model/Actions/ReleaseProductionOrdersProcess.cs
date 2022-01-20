using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class ReleaseProductionOrdersProcess : EntityAction<ReleaseProductionOrders>
	{
		public ReleaseProductionOrdersProcess(ReleaseProductionOrders entity) : base(entity)
		{ }
		public ReleaseProductionOrdersProcess() : base()
		{ }
	}
}
