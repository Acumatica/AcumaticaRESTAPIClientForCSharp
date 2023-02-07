using RestSharp;

using System;
using System.Collections.Generic;

namespace Acumatica.RESTClient.Client
{
    [Obsolete("Use Acumatica.RESTClient.Client.Session instead.")]
    public class Configuration : Session
    {
        public Configuration(Session prototype) : base(prototype)
        {
        }

        public Configuration(string basePath, int timeout = 100000, Action<RestRequest, RestClient> requestInterceptor = null, Action<RestRequest, RestResponse, RestClient> responseInterceptor = null) : base(basePath, timeout, requestInterceptor, responseInterceptor)
        {
        }
    }
}
