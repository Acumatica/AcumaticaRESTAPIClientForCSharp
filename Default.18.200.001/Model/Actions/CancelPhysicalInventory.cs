
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class CancelPhysicalInventory : EntityAction<PhysicalInventoryReview>
    {
 public CancelPhysicalInventory(PhysicalInventoryReview entity) : base(entity)
        { }
 public CancelPhysicalInventory() : base()
        { }
  }
}
