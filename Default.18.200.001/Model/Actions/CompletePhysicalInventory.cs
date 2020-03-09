
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class CompletePhysicalInventory : EntityAction<PhysicalInventoryReview>
    {
 public CompletePhysicalInventory(PhysicalInventoryReview entity) : base(entity)
        { }
 public CompletePhysicalInventory() : base()
        { }
  }
}
