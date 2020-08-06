using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class UpdateStandardCostNonStockItem : EntityAction<NonStockItem>
	{
		public UpdateStandardCostNonStockItem(NonStockItem entity) : base(entity)
		{ }
		public UpdateStandardCostNonStockItem() : base()
		{ }
	}
}
