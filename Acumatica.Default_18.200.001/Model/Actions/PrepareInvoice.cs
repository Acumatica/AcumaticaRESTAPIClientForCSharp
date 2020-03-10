using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public partial class PrepareInvoice : EntityAction<Shipment>
	{
		public PrepareInvoice(Shipment entity) : base(entity)
		{ }
		public PrepareInvoice() : base()
		{ }
	}
}
