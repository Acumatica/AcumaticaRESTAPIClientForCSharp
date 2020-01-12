using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.DefaultEndpoint_18_200_001.Model;

namespace Acumatica.DefaultEndpoint_18_200_001.Api
{
    public partial class OpportunityApi : EntityAPI<Opportunity>
    {
        public OpportunityApi() : base()
        {
        }
        public OpportunityApi(Configuration configuration) : base(configuration)
        {
        }
    }
}
