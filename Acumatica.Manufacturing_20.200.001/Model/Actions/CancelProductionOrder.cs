using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_20_200_001.Model
{
	[DataContract]
	public class CancelProductionOrder : EntityAction<ProductionOrder>
	{
		public CancelProductionOrder(ProductionOrder entity) : base(entity)
		{ }
		public CancelProductionOrder() : base()
		{ }
	}
}
