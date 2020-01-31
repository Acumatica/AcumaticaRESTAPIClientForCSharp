
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class UpdateStandardCostStockItem : EntityAction<StockItem>
    {
 public UpdateStandardCostStockItem(StockItem entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public StockItem Entity
        {
            get
            {
                return _Entity;
            }
            set
            {
                _Entity = value;
            }
        }
    }
}
