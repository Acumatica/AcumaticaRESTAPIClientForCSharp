using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class SalesInvoiceAddOrder : EntityAction<SalesInvoice>
	{
		public SalesInvoiceAddOrder(SalesInvoice entity) : base(entity)
		{ }
		public SalesInvoiceAddOrder() : base()
		{ }
	}
}
