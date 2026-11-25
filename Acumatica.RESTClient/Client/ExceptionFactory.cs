using System;
using System.Net.Http;

namespace Acumatica.RESTClient.Client
{
    /// <summary>
    ///     Obsolete. Creates the exception for a failed call. It is no longer used by the client.
    /// </summary>
    /// <param name="methodName">The name of the method that was called.</param>
    /// <param name="response">The response of the failed call.</param>
    /// <param name="objectType">The type the response was expected to contain.</param>
    /// <returns>The exception to throw.</returns>
    [Obsolete]
    public delegate Exception ExceptionFactory(string methodName, HttpResponseMessage response, Type objectType);
}
