using System;
using System.IO;
using System.Net.Http;

namespace AcumaticaRestApiExample
{
    public static class FileRequestLogger
    {
        private const string LogFilePath = "AcumaticaRestClient.log";

        /// <summary>
        /// Logs requests to AcumaticaRestClient.log file.
        /// </summary>
        public static void LogRequest(HttpRequestMessage request) => LogRequest(request, LogFilePath, silent: true);

        /// <summary>
        /// Logs responses to AcumaticaRestClient.log file.
        /// </summary>
        public static void LogResponse(HttpResponseMessage request) => LogResponse(request, LogFilePath, silent: true);

        /// <summary>
        /// Logs request to the file specified in <paramref name="requestsLogPath"/>.
        /// </summary>
        /// <param name="request">The request to log.</param>
        /// <param name="requestsLogPath">Path to the file.</param>
        /// <param name="silent">When set to <c>true</c> indicates that exceptions occurred in this method are omitted.</param> 
        public static void LogRequest(HttpRequestMessage request, string requestsLogPath, bool silent = true)
        {
            try
            {
                using (var writer = new StreamWriter(requestsLogPath, true))
                {
                    writer.WriteLine(DateTime.Now.ToString());
                    writer.WriteLine("Request");
                    writer.WriteLine("\tMethod: " + request.Method);
                    writer.WriteLine("\tURL: " + request.RequestUri);

                    string body = request.Content?.ReadAsStringAsync().Result;

                    if (!String.IsNullOrEmpty(body))
                        writer.WriteLine("\tBody: " + body);
                    writer.WriteLine("-----------------------------------------");
                    writer.WriteLine();
                    writer.Flush();
                    writer.Close();
                }
            }
            catch(Exception e)
            {
                if (!silent)
                    throw;
            }

        }

        /// <summary>
        /// Logs response to RequestsLog.txt file.
        /// </summary>
        /// <param name="responseMessage">The response to log.</param>
        /// <param name="requestsLogPath">Path to the file.</param>
        /// <param name="silent">When set to <c>true</c> indicates that exceptions occurred in this method are omitted.</param>
        public static void LogResponse(HttpResponseMessage responseMessage, string requestsLogPath = LogFilePath, bool silent = true)
        {
            try
            {
                using (var writer = new StreamWriter(requestsLogPath, true))
                {
                    writer.WriteLine(DateTime.Now.ToString());
                    writer.WriteLine("Response");
                    writer.WriteLine($"\tStatus code: {(int)responseMessage.StatusCode} - {responseMessage.StatusCode}");
                    writer.WriteLine("\tContent: " + responseMessage?.Content.ReadAsStringAsync().Result);
                    writer.WriteLine("-----------------------------------------");
                    writer.WriteLine();
                    writer.Flush();
                    writer.Close();
                }
            }
            catch(Exception e) 
            {
                if (!silent)
                    throw;
            }
        }
    }
}
