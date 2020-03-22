using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.Default_18_200_001.Model;

namespace Acumatica.Default_18_200_001.Api
{
	public class TimeEntryApi : EntityAPI<TimeEntry>
	{
		public TimeEntryApi(Configuration configuration) : base(configuration)
		{ }
	}
}