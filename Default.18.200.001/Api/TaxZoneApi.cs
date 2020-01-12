using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Acumatica.RESTClient.Client;
using Acumatica.DefaultEndpoint_18_200_001.Model;
using Acumatica.RESTClient.Api;

namespace Acumatica.DefaultEndpoint_18_200_001.Api
{
    public partial class TaxZoneApi : EntityAPI<TaxZone>
    {
        public TaxZoneApi() : base()
        {
        }
        public TaxZoneApi(Configuration configuration) : base(configuration)
        {
        }
    }
}
