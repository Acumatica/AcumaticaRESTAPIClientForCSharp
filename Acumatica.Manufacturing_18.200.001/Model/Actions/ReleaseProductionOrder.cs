using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_18_200_001.Model
{
	[DataContract]
	public class ReleaseProductionOrder : EntityAction<ProductionOrder>
	{
		public ReleaseProductionOrder(ProductionOrder entity) : base(entity)
		{ }
		public ReleaseProductionOrder() : base()
		{ }
	}
}
