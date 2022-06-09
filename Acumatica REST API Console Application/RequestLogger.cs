using RestSharp;
using System;
using System.IO;

namespace AcumaticaRestApiExample
{
    public static class RequestLogger
    {
		private const string RequestsLogPath = "RequestsLog.txt";

		/// <summary>
		/// Logs response to RequestsLog.txt file.
		/// </summary>
		public static void LogResponse(RestRequest request, RestResponse response, RestClient restClient)
		{
			StreamWriter writer = new StreamWriter(RequestsLogPath, true);
			writer.WriteLine(DateTime.Now.ToString());
			writer.WriteLine("Response");
			writer.WriteLine("\tStatus code: " + response.StatusCode);
			writer.WriteLine("\tContent: " + response.Content);
			writer.WriteLine("-----------------------------------------");
			writer.WriteLine();
			writer.Flush();
			writer.Close();
		}

		/// <summary>
		/// Logs request to RequestsLog.txt file.
		/// </summary>
		public static void LogRequest(RestRequest request, RestClient restClient)
		{
			StreamWriter writer = new StreamWriter(RequestsLogPath, true);
			writer.WriteLine(DateTime.Now.ToString());
			writer.WriteLine("Request");
			writer.WriteLine("\tMethod: " + request.Method);
			string parameters = "";
			string body = "";
			foreach (var parameter in request.Parameters)
			{
				if (parameter.Type == ParameterType.QueryString)
				{
					parameters += String.IsNullOrEmpty(parameters) ? "?" : "&";
					parameters += parameter.Name + "=" + parameter.Value;
				}

				if (parameter.Type == ParameterType.RequestBody)
					body += parameter.Value;
			}

			writer.WriteLine("\tURL: " + restClient.BuildUri(request) + parameters);
			if (!String.IsNullOrEmpty(body))
				writer.WriteLine("\tBody: " + body);
			writer.WriteLine("-----------------------------------------");
			writer.WriteLine();
			writer.Flush();
			writer.Close();
		}
	}
}
