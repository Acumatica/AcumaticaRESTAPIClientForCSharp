using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class CreateProductionOrderProcess : EntityAction<CreateProductionOrder>
	{
		public CreateProductionOrderProcess(CreateProductionOrder entity) : base(entity)
		{ }
		public CreateProductionOrderProcess() : base()
		{ }
	}
}
