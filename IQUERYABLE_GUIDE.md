# IQueryable Support for REST API Client

## Overview

The Acumatica REST API Client now supports IQueryable, allowing you to use LINQ queries that are automatically translated to OData filter expressions. This makes querying the REST API more intuitive and type-safe.

## Features

### LINQ to OData Translation

The client automatically translates LINQ `Where` clauses to OData `$filter` parameters:

```csharp
// LINQ query
var activeCustomers = client.AsQueryable<Customer>()
    .Where(c => c.Status.Value == "Active")
    .ToList();

// Translates to REST call with: $filter=Status/value eq 'Active'
```

### Supported Operators

#### Comparison Operators
- `==` → `eq` (equal)
- `!=` → `ne` (not equal)  
- `>` → `gt` (greater than)
- `>=` → `ge` (greater than or equal)
- `<` → `lt` (less than)
- `<=` → `le` (less than or equal)

```csharp
var orders = client.AsQueryable<SalesOrder>()
    .Where(so => so.OrderTotal.Value >= 1000)
    .ToList();
// Generates: $filter=OrderTotal/value ge 1000
```

#### Logical Operators
- `&&` → `and`
- `||` → `or`
- `!` → `not`

```csharp
var customers = client.AsQueryable<Customer>()
    .Where(c => c.Status.Value == "Active" && c.CustomerClass.Value == "RETAIL")
    .ToList();
// Generates: $filter=(Status/value eq 'Active') and (CustomerClass/value eq 'RETAIL')
```

#### String Methods
- `Contains()` → `contains()`
- `StartsWith()` → `startswith()`
- `EndsWith()` → `endswith()`

```csharp
var customers = client.AsQueryable<Customer>()
    .Where(c => c.CustomerName.Value.Contains("ABC"))
    .ToList();
// Generates: $filter=contains(CustomerName/value,'ABC')
```

### Pagination

Use `Take()` and `Skip()` for pagination:

```csharp
var page2 = client.AsQueryable<Customer>()
    .Where(c => c.Status.Value == "Active")
    .Skip(20)
    .Take(10)
    .ToList();
// Generates: $filter=Status/value eq 'Active'&$skip=20&$top=10
```

### Async Execution

All queries support async execution:

```csharp
// ToListAsync
var customers = await client.AsQueryable<Customer>()
    .Where(c => c.Status.Value == "Active")
    .ToListAsync();

// FirstOrDefaultAsync
var customer = await ((EntityQueryable<Customer>)client.AsQueryable<Customer>()
    .Where(c => c.CustomerID.Value == "CUST001"))
    .FirstOrDefaultAsync();

// CountAsync
var count = await ((EntityQueryable<Customer>)client.AsQueryable<Customer>()
    .Where(c => c.Status.Value == "Active"))
    .CountAsync();

// AnyAsync
var hasActive = await ((EntityQueryable<Customer>)client.AsQueryable<Customer>()
    .Where(c => c.Status.Value == "Active"))
    .AnyAsync();
```

### Combining Filters

You can combine initial filters with LINQ queries:

```csharp
var customers = client.AsQueryable<Customer>(
    filter: "Status eq 'Active'",
    expand: "Contacts",
    select: "CustomerID,CustomerName"
)
    .Where(c => c.CustomerClass.Value == "RETAIL")
    .Take(50)
    .ToList();
// Combines both filters with 'and'
```

## Usage Examples

### Example 1: Simple Query
```csharp
var activeCustomers = client.AsQueryable<Customer>()
    .Where(c => c.Status.Value == "Active")
    .ToList();
```

### Example 2: Multiple Conditions
```csharp
var orders = client.AsQueryable<SalesOrder>()
    .Where(so => so.Status.Value == "Open" && so.OrderTotal.Value > 1000)
    .Take(10)
    .ToList();
```

### Example 3: Date Range
```csharp
var startDate = new DateTime(2024, 1, 1);
var endDate = new DateTime(2024, 12, 31);

var orders = client.AsQueryable<SalesOrder>()
    .Where(so => so.Date.Value >= startDate && so.Date.Value <= endDate)
    .ToList();
```

### Example 4: Pattern Matching
```csharp
var customers = client.AsQueryable<Customer>()
    .Where(c => c.CustomerName.Value.StartsWith("A") && 
                c.CustomerClass.Value != "INACTIVE")
    .ToList();
```

### Example 5: Pagination
```csharp
int pageSize = 20;
int pageNumber = 2;

var customers = client.AsQueryable<Customer>()
    .Where(c => c.Status.Value == "Active")
    .Skip((pageNumber - 1) * pageSize)
    .Take(pageSize)
    .ToList();
```

### Example 6: Async with LINQ
```csharp
var activeWholesaleCustomers = await client.AsQueryable<Customer>()
    .Where(c => c.Status.Value == "Active" && c.CustomerClass.Value == "WHOLESALE")
    .ToListAsync();
```

## Important Notes

### Property Name Translation

The query provider automatically handles `DataMember` attribute names. For example, `Date.Value` in LINQ translates to `Date/value` in the OData filter, matching the JSON serialization.

### Type Constraints

The `AsQueryable<T>()` method requires entities that implement `ITopLevelEntity` and have a parameterless constructor.

### Limitations

1. **OrderBy**: LINQ `OrderBy` is not translated to OData `$orderby`. You must use server-side ordering or apply ordering after fetching.

2. **Select Projection**: While `Select()` for field projection is supported in the underlying API, complex LINQ projections are not translated. Use the `select` parameter for field selection:
```csharp
var customers = client.AsQueryable<Customer>(select: "CustomerID,CustomerName")
    .Where(c => c.Status.Value == "Active")
    .ToList();
```

3. **GroupBy/Join**: These operations are not supported as they don't map to OData queries.

4. **Nested Collections**: Filtering on nested collection properties is limited.

## Migration from GetList

### Before (without IQueryable):
```csharp
var customers = client.GetList<Customer>(
    filter: "Status eq 'Active' and CustomerClass eq 'RETAIL'",
    top: 10,
    skip: 20
);
```

### After (with IQueryable):
```csharp
var customers = client.AsQueryable<Customer>()
    .Where(c => c.Status.Value == "Active" && c.CustomerClass.Value == "RETAIL")
    .Skip(20)
    .Take(10)
    .ToList();
```

Both approaches work, but IQueryable provides better type safety and IntelliSense support.

## Performance Considerations

- The query is not executed until you call a terminal operation like `ToList()`, `ToListAsync()`, `First()`, `Count()`, etc.
- The entire query is translated and sent to the server, so no client-side filtering occurs
- Use `Take()` to limit results and improve performance
- Consider using `CountAsync()` instead of loading all records just to count them

## Error Handling

If an expression cannot be translated to OData, you'll receive a `NotSupportedException`:

```csharp
try
{
    var result = client.AsQueryable<Customer>()
        .Where(c => SomeUnsupportedMethod(c.Status.Value))
        .ToList();
}
catch (NotSupportedException ex)
{
    Console.WriteLine($"Query translation error: {ex.Message}");
}
```

## See Also

- [Acumatica REST API Documentation](https://help.acumatica.com/Help?ScreenId=ShowWiki&pageid=4a6a5858-c3f0-42cc-8167-29f8e0367c80)
- [OData Filter Query Option](https://www.odata.org/getting-started/basic-tutorial/#queryData)
