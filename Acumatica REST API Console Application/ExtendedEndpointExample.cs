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
using Acumatica.RESTClient.MaintenanceApi;

namespace AcumaticaRestApiExample
{
	[DataContract]
	public class Invoice : Acumatica.Default_23_200_001.Model.Invoice
	{
		[DataMember(Name = "ExtendedField", EmitDefaultValue = false)]
		public DecimalValue? ExtendedField { get; set; }

        public override string GetEndpointPath()
        {
            return "entity/DefaultExtended/23.200.001"; ;
        }
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

				CreateCustomEndpointIfDoesNotExist(client);

				Console.WriteLine("Reading Invoices (extended)...");
				var invoices = client.GetList<Invoice>(top: 5);
				foreach (var invoice in invoices)
				{
					Console.WriteLine($"Invoice Nbr: {invoice.ReferenceNbr}; Extended field Value: {invoice.ExtendedField}");
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

		private static void CreateCustomEndpointIfDoesNotExist(ApiClient client)
		{
			string? schema = null;

			try
			{
				schema = MaintenanceApi.GetSchema(client, "DefaultExtended", "23.200.001");
			}
			catch
			{

			}
			if (string.IsNullOrEmpty(schema))
			{
				MaintenanceApi.PutSchema(client,
					@"
	<Endpoint xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" name=""DefaultExtended"" version=""23.200.001"" systemContractVersion=""4"" xmlns=""http://www.acumatica.com/entity/maintenance/5.31"">
		<ExtendsEndpoint name=""Default"" version=""23.200.001"" />
		<TopLevelEntity name=""Invoice"" screen=""AR301000"">
			<Fields>
				<Field name=""ExtendedField"" type=""DecimalValue"" />
			</Fields>
		</TopLevelEntity>
	</Endpoint>");
			}
		}
	}
}
