using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class GenerateOrdersForSubassemblies : EntityAction<ProductionOrder>
	{
		public GenerateOrdersForSubassemblies(ProductionOrder entity) : base(entity)
		{ }
		public GenerateOrdersForSubassemblies() : base()
		{ }
	}
}
