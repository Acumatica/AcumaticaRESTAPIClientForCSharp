using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

using AcumaticaRestApiExample;

using static Acumatica.RESTClient.ContractBasedApi.ApiClientExtensions;
using static Acumatica.RESTClient.AuthApi.AuthApiExtensions;

namespace AcumaticaRestApiExample
{
	public abstract class BaseEndpointApi<EntityType> : EntityAPI<EntityType>
		 where EntityType : Entity, ITopLevelEntity, new()
	{
		public BaseEndpointApi(ApiClient client) : base(client)
		{ }
		public override string GetEndpointPath()
		{
			return "entity/DefaultExtended/20.200.001";
		}
	}
	[DataContract]
	public class Invoice : Acumatica.Default_20_200_001.Model.Invoice
	{
		[DataMember(Name = "ExtendedField", EmitDefaultValue = false)]
		public DecimalValue ExtendedField { get; set; }
	}
	public class InvoiceApi : BaseEndpointApi<Invoice>
	{
		public InvoiceApi(ApiClient client) : base(client)
		{ }
	}
	public class ExtendedEndpointExample
	{
		public static void ExampleMethod(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
		{
			ApiClient client = new ApiClient(siteURL, 
				requestInterceptor: RequestLogger.LogRequest, responseInterceptor: RequestLogger.LogResponse);

			try
			{
                client.Login(username, password, tenant, branch, locale);

				Console.WriteLine("Reading Invoices (extended)...");
				var extendedInvoiceApi = new InvoiceApi(client);
				var invoices = extendedInvoiceApi.GetList(top: 5);
				foreach (var invoice in invoices)
				{
					Console.WriteLine("Invoice Nbr: " + invoice.ReferenceNbr.Value + ";" + "Extended field Value:" + invoice.ExtendedField.Value);
				}

			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				//we use logout in finally block because we need to always logout, even if the request failed for some reason
				if (client.TryLogout())
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
