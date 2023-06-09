using System;
using System.Net.Http;

namespace Acumatica.RESTClient.Client
{
    /// <summary>
    /// A delegate to ExceptionFactory method
    /// </summary>
    /// <param name="methodName">Method name</param>
    /// <param name="response">Response</param>
    /// <returns>Exceptions</returns>
    public delegate Exception ExceptionFactory(string methodName, HttpResponseMessage response, Type objectType);
}
