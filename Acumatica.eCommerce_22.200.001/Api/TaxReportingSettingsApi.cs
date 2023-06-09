using Acumatica.RESTClient.Client;
using Acumatica.eCommerce_22_200_001.Model;

namespace Acumatica.eCommerce_22_200_001.Api
{
	public class TaxReportingSettingsApi : BaseEndpointApi<TaxReportingSettings>
	{
		public TaxReportingSettingsApi(ApiClient client) : base(client)
		{ }
	}
}