
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Acumatica.Default_26_200_001.Model;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.Loggers;

using static Acumatica.RESTClient.AuthApi.AuthApiExtensions;
using static Acumatica.RESTClient.ContractBasedApi.ApiClientExtensions;
using static Acumatica.RESTClient.FileApi.ApiClientExtensions;

namespace AcumaticaRestApiExample
{
    public class RESTExample_26_200_001
	{
        public static void TestReportDownload(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
        {
            var client = new ApiClient(siteURL,
                requestInterceptor: FileRequestLogger.LogRequest,
                responseInterceptor: FileRequestLogger.LogResponse,
                 ignoreSslErrors: true // this is here to allow testing with self-signed certificates
                );

            try
            {
                client.Login(username, password, tenant, branch, locale);

                Console.WriteLine("Starting report");
                var location = client.StartReport(new InvoiceMemoPrintForm() { DocumentType = "Invoice", ReferenceNumber = "AR014526" });
                var reportData = client.GetReport(location);

                Console.WriteLine($"Received {reportData.Length} bytes of report data");
              
            }
            finally
            {
                //we use logout in finally block because we need to always logout, even if the request failed for some reason
                ConsoleReport.Logout(client);
            }
        }

        public static void TestFileUpload(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
		{
            var client = new ApiClient(siteURL,
				requestInterceptor: FileRequestLogger.LogRequest, 
                responseInterceptor: FileRequestLogger.LogResponse,
                 ignoreSslErrors: true // this is here to allow testing with self-signed certificates
                );

            try
            {
                client.Login(username, password, tenant, branch, locale);

                Console.WriteLine("File Upload/Download");
                var order = client.GetByKeys<SalesOrder>(new List<string>() { "SO", "SO005207" }, expand: "files");

                byte[] initialData = Encoding.UTF8.GetBytes("Acumatica is awesome");
                string fileName = "TestFile.txt";
                string fileDesc = "It is the file description";
                //Obsolete
                //client.PutFile<SalesOrder>("SO/SO005207", fileName, initialData);
                client.PutFile(order, fileName, initialData, fileDesc);

                order = client.GetByKeys<SalesOrder>(new List<string>() { "SO", "SO005207" }, expand: SalesOrder.Expand.Files);

                var fileRef = order.Files.Single(fl => fl.Filename.EndsWith(@"\" + fileName));

                if (fileRef != null)
                {
                    Console.WriteLine($"The file {fileName} was uploaded successfully");
                }
                if (fileRef?.Comment == fileDesc)
                {
                    Console.WriteLine($"The file {fileName} has description {fileDesc}");
                }
            }
            finally
            {
                //we use logout in finally block because we need to always logout, even if the request failed for some reason
                ConsoleReport.Logout(client);
            }
        }
        public static void TestFullSOProcess(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
        {
            var client = new ApiClient(siteURL,
                requestInterceptor: FileRequestLogger.LogRequest,
                responseInterceptor: FileRequestLogger.LogResponse,
                ignoreSslErrors: true // this is here to allow testing with self-signed certificates
                );

            try
            {
                client.Login(username, password, tenant, branch, locale);

                Console.WriteLine("Customer Retrieval");
                client.GetList<Customer>();
				var customer = client.GetList<Customer>(top:1, filter: "Status eq 'A'", select: "CustomerID").Single();
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Create SO for the Customer");
                    var so = client.Put(new SalesOrder()
                    {
                        CustomerID = customer.CustomerID,
                        Date = DateTime.Now.AddDays(-1),
                        Details = new List<SalesOrderDetail>()
                    {
                        new SalesOrderDetail()
                        {
                            InventoryID = "AACOMPUT01",
                            OrderQty = 1, 
                        }
                    }
                    }, expand: "Details");

                    Console.WriteLine("Create Shipment for the SO");
                    var shipment = client.Put(new Shipment()
                    {
                        CustomerID = customer.CustomerID,
                        WarehouseID = so.Details!.Single().WarehouseID,
                        Details = new List<ShipmentDetail>()
                    {
                        new ShipmentDetail()
                        {
                            OrderNbr = so.OrderNbr,
                            OrderType = so.OrderType,
                            OrderLineNbr = so.Details!.First().LineNbr,
                        }
                    }
                    });
                    Console.WriteLine("Confirm Shipment");
                    client.WaitActionCompletion(client.InvokeAction(new ConfirmShipment(shipment)));
                    Console.WriteLine("Create Invoice for the Shipment");

                    client.WaitActionCompletion(client.InvokeAction(new PrepareInvoice(shipment)));
                    shipment = client.GetById<Shipment>(shipment.ID, expand: "Orders");

                    Console.WriteLine("Release Invoice");
                    client.WaitActionCompletion(client.InvokeAction(new ReleaseSalesInvoice(new SalesInvoice() { ReferenceNbr = shipment.Orders!.Single().InvoiceNbr, Type = shipment.Orders!.Single().InvoiceType })));

                    //check status of the sales order
                    so = client.GetById<SalesOrder>(so.ID, select: "Status");
                    Console.WriteLine($"Sales Order {so.OrderNbr} has status {so.Status}");
                }
            }
            finally
            {
                //we use logout in finally block because we need to always logout, even if the request failed for some reason
                ConsoleReport.Logout(client);
            }
        }

        public static void TestShipmentRetrieval(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
        {
            var client = new ApiClient(siteURL,
                requestInterceptor: FileRequestLogger.LogRequest,
                responseInterceptor: FileRequestLogger.LogResponse,
                 ignoreSslErrors: true // this is here to allow testing with self-signed certificates
                );

            try
            {
                client.Login(username, password, tenant, branch, locale);

                Console.WriteLine("Shipment Retrieval");
                var shipments = client.GetList<Shipment>();

                Console.WriteLine($"Found {shipments.Count} shipments");
                var recentShipment = client.GetById<Shipment>(shipments.First().ID, expand: new List<string> { Shipment.Expand.Details, Shipment.Expand.Orders});
                Console.WriteLine($"Found {recentShipment.Details.Count} shipment details in the Shipment {recentShipment.ShipmentNbr}");
            }
            finally
            {
                //we use logout in finally block because we need to always logout, even if the request failed for some reason
                ConsoleReport.Logout(client);
            }
        }

		public static void RetrievePOOrdersWithLines(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
		{
			var client = new ApiClient(siteURL,
				requestInterceptor: FileRequestLogger.LogRequest,
				responseInterceptor: FileRequestLogger.LogResponse,
				 ignoreSslErrors: true // this is here to allow testing with self-signed certificates
				);

			try
			{
				client.Login(username, password, tenant, branch, locale);

				Console.WriteLine("Purchase Orders Retrieval");
				var purchaseOrders = client.GetList<PurchaseOrder>(expand: PurchaseOrder.Expand.Details);

				Console.WriteLine($"Found {purchaseOrders.Count} purchase orders");
			}
			finally
			{
				//we use logout in finally block because we need to always logout, even if the request failed for some reason
				ConsoleReport.Logout(client);
			}
		}

		public static void RetrieveInvoiceWithApplications(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
		{
			var client = new ApiClient(siteURL,
				requestInterceptor: FileRequestLogger.LogRequest,
				responseInterceptor: FileRequestLogger.LogResponse,
				 ignoreSslErrors: true // this is here to allow testing with self-signed certificates
				);

			try
			{
				client.Login(username, password, tenant, branch, locale);

				Console.WriteLine("Invoice Retrieval with Applications");
				var invoices = client.GetList<Acumatica.Default_26_200_001.Model.Invoice>(filter: "Status eq 'C' and Amount gt 0 and Type eq 'INV'", top: 100);

				Console.WriteLine($"Found {invoices.Count} invoices");
                var invoice = client.GetById<Acumatica.Default_26_200_001.Model.Invoice>(invoices.First().ID, expand: Invoice.Expand.ApplicationsDefault);
                Console.WriteLine($"Invoice {invoice.ReferenceNbr} has {invoice.ApplicationsDefault.Count} applications");
			}
			finally
			{
				//we use logout in finally block because we need to always logout, even if the request failed for some reason
				ConsoleReport.Logout(client);
			}
		}

		public static void CreateAndReleaseAPBill(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
        {
            var client = new ApiClient(siteURL,
                requestInterceptor: FileRequestLogger.LogRequest,
                responseInterceptor: FileRequestLogger.LogResponse,
                ignoreSslErrors: true // this is here to allow testing with self-signed certificates
                );

            try
            {
                client.Login(username, password, tenant, branch, locale);

                Console.WriteLine("Creating AP Bill");
                var bill = client.Put(new Bill()
                {
                    Vendor = "AAVENDOR",
                    VendorRef= new Guid().ToString(),
                    Hold = false,
                    Details = new List<BillDetail>()
                    {
                        new BillDetail()
                        {
                            InventoryID = "ACCOMODATE",
                            Qty = 1,
                            UnitCost = 100
                        }
                    }
                });
                Console.WriteLine($"Created AP Bill {bill.ReferenceNbr}. Releasing...");
                client.WaitActionCompletion(client.InvokeAction(new ReleaseBill(bill)));
                bill = client.GetById<Bill>(bill.ID, select: "Status");
                Console.WriteLine($"Bill {bill.ReferenceNbr} has status {bill.Status}");
            }
            finally
            {
                //we use logout in finally block because we need to always logout, even if the request failed for some reason
                ConsoleReport.Logout(client);
            }
        }

        public static void ReadStockItemsWithTranslations(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
        {
            var client = new ApiClient(siteURL,
                requestInterceptor: FileRequestLogger.LogRequest,
                responseInterceptor: FileRequestLogger.LogResponse,
                ignoreSslErrors: true // this is here to allow testing with self-signed certificates
                );

            try
            {
                client.Login(username, password, tenant, branch, locale);
                Console.WriteLine("Reading Stock Items with translations");
                var stockItems = client.GetList<StockItem>(top: 10, expand: "Translations");
                stockItems.ForEach(si => Console.WriteLine($"Stock Item {si.InventoryID} has translations"));
            }
            finally
            {
                //we use logout in finally block because we need to always logout, even if the request failed for some reason
                ConsoleReport.Logout(client);
            }
        }


        public static void TryToCreateARInvoiceAndFail(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
        {
            var client = new ApiClient(siteURL,
                requestInterceptor: FileRequestLogger.LogRequest,
                responseInterceptor: FileRequestLogger.LogResponse,
                ignoreSslErrors: true // this is here to allow testing with self-signed certificates
                );

            try
            {
                client.Login(username, password, tenant, branch, locale);

                Console.WriteLine("Creating AR Invoice");
                var bill = client.Put(new Invoice()
                {
                    Customer = "ABARTENDE",
                    Type = "IN" //it's incorrect. It should be "Invoice"
                });
            }
            finally
            {
                //we use logout in finally block because we need to always logout, even if the request failed for some reason
                ConsoleReport.Logout(client);
            }
        }

		public static void UpdateBill(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
		{
			var client = new ApiClient(siteURL,
				requestInterceptor: FileRequestLogger.LogRequest,
				responseInterceptor: FileRequestLogger.LogResponse,
				ignoreSslErrors: true // this is here to allow testing with self-signed certificates
				);

			try
			{
				client.Login(username, password, tenant, branch, locale);

				Console.WriteLine("Reading Bills");
				var bill = client.GetList<Bill>(filter: "Status eq 'Balanced'", top: 1, expand: Bill.Expand.Files).FirstOrDefault();

				if (bill == null)
				{
					Console.WriteLine("No Balanced bill found.");
					bill = CreateBalancedBillFromLatestClosedOrOpen(client);
				}

				bill.Description = "Updated description " + DateTime.Now;
				client.Put(bill);
				Console.WriteLine($"Updated Bill {bill.ReferenceNbr}");
			}
			finally
			{
				//we use logout in finally block because we need to always logout, even if the request failed for some reason
				ConsoleReport.Logout(client);
			}
		}

		/// <summary>
		/// How many bills are read when looking for one to copy. See the remark in
		/// <see cref="CreateBalancedBillFromLatestClosedOrOpen"/> for why the scan is bounded.
		/// </summary>
		private const int BillsToScanForACopySource = 100;

		/// <summary>
		/// Builds a Balanced bill by copying the vendor and the lines of the most recent Closed or
		/// Open one. A bill that is not on hold and whose lines add up is Balanced, so the copy is
		/// ready for the example to update.
		/// </summary>
		private static Bill CreateBalancedBillFromLatestClosedOrOpen(ApiClient client)
		{
			Console.WriteLine("Looking for the last Closed or Open bill to copy");

			// The contract based API has no $orderby, so the most recent record is picked here
			// instead of by the server. The scan is bounded to keep the example quick, which means
			// "last" is the newest of the first BillsToScanForACopySource bills returned.
			var source = client.GetList<Bill>(
					filter: "Status eq 'Closed' or Status eq 'Open'",
					expand: Bill.Expand.Details,
					top: BillsToScanForACopySource)
				.OrderByDescending(_ => _.LastModifiedDateTime?.Value ?? DateTime.MinValue)
				.FirstOrDefault();

			if (source == null)
			{
				throw new InvalidOperationException(
					"This instance has no Balanced, Closed or Open bill, so there is nothing to update or to copy.");
			}

			Console.WriteLine($"Copying Bill {source.ReferenceNbr} ({source.Status})");

			// The lines are rebuilt rather than reused: the ones that were read back carry the
			// source bill's line ids, and sending those would edit that bill instead of filling
			// in the new one.
			var details = new List<BillDetail>();
			foreach (var line in source.Details ?? new List<BillDetail>())
			{
				details.Add(new BillDetail()
				{
					InventoryID = line.InventoryID,
					Qty = line.Qty,
					UnitCost = line.UnitCost,
					TransactionDescription = line.TransactionDescription
				});
			}

			var created = client.Put(new Bill()
			{
				Vendor = source.Vendor,
				VendorRef = Guid.NewGuid().ToString(),
				Description = "Created from " + source.ReferenceNbr,
				Hold = false, // taking the bill off hold is what makes it Balanced
				Details = details
			});

			Console.WriteLine($"Created Bill {created.ReferenceNbr} with status {created.Status}");
			return created;
		}

	}
}
