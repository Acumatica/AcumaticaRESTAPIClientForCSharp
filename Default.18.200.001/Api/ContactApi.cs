using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Acumatica.RESTClient.Client;
using Acumatica.DefaultEndpoint_18_200_001.Model;

namespace Acumatica.DefaultEndpoint_18_200_001.Api
{
    public partial class ContactApi : EntityAPI<Contact>
    {
        public ContactApi() : base()
        {
        }
        public ContactApi(Configuration configuration) : base(configuration)
        {
        }
    }
}
