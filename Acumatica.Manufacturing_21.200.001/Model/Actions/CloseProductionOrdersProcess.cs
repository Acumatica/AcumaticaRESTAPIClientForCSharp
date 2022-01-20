using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class CloseProductionOrdersProcess : EntityAction<CloseProductionOrders>
	{
		public CloseProductionOrdersProcess(CloseProductionOrders entity) : base(entity)
		{ }
		public CloseProductionOrdersProcess() : base()
		{ }
	}
}
