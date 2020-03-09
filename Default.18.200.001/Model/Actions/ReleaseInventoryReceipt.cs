
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class ReleaseInventoryReceipt : EntityAction<InventoryReceipt>
    {
 public ReleaseInventoryReceipt(InventoryReceipt entity) : base(entity)
        { }
 public ReleaseInventoryReceipt() : base()
        { }
  }
}
