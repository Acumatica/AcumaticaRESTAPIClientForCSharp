using Acumatica.RESTClient.Client;
using Acumatica.Default_22_200_001.Model;

namespace Acumatica.Default_22_200_001.Api
{
	public class EmployeePayrollSettingsApi : BaseEndpointApi<EmployeePayrollSettings>
	{
		public EmployeePayrollSettingsApi(ApiClient client) : base(client)
		{ }
	}
}