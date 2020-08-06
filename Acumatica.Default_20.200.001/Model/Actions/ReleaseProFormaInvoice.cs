using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ReleaseProFormaInvoice : EntityAction<ProFormaInvoice>
	{
		public ReleaseProFormaInvoice(ProFormaInvoice entity) : base(entity)
		{ }
		public ReleaseProFormaInvoice() : base()
		{ }
	}
}
