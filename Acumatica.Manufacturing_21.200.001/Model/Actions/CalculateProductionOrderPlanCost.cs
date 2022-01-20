using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class CalculateProductionOrderPlanCost : EntityAction<ProductionOrder>
	{
		public CalculateProductionOrderPlanCost(ProductionOrder entity) : base(entity)
		{ }
		public CalculateProductionOrderPlanCost() : base()
		{ }
	}
}
