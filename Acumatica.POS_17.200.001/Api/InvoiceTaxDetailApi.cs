using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.POS_17_200_001.Model;

namespace Acumatica.POS_17_200_001.Api
{
	public partial class InvoiceTaxDetailApi : EntityAPI<InvoiceTaxDetail>
	{
		public InvoiceTaxDetailApi(Configuration configuration) : base(configuration)
		{ }
	}
}