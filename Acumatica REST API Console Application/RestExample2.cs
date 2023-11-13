
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Acumatica.Auth.Api;
using Acumatica.Default_20_200_001.Api;
using Acumatica.Default_20_200_001.Model;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace AcumaticaRestApiExample
{
    public class RESTExample2
    {
        public static void ExampleMethod(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
        {
            var authApi = new AuthApi(siteURL,
                requestInterceptor: RequestLogger.LogRequest, responseInterceptor: RequestLogger.LogResponse
                );

            try
            {
                authApi.LogIn(username, password, tenant, branch, locale);

                Console.WriteLine("Release the invoice");
                var invoiceApi = new SalesInvoiceApi(authApi.ApiClient);
                var invoice = new SalesInvoice()
                {
                    Type = new StringValue("Invoice"),
                    CustomerID = new StringValue("AACUSTOMER"),
                    Hold = new BooleanValue(false),
                };
                var order = invoiceApi.PutEntity(invoice);
                if (order != null)
                {
                    var releaseInvoiceApi = new ReleaseSalesInvoice(invoice);
                    var headerlocation = invoiceApi.InvokeAction(releaseInvoiceApi);
                    Console.WriteLine(headerlocation.ToString());

                    var status = invoiceApi.GetProcessStatus(headerlocation);
                    Console.WriteLine($"Status: {status}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //we use logout in finally block because we need to always logout, even if the request failed for some reason
                if (authApi.TryLogout())
                {
                    Console.WriteLine("Logged out successfully.");
                }
                else
                {
                    Console.WriteLine("An error occured during logout.");
                }
            }
        }
    }
}
