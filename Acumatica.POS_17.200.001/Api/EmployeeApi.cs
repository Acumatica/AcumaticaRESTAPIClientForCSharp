using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.POS_17_200_001.Model;

namespace Acumatica.POS_17_200_001.Api
{
	public class EmployeeApi : EntityAPI<Employee>
	{
		public EmployeeApi(Configuration configuration) : base(configuration)
		{ }
	}
}