
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class UpdateStandardCostStockItem : EntityAction<StockItem>
    {
 public UpdateStandardCostStockItem(StockItem entity) : base(entity)
        { }
 public UpdateStandardCostStockItem() : base()
        { }
  }
}
