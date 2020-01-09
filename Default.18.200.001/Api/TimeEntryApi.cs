using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Acumatica.RESTClient.Client;
using Acumatica.DefaultEndpoint_18_200_001.Model;

namespace Acumatica.DefaultEndpoint_18_200_001.Api
{
    public partial class TimeEntryApi : EntityAPI<TimeEntry>
    {
        public TimeEntryApi() : base()
        {
        }
        public TimeEntryApi(Configuration configuration) : base(configuration)
        {
        }
    }
}
