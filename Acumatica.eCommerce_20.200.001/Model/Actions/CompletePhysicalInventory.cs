using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
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
