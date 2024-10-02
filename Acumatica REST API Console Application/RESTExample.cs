
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Acumatica.Default_23_200_001.Model;
using Acumatica.RESTClient.Client;

using static Acumatica.RESTClient.AuthApi.AuthApiExtensions;
using static Acumatica.RESTClient.ContractBasedApi.ApiClientExtensions;
using static Acumatica.RESTClient.FileApi.ApiClientExtensions;

namespace AcumaticaRestApiExample
{
    public class RESTExample
	{
		public static void TestFileUpload(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
		{
            var client = new ApiClient(siteURL,
				requestInterceptor: RequestLogger.LogRequest, 
                responseInterceptor: RequestLogger.LogResponse,
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

                order = client.GetByKeys<SalesOrder>(new List<string>() { "SO", "SO005207" }, expand: "files");

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
        public static void TestFullSOProcess(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
        {
            var client = new ApiClient(siteURL,
                requestInterceptor: RequestLogger.LogRequest,
                responseInterceptor: RequestLogger.LogResponse,
                ignoreSslErrors: true // this is here to allow testing with self-signed certificates
                );

            try
            {
                client.Login(username, password, tenant, branch, locale);

                Console.WriteLine("Customer Retrieval");
                var customer = client.GetList<Customer>(top:1, filter: "Status eq 'Active'", select: "CustomerID").Single();
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

        public static void TestShipmentRetrieval(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
        {
            var client = new ApiClient(siteURL,
                requestInterceptor: RequestLogger.LogRequest,
                responseInterceptor: RequestLogger.LogResponse,
                 ignoreSslErrors: true // this is here to allow testing with self-signed certificates
                );

            try
            {
                client.Login(username, password, tenant, branch, locale);

                Console.WriteLine("Shipment Retrieval");
                var shipments = client.GetList<Shipment>();

                Console.WriteLine($"Found {shipments.Count} shipments");
                var recentShipment = client.GetById<Shipment>(shipments.First().ID, expand: "Details");
                Console.WriteLine($"Found {recentShipment.Details.Count} shipment details in the Shipment {recentShipment.ShipmentNbr}");
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

        public static void CreateAndReleaseAPBill(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
        {
            var client = new ApiClient(siteURL,
                requestInterceptor: RequestLogger.LogRequest,
                responseInterceptor: RequestLogger.LogResponse,
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

        public static void ReadStockItemsWithTranslations(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
        {
            var client = new ApiClient(siteURL,
                requestInterceptor: RequestLogger.LogRequest,
                responseInterceptor: RequestLogger.LogResponse,
                ignoreSslErrors: true // this is here to allow testing with self-signed certificates
                );

            try
            {
                client.Login(username, password, tenant, branch, locale);
                Console.WriteLine("Reading Stock Items with translations");
                var stockItems = client.GetList<StockItem>(top: 10, expand: "Translations");
                stockItems.ForEach(si => Console.WriteLine($"Stock Item {si.InventoryID} has translations"));
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


        public static void TryToCreateARInvoiceAndFail(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
        {
            var client = new ApiClient(siteURL,
                requestInterceptor: RequestLogger.LogRequest,
                responseInterceptor: RequestLogger.LogResponse,
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
