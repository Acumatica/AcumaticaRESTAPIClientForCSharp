using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_18_200_001.Model
{
	[DataContract]
	public class CompleteProductionOrder : EntityAction<ProductionOrder>
	{
		public CompleteProductionOrder(ProductionOrder entity) : base(entity)
		{ }
		public CompleteProductionOrder() : base()
		{ }
	}
}
