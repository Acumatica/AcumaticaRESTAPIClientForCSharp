using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class ReleaseInvoice : EntityAction<Invoice>
	{
		public ReleaseInvoice(Invoice entity) : base(entity)
		{ }
		public ReleaseInvoice() : base()
		{ }
	}
}
