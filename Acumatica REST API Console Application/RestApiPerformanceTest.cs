using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using Acumatica.Default_20_200_001.Api;
using Acumatica.Default_20_200_001.Model;
using Acumatica.RESTClient.Client;

using static Acumatica.RESTClient.AuthApi.AuthApiExtensions;
using static Acumatica.RESTClient.ContractBasedApi.ApiClientExtensions;

namespace AcumaticaRestApiExample
{
    public class RestApiPerformanceTest
    {     
        public static void SyncRestApiMethod(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
		{
			var client = new ApiClient(siteURL,
				requestInterceptor: RequestLogger.LogRequest, 
                responseInterceptor: RequestLogger.LogResponse
                );
         
            for (int i = 0; i < 1000; i++)
            {
                try
                {                
                    client.Login(username, password, tenant, branch, locale);
                    var order = client.GetByKeys<SalesOrder>(new List<string>() { "SO", "SO005207" });
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    client.Logout();

                }
            }
            
		}

        public static async System.Threading.Tasks.Task AsyncRestApiMethod(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
        {
            var client = new ApiClient(siteURL,
                requestInterceptor: RequestLogger.LogRequest,
                responseInterceptor: RequestLogger.LogResponse
                );
            for (int i = 0; i < 1000; i++)
            {
                try
                {
                    await client.LoginAsync(username, password, tenant, branch, locale);

                    var order = await client.GetByKeysAsync<SalesOrder>(new List<string>() { "SO", "SO005207" });
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    await client.LogoutAsync();
                }
            }
            
        }



    }
}
