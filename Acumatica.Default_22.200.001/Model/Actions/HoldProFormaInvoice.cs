using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class HoldProFormaInvoice : EntityAction<ProFormaInvoice>
	{
		public HoldProFormaInvoice(ProFormaInvoice entity) : base(entity)
		{ }
		public HoldProFormaInvoice() : base()
		{ }
	}
}
