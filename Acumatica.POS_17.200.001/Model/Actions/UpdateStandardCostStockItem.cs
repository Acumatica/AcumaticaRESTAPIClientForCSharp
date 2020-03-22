using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class UpdateStandardCostStockItem : EntityAction<StockItem>
	{
		public UpdateStandardCostStockItem(StockItem entity) : base(entity)
		{ }
		public UpdateStandardCostStockItem() : base()
		{ }
	}
}
