using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class ReleaseAdjustment : EntityAction<InventoryAdjustment>
	{
		public ReleaseAdjustment(InventoryAdjustment entity) : base(entity)
		{ }
		public ReleaseAdjustment() : base()
		{ }
	}
}
