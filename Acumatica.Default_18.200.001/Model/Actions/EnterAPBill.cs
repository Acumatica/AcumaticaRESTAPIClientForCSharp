using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class EnterAPBill : EntityAction<PurchaseOrder>
	{
		public EnterAPBill(PurchaseOrder entity) : base(entity)
		{ }
		public EnterAPBill() : base()
		{ }
	}
}
