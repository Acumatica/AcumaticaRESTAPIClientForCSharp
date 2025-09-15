using System;
using System.Net.Http;

namespace Acumatica.RESTClient.Client
{
    [Obsolete]
    public delegate Exception ExceptionFactory(string methodName, HttpResponseMessage response, Type objectType);
}
