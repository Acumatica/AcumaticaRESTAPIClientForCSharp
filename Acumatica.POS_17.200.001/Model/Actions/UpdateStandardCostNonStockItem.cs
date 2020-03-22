using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
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
