using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public partial class FinishCountingPhysicalInventory : EntityAction<PhysicalInventoryReview>
	{
		public FinishCountingPhysicalInventory(PhysicalInventoryReview entity) : base(entity)
		{ }
		public FinishCountingPhysicalInventory() : base()
		{ }
	}
}
