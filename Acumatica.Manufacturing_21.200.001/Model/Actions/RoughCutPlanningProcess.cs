using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class RoughCutPlanningProcess : EntityAction<RoughCutPlanning>
	{
		public RoughCutPlanningProcess(RoughCutPlanning entity) : base(entity)
		{ }
		public RoughCutPlanningProcess() : base()
		{ }
	}
}
