using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class CreateProductionOrderProcessAll : EntityAction<CreateProductionOrder>
	{
		public CreateProductionOrderProcessAll(CreateProductionOrder entity) : base(entity)
		{ }
		public CreateProductionOrderProcessAll() : base()
		{ }
	}
}
