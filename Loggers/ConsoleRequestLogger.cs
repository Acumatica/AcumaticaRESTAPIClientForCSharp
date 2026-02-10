using System;
using System.Net.Http;

namespace Acumatica.RESTClient.Loggers
{
    public static class ConsoleRequestLogger
    {

        /// <summary>
        /// Logs response to Console
        /// </summary>
        public static void LogResponse(HttpResponseMessage response)
        {
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine("Response");
            Console.WriteLine($"\tStatus code: {(int)response.StatusCode} - {response.StatusCode}");
            Console.WriteLine("\tContent: " + response.Content?.ReadAsStringAsync().Result);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
        }

        /// <summary>
        /// Logs response to Console if the response is not successful
        /// </summary>
        public static void LogErrorResponse(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                LogResponse(response);
            }
        }

        /// <summary>
        /// Logs request to Console
        /// </summary>
        public static void LogRequest(HttpRequestMessage request)
        {
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine("Request");
            Console.WriteLine("\tMethod: " + request.Method);
            Console.WriteLine("\tHeaders: " + request.Headers);
            Console.WriteLine("\tURL: " + request.RequestUri);
            string body = request.Content?.ReadAsStringAsync().Result;

            if (!String.IsNullOrEmpty(body))
                Console.WriteLine("\tBody: " + body);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
        }
    }
}
