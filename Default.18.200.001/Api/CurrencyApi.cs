using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Acumatica.RESTClient.Client;
using Acumatica.DefaultEndpoint_18_200_001.Model;

namespace Acumatica.DefaultEndpoint_18_200_001.Api
{
    public partial class CurrencyApi : EntityAPI<Currency>
    {
        public CurrencyApi() : base()
        {
        }
        public CurrencyApi(Configuration configuration) : base(configuration)
        {
        }
    }
}
