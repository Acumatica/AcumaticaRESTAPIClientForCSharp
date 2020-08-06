using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class CreateAPBill : EntityAction<PurchaseReceipt>
	{
		public CreateAPBill(PurchaseReceipt entity) : base(entity)
		{ }
		public CreateAPBill() : base()
		{ }
	}
}
