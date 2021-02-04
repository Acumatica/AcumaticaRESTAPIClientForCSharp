using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class InvoiceOrder : EntityAction<ServiceOrder>
	{
		public InvoiceOrder(ServiceOrder entity) : base(entity)
		{ }
		public InvoiceOrder() : base()
		{ }
	}
}
