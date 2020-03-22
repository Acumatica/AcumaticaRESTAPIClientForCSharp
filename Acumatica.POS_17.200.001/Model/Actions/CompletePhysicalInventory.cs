using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class CompletePhysicalInventory : EntityAction<PhysicalInventoryReview>
	{
		public CompletePhysicalInventory(PhysicalInventoryReview entity) : base(entity)
		{ }
		public CompletePhysicalInventory() : base()
		{ }
	}
}
