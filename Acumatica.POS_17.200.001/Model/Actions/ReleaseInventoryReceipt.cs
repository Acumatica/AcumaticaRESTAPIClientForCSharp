using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class ReleaseInventoryReceipt : EntityAction<InventoryReceipt>
	{
		public ReleaseInventoryReceipt(InventoryReceipt entity) : base(entity)
		{ }
		public ReleaseInventoryReceipt() : base()
		{ }
	}
}
