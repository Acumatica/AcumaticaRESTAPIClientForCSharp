using System;
using System.Linq;
using System.Threading.Tasks;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;

namespace IQueryableExample
{
    /// <summary>
    /// Example demonstrating the new IQueryable support for GetList/GetListAsync methods.
    /// This allows using LINQ Where conditions that are automatically translated to OData $filter parameters.
    /// </summary>
    class Program
    {
        static async Task Main(string[] args)
        {
            // Initialize API client (replace with your actual credentials and URL)
            var client = new ApiClient("https://your-acumatica-instance.com");
            
            // Example 1: Simple Where clause
            Console.WriteLine("Example 1: Simple Where clause");
            var activeCustomers = client.AsQueryable<Customer>()
                .Where(c => c.Status.Value == "Active")
                .ToList();
            Console.WriteLine($"Found {activeCustomers.Count} active customers");

            // Example 2: Multiple conditions with AND
            Console.WriteLine("\nExample 2: Multiple conditions");
            var specificCustomers = client.AsQueryable<Customer>()
                .Where(c => c.Status.Value == "Active" && c.CustomerClass.Value == "WHOLESALE")
                .Take(10)
                .ToList();
            Console.WriteLine($"Found {specificCustomers.Count} active wholesale customers");

            // Example 3: Using Contains for pattern matching
            Console.WriteLine("\nExample 3: String Contains");
            var searchResults = client.AsQueryable<Customer>()
                .Where(c => c.CustomerName.Value.Contains("ABC"))
                .ToList();
            Console.WriteLine($"Found {searchResults.Count} customers with 'ABC' in name");

            // Example 4: Date range filtering
            Console.WriteLine("\nExample 4: Date range");
            var startDate = new DateTime(2024, 1, 1);
            var endDate = new DateTime(2024, 12, 31);
            var salesOrders = client.AsQueryable<SalesOrder>()
                .Where(so => so.Date.Value >= startDate && so.Date.Value <= endDate)
                .ToList();
            Console.WriteLine($"Found {salesOrders.Count} sales orders in 2024");

            // Example 5: Pagination with Skip and Take
            Console.WriteLine("\nExample 5: Pagination");
            var page2Customers = client.AsQueryable<Customer>()
                .Where(c => c.Status.Value == "Active")
                // Note: OrderBy is not supported in LINQ translation. 
                // Use the $orderby parameter on the REST API directly if ordering is needed.
                .Skip(20)
                .Take(10)
                .ToList();
            Console.WriteLine($"Page 2 (items 21-30): {page2Customers.Count} customers");

            // Example 6: Async execution
            Console.WriteLine("\nExample 6: Async execution");
            var asyncCustomers = await client.AsQueryable<Customer>()
                .Where(c => c.Status.Value == "Active")
                .ToListAsync();
            Console.WriteLine($"Async query found {asyncCustomers.Count} customers");

            // Example 7: Count without loading all data
            Console.WriteLine("\nExample 7: Count");
            var count = await ((EntityQueryable<Customer>)client.AsQueryable<Customer>()
                .Where(c => c.Status.Value == "Active"))
                .CountAsync();
            Console.WriteLine($"Total active customers: {count}");

            // Example 8: First or default
            Console.WriteLine("\nExample 8: First or Default");
            var firstCustomer = await ((EntityQueryable<Customer>)client.AsQueryable<Customer>()
                .Where(c => c.CustomerID.Value == "CUST001"))
                .FirstOrDefaultAsync();
            if (firstCustomer != null)
            {
                Console.WriteLine($"Found customer: {firstCustomer.CustomerName?.Value}");
            }

            // Example 9: Combining initial filter with LINQ
            Console.WriteLine("\nExample 9: Combining filters");
            var combined = client.AsQueryable<Customer>(filter: "Status eq 'Active'")
                .Where(c => c.CustomerClass.Value == "RETAIL")
                .ToList();
            Console.WriteLine($"Active retail customers: {combined.Count}");

            // Example 10: Complex boolean logic
            Console.WriteLine("\nExample 10: Complex boolean logic");
            var complexQuery = client.AsQueryable<Customer>()
                .Where(c => (c.Status.Value == "Active" || c.Status.Value == "OnHold") 
                    && c.CustomerClass.Value != "INACTIVE")
                .ToList();
            Console.WriteLine($"Complex query results: {complexQuery.Count}");

            Console.WriteLine("\nAll examples completed!");
        }
    }

    // Simplified entity classes for demonstration
    // In real usage, these would be generated from your Acumatica endpoint schema
    public class Customer : Entity, ITopLevelEntity
    {
        public StringValue CustomerID { get; set; }
        public StringValue CustomerName { get; set; }
        public StringValue Status { get; set; }
        public StringValue CustomerClass { get; set; }

        public string GetEndpointPath() => "entity/Default/22.200.001";
    }

    public class SalesOrder : Entity, ITopLevelEntity
    {
        public StringValue OrderNbr { get; set; }
        public DateTimeValue Date { get; set; }
        public StringValue Status { get; set; }

        public string GetEndpointPath() => "entity/Default/22.200.001";
    }
}
