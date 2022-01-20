using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class CreateLinkedProductionOrders : EntityAction<ProductionOrder>
	{
		public CreateLinkedProductionOrders(ProductionOrder entity) : base(entity)
		{ }
		public CreateLinkedProductionOrders() : base()
		{ }
	}
}
