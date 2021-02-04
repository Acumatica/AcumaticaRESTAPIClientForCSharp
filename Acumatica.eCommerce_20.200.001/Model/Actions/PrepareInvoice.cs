using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class PrepareInvoice : EntityAction<Shipment>
	{
		public PrepareInvoice(Shipment entity) : base(entity)
		{ }
		public PrepareInvoice() : base()
		{ }
	}
}
