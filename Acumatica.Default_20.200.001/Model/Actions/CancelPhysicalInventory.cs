using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class CancelPhysicalInventory : EntityAction<PhysicalInventoryReview>
	{
		public CancelPhysicalInventory(PhysicalInventoryReview entity) : base(entity)
		{ }
		public CancelPhysicalInventory() : base()
		{ }
	}
}
