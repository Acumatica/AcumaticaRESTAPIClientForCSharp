using System;
using Acumatica.RESTClient.Client;
using Acumatica.Default_24_200_001.Model;

namespace Acumatica.Default_24_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class EmployeePayrollClassApi : BaseEndpointApi<EmployeePayrollClass>
	{
		public EmployeePayrollClassApi(ApiClient client) : base(client)
		{ }
	}
}