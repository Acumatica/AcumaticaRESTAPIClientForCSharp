using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class RollCosts : EntityAction<CostRoll>
	{
		public RollCosts(CostRoll entity) : base(entity)
		{ }
		public RollCosts() : base()
		{ }
	}
}
