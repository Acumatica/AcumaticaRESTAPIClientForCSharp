using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class RoughCutPlanningProcessAll : EntityAction<RoughCutPlanning>
	{
		public RoughCutPlanningProcessAll(RoughCutPlanning entity) : base(entity)
		{ }
		public RoughCutPlanningProcessAll() : base()
		{ }
	}
}
