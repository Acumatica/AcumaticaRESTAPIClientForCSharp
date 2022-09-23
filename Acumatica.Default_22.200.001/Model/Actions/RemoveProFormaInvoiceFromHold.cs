using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class RemoveProFormaInvoiceFromHold : EntityAction<ProFormaInvoice>
	{
		public RemoveProFormaInvoiceFromHold(ProFormaInvoice entity) : base(entity)
		{ }
		public RemoveProFormaInvoiceFromHold() : base()
		{ }
	}
}
