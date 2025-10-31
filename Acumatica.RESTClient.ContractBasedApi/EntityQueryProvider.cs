using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

using Acumatica.RESTClient.Client;

namespace Acumatica.RESTClient.ContractBasedApi
{
    /// <summary>
    /// Query provider that translates LINQ expressions to REST API calls
    /// </summary>
    public class EntityQueryProvider : IQueryProvider
    {
        private readonly ApiClient _client;
        private readonly string? _endpointPath;
        private readonly string? _initialSelect;
        private readonly string? _initialFilter;
        private readonly string? _initialExpand;
        private readonly string? _initialCustom;
        private readonly Dictionary<string, string>? _customHeaders;

        public EntityQueryProvider(
            ApiClient client,
            string? endpointPath = null,
            string? select = null,
            string? filter = null,
            string? expand = null,
            string? custom = null,
            Dictionary<string, string>? customHeaders = null)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
            _endpointPath = endpointPath;
            _initialSelect = select;
            _initialFilter = filter;
            _initialExpand = expand;
            _initialCustom = custom;
            _customHeaders = customHeaders;
        }

        public IQueryable CreateQuery(Expression expression)
        {
            Type elementType = TypeHelper.GetElementType(expression.Type);
            try
            {
                return (IQueryable)Activator.CreateInstance(
                    typeof(EntityQueryable<>).MakeGenericType(elementType),
                    new object[] { this, expression })!;
            }
            catch (TargetInvocationException tie)
            {
                throw tie.InnerException!;
            }
        }

        public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
        {
            return new EntityQueryable<TElement>(this, expression);
        }

        public object? Execute(Expression expression)
        {
            return ExecuteAsync<object>(expression, CancellationToken.None).GetAwaiter().GetResult();
        }

        public TResult Execute<TResult>(Expression expression)
        {
            return ExecuteAsync<TResult>(expression, CancellationToken.None).GetAwaiter().GetResult();
        }

        internal async Task<TResult> ExecuteAsync<TResult>(Expression expression, CancellationToken cancellationToken)
        {
            var queryParameters = ExpressionToQueryParametersVisitor.Translate(expression);

            // Merge initial filters with LINQ-generated filters
            string? finalSelect = CombineParameters(_initialSelect, queryParameters.Select);
            string? finalFilter = CombineFilters(_initialFilter, queryParameters.Filter);
            string? finalExpand = CombineParameters(_initialExpand, queryParameters.Expand);

            // Determine the actual element type (entity type) for the query
            Type elementType;
            var methodCallExpression = expression as MethodCallExpression;
            if (methodCallExpression != null && methodCallExpression.Arguments.Count > 0)
            {
                // Get element type from the source expression (the IQueryable)
                elementType = TypeHelper.GetElementType(methodCallExpression.Arguments[0].Type);
            }
            else
            {
                elementType = TypeHelper.GetElementType(expression.Type);
            }

            // Use reflection to call GetListAsync with the correct entity type
            var getListAsyncMethod = typeof(ApiClientExtensions)
                .GetMethod(nameof(ApiClientExtensions.GetListAsync))!
                .MakeGenericMethod(elementType);

            var task = (Task)getListAsyncMethod.Invoke(null, new object?[]
            {
                _client,
                _endpointPath,
                finalSelect,
                finalFilter,
                finalExpand,
                _initialCustom,
                queryParameters.Skip,
                queryParameters.Top,
                _customHeaders,
                cancellationToken
            })!;

            await task.ConfigureAwait(false);

            var resultProperty = task.GetType().GetProperty("Result");
            var result = resultProperty!.GetValue(task);

            // Handle different return types
            if (typeof(TResult).IsGenericType)
            {
                var genericTypeDef = typeof(TResult).GetGenericTypeDefinition();
                if (genericTypeDef == typeof(List<>))
                {
                    return (TResult)result!;
                }
            }

            if (result is System.Collections.IEnumerable enumerable)
            {
                var resultList = enumerable.Cast<object>().ToList();
                
                // Check if we need to return first/single/count/any
                if (methodCallExpression != null)
                {
                    string methodName = methodCallExpression.Method.Name;
                    
                    switch (methodName)
                    {
                        case "First":
                        case "FirstOrDefault":
                            return (TResult)(resultList.FirstOrDefault() ?? default(TResult)!);
                        case "Single":
                        case "SingleOrDefault":
                            return (TResult)(resultList.SingleOrDefault() ?? default(TResult)!);
                        case "Count":
                        case "LongCount":
                            return (TResult)(object)resultList.Count;
                        case "Any":
                            return (TResult)(object)resultList.Any();
                    }
                }

                return (TResult)result!;
            }

            return (TResult)result!;
        }

        private string? CombineParameters(string? param1, string? param2)
        {
            if (string.IsNullOrEmpty(param1)) return param2;
            if (string.IsNullOrEmpty(param2)) return param1;
            return $"{param1},{param2}";
        }

        private string? CombineFilters(string? filter1, string? filter2)
        {
            if (string.IsNullOrEmpty(filter1)) return filter2;
            if (string.IsNullOrEmpty(filter2)) return filter1;
            return $"({filter1}) and ({filter2})";
        }
    }

    internal static class TypeHelper
    {
        internal static Type GetElementType(Type seqType)
        {
            Type? ienum = FindIEnumerable(seqType);
            if (ienum == null) return seqType;
            return ienum.GetGenericArguments()[0];
        }

        private static Type? FindIEnumerable(Type seqType)
        {
            if (seqType == null || seqType == typeof(string))
                return null;

            if (seqType.IsArray)
                return typeof(IEnumerable<>).MakeGenericType(seqType.GetElementType()!);

            if (seqType.IsGenericType)
            {
                foreach (Type arg in seqType.GetGenericArguments())
                {
                    Type ienum = typeof(IEnumerable<>).MakeGenericType(arg);
                    if (ienum.IsAssignableFrom(seqType))
                        return ienum;
                }
            }

            Type[] ifaces = seqType.GetInterfaces();
            if (ifaces.Length > 0)
            {
                foreach (Type iface in ifaces)
                {
                    Type? ienum = FindIEnumerable(iface);
                    if (ienum != null) return ienum;
                }
            }

            if (seqType.BaseType != null && seqType.BaseType != typeof(object))
                return FindIEnumerable(seqType.BaseType);

            return null;
        }
    }

    internal class QueryParameters
    {
        public string? Select { get; set; }
        public string? Filter { get; set; }
        public string? Expand { get; set; }
        public int? Skip { get; set; }
        public int? Top { get; set; }
    }
}
