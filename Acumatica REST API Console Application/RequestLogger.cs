
using System;
using System.IO;
using System.Net.Http;

namespace AcumaticaRestApiExample
{
    public static class RequestLogger
	{
		private const string RequestsLogPath = "RequestsLog.txt";

		/// <summary>
		/// Logs response to RequestsLog.txt file.
		/// </summary>
		public static void LogResponse(HttpResponseMessage responseMessage)
		{
			StreamWriter writer = new StreamWriter(RequestsLogPath, true);
			writer.WriteLine(DateTime.Now.ToString());
			writer.WriteLine("Response");
			writer.WriteLine("\tStatus code: " + responseMessage.StatusCode);
			writer.WriteLine("\tContent: " + responseMessage?.Content.ReadAsStringAsync().Result);
			writer.WriteLine("-----------------------------------------");
			writer.WriteLine();
			writer.Flush();
			writer.Close();
		}

		/// <summary>
		/// Logs request to RequestsLog.txt file.
		/// </summary>
		public static void LogRequest(HttpRequestMessage request)
		{
			StreamWriter writer = new StreamWriter(RequestsLogPath, true);
			writer.WriteLine(DateTime.Now.ToString());
			writer.WriteLine("Request");
			writer.WriteLine("\tMethod: " + request.Method);
			string body = request.Content?.ReadAsStringAsync().Result;

			writer.WriteLine("\tURL: " + request.RequestUri);
			if (!String.IsNullOrEmpty(body))
				writer.WriteLine("\tBody: " + body);
			writer.WriteLine("-----------------------------------------");
			writer.WriteLine();
			writer.Flush();
			writer.Close();
		}
	}
}
