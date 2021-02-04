using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_18_200_001.Model
{
	[DataContract]
	public class PlanProductionOrder : EntityAction<ProductionOrder>
	{
		public PlanProductionOrder(ProductionOrder entity) : base(entity)
		{ }
		public PlanProductionOrder() : base()
		{ }
	}
}
