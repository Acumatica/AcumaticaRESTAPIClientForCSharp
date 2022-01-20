using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class UpdatePending : EntityAction<CostRoll>
	{
		public UpdatePending(CostRoll entity) : base(entity)
		{ }
		public UpdatePending() : base()
		{ }
	}
}
