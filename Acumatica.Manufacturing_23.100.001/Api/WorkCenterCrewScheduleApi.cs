using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_23_100_001.Model;

namespace Acumatica.Manufacturing_23_100_001.Api
{
	public class WorkCenterCrewScheduleApi : BaseEndpointApi<WorkCenterCrewSchedule>
	{
		public WorkCenterCrewScheduleApi(ApiClient client) : base(client)
		{ }
	}
}