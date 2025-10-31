using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Acumatica.RESTClient.ContractBasedApi
{
    /// <summary>
    /// Queryable wrapper for REST API entities
    /// </summary>
    /// <typeparam name="T">Entity type</typeparam>
    public class EntityQueryable<T> : IOrderedQueryable<T>
    {
        private readonly EntityQueryProvider _provider;
        private readonly Expression _expression;

        public EntityQueryable(EntityQueryProvider provider)
        {
            _provider = provider ?? throw new ArgumentNullException(nameof(provider));
            _expression = Expression.Constant(this);
        }

        public EntityQueryable(EntityQueryProvider provider, Expression expression)
        {
            _provider = provider ?? throw new ArgumentNullException(nameof(provider));
            _expression = expression ?? throw new ArgumentNullException(nameof(expression));
        }

        public Type ElementType => typeof(T);

        public Expression Expression => _expression;

        public IQueryProvider Provider => _provider;

        public IEnumerator<T> GetEnumerator()
        {
            var result = _provider.Execute<IEnumerable<T>>(_expression);
            return result.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Executes the query asynchronously and returns the result as a list
        /// </summary>
        public async Task<List<T>> ToListAsync(CancellationToken cancellationToken = default)
        {
            return await _provider.ExecuteAsync<List<T>>(_expression, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Executes the query asynchronously and returns the first element
        /// </summary>
        public async Task<T> FirstAsync(CancellationToken cancellationToken = default)
        {
            var expression = Expression.Call(
                typeof(Queryable),
                nameof(Queryable.First),
                new[] { typeof(T) },
                _expression);
            return await _provider.ExecuteAsync<T>(expression, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Executes the query asynchronously and returns the first element or default
        /// </summary>
        public async Task<T?> FirstOrDefaultAsync(CancellationToken cancellationToken = default)
        {
            var expression = Expression.Call(
                typeof(Queryable),
                nameof(Queryable.FirstOrDefault),
                new[] { typeof(T) },
                _expression);
            return await _provider.ExecuteAsync<T>(expression, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Executes the query asynchronously and returns the single element
        /// </summary>
        public async Task<T> SingleAsync(CancellationToken cancellationToken = default)
        {
            var expression = Expression.Call(
                typeof(Queryable),
                nameof(Queryable.Single),
                new[] { typeof(T) },
                _expression);
            return await _provider.ExecuteAsync<T>(expression, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Executes the query asynchronously and returns the single element or default
        /// </summary>
        public async Task<T?> SingleOrDefaultAsync(CancellationToken cancellationToken = default)
        {
            var expression = Expression.Call(
                typeof(Queryable),
                nameof(Queryable.SingleOrDefault),
                new[] { typeof(T) },
                _expression);
            return await _provider.ExecuteAsync<T>(expression, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Executes the query asynchronously and returns the count
        /// </summary>
        public async Task<int> CountAsync(CancellationToken cancellationToken = default)
        {
            var expression = Expression.Call(
                typeof(Queryable),
                nameof(Queryable.Count),
                new[] { typeof(T) },
                _expression);
            return await _provider.ExecuteAsync<int>(expression, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Executes the query asynchronously and returns whether any elements exist
        /// </summary>
        public async Task<bool> AnyAsync(CancellationToken cancellationToken = default)
        {
            var expression = Expression.Call(
                typeof(Queryable),
                nameof(Queryable.Any),
                new[] { typeof(T) },
                _expression);
            return await _provider.ExecuteAsync<bool>(expression, cancellationToken).ConfigureAwait(false);
        }
    }
}
