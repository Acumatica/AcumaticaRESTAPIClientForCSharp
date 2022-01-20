using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class Archive : EntityAction<CostRoll>
	{
		public Archive(CostRoll entity) : base(entity)
		{ }
		public Archive() : base()
		{ }
	}
}
