using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class ReleasePurchaseReceipt : EntityAction<PurchaseReceipt>
	{
		public ReleasePurchaseReceipt(PurchaseReceipt entity) : base(entity)
		{ }
		public ReleasePurchaseReceipt() : base()
		{ }
	}
}
