using System;
using Acumatica.RESTClient.Client;
using Acumatica.Default_25_200_001.Model;

namespace Acumatica.Default_25_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class WorkCalendarApi : BaseEndpointApi<WorkCalendar>
	{
		public WorkCalendarApi(ApiClient client) : base(client)
		{ }
	}
}