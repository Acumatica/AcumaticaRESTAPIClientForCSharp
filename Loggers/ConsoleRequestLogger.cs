using System;
using System.Net.Http;

namespace AcumaticaSoapLikeApiExample
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
            Console.WriteLine("\tStatus code: " + response.StatusCode);
            Console.WriteLine("\tContent: " + response.Content?.ReadAsStringAsync().Result);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
        }

        /// <summary>
        /// Logs request to Console
        /// </summary>
        public static void LogRequest(HttpRequestMessage request)
        {
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine("Request");
            Console.WriteLine("\tMethod: " + request.Method);
            Console.WriteLine("\tURL: " + request.RequestUri);
            string body = request.Content?.ReadAsStringAsync().Result;

            if (!String.IsNullOrEmpty(body))
                Console.WriteLine("\tBody: " + body);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
        }
    }
}
