using Acumatica.DefaultEndpoint_18_200_001.Model;
using SOAPLikeWrapperForDeafultEndpoint_18_200_001;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcumaticaRestApiExample
{
    public class SOAPLikeExample
    {
        public static void ExampleMethod(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
        {
            var restClient = new RESTClient(siteURL);

            try
            {
                restClient.Login(username, password, tenant, branch, locale);
                Console.WriteLine("Logged In");

                Shipment shipment = new Shipment()
                {
                    ShipmentNbr = new StringSearch() { Value = "002644" },
                    //Packages = new ShipmentPackage[]
                    //{
                    //    new ShipmentPackage { 
                    //        ReturnBehavior=  ReturnBehavior.All,
                    //    PacakgeContents = new PacakgeContents[]
                    //    {
                    //        new PacakgeContents() { ReturnBehavior= ReturnBehavior.All}
                    //    }
                    //    }
                    //}
                };
                shipment = (Shipment)restClient.Get(shipment);

                Console.WriteLine("Shipped Qty= " + shipment.ShippedQty.Value);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                restClient.Logout();
                Console.WriteLine("Logged Out");
            }

            Console.ReadLine();
        }
    }
}
