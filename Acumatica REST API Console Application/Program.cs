using System;
using System.Diagnostics;
using System.Threading.Tasks;

using AcumaticaRestApiExample.Properties;

namespace AcumaticaRestApiExample
{
	class Program
	{
		// Every value below comes from Project Properties > Settings (App.config).

		static async Task Main(string[] args)
		{
			RESTExamples_24();
			RESTExamples_26();
			ExtendedEndpointExamples();
			ODataExamples();
			OAuthExamples();
			//await TestPerformanceAsync();

			ConsoleReport.PrintSummary();
		}

		private static void RESTExamples_24()
		{
			ConsoleReport.Run("24.200.001 - Update Bill", () =>
				RESTExample_24_200_001.UpdateBill(
					Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password,
					Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale));

			ConsoleReport.Run("24.200.001 - Retrieve invoice with applications", () =>
				RESTExample_24_200_001.RetrieveInvoiceWithApplications(
					Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password,
					Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale));

			ConsoleReport.Run("24.200.001 - Retrieve PO orders with lines", () =>
				RESTExample_24_200_001.RetrievePOOrdersWithLines(
					Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password,
					Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale));

			ConsoleReport.Run("24.200.001 - Full sales order process", () =>
				RESTExample_24_200_001.TestFullSOProcess(
					Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password,
					Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale));

			ConsoleReport.Run("24.200.001 - Upload file", () =>
				RESTExample_24_200_001.TestFileUpload(
					Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password,
					Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale));

			ConsoleReport.Run("24.200.001 - Retrieve shipment", () =>
				RESTExample_24_200_001.TestShipmentRetrieval(
					Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password,
					Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale));

			ConsoleReport.Run("24.200.001 - Create and release AP bill", () =>
				RESTExample_24_200_001.CreateAndReleaseAPBill(
					Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password,
					Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale));

			ConsoleReport.Run("24.200.001 - Read stock items with translations", () =>
				RESTExample_24_200_001.ReadStockItemsWithTranslations(
					Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password,
					Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale));

			ConsoleReport.Run("24.200.001 - Create AR invoice and fail", () =>
				RESTExample_24_200_001.TryToCreateARInvoiceAndFail(
					Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password,
					Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale));

			ConsoleReport.Pause();
		}

		private static void RESTExamples_26()
		{
			ConsoleReport.Run("26.200.001 - Update Bill", () =>
				RESTExample_26_200_001.UpdateBill(
					Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password,
					Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale));

			ConsoleReport.Run("26.200.001 - Download report", () =>
				RESTExample_26_200_001.TestReportDownload(
					Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password,
					Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale));

			ConsoleReport.Run("26.200.001 - Retrieve invoice with applications", () =>
				RESTExample_26_200_001.RetrieveInvoiceWithApplications(
					Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password,
					Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale));

			ConsoleReport.Run("26.200.001 - Retrieve PO orders with lines", () =>
				RESTExample_26_200_001.RetrievePOOrdersWithLines(
					Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password,
					Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale));

			ConsoleReport.Run("26.200.001 - Full sales order process", () =>
				RESTExample_26_200_001.TestFullSOProcess(
					Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password,
					Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale));

			ConsoleReport.Run("26.200.001 - Upload file", () =>
				RESTExample_26_200_001.TestFileUpload(
					Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password,
					Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale));

			ConsoleReport.Run("26.200.001 - Retrieve shipment", () =>
				RESTExample_26_200_001.TestShipmentRetrieval(
					Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password,
					Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale));

			ConsoleReport.Run("26.200.001 - Create and release AP bill", () =>
				RESTExample_26_200_001.CreateAndReleaseAPBill(
					Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password,
					Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale));

			ConsoleReport.Run("26.200.001 - Read stock items with translations", () =>
				RESTExample_26_200_001.ReadStockItemsWithTranslations(
					Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password,
					Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale));

			ConsoleReport.Run("26.200.001 - Create AR invoice and fail", () =>
				RESTExample_26_200_001.TryToCreateARInvoiceAndFail(
					Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password,
					Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale));

			ConsoleReport.Pause();
		}

		private static void ExtendedEndpointExamples()
		{
			ConsoleReport.Run("Extended endpoint - Read extended invoices", () =>
				ExtendedEndpointExample.ExampleMethod(
					Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password,
					Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale));

			ConsoleReport.Pause();
		}

		private static void ODataExamples()
		{
			ConsoleReport.Run("OData - Generic inquiry", () =>
				ODataExample.ODataGetGI(
					Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password,
					Settings.Default.Tenant));

			ConsoleReport.Run("OData - Generic inquiry (new URL)", () =>
				ODataExample.ODataGetGINewUrl(
					Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password,
					Settings.Default.Tenant));

			ConsoleReport.Run("OData - DAC", () =>
				ODataExample.ODataGetDAC(
					Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password,
					Settings.Default.Tenant));

			ConsoleReport.Run("OData - DAC (new URL)", () =>
				ODataExample.ODataGetDACNewUrl(
					Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password,
					Settings.Default.Tenant));

			ConsoleReport.Run("OData - OAuth 2.0 (Resource Owner Password Credentials flow)", () =>
				ODataExample.OauthExample(
					Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password,
					Settings.Default.ClientSecretROPC, Settings.Default.ClientIDROPC, Settings.Default.Tenant));

			ConsoleReport.Pause();
		}

		private static void OAuthExamples()
		{
			ConsoleReport.Run("OAuth 2.0 - Authorization Code flow", () =>
				OAuthAuthCodeExample.Example(
					Settings.Default.SiteURL, Settings.Default.ClientSecretAC,
					Settings.Default.ClientIDAC, Settings.Default.RedirectUrl));

			ConsoleReport.Run("OAuth 2.0 - Hybrid flow", () =>
				OAuthHybridExample.Example(
					Settings.Default.SiteURL, Settings.Default.ClientSecretHybrid,
					Settings.Default.ClientIDHybrid, Settings.Default.RedirectUrl));

			ConsoleReport.Pause();
		}

		public static async Task TestPerformanceAsync()
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();
			RestApiPerformanceTest.SyncRestApiMethod(
				Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password,
				Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale);
			sw.Stop();
			Debug.WriteLine("Execution completed for sync in {0} ms.", sw.Elapsed.TotalMilliseconds);

			sw.Start();
			await RestApiPerformanceTest.AsyncRestApiMethod(
				Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password,
				Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale);
			sw.Stop();
			Debug.WriteLine("Execution completed for async in {0} ms.", sw.Elapsed.TotalMilliseconds);
		}
	}
}
