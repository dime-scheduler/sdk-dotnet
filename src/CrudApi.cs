using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Dime.Scheduler.Entities;
using Dime.Scheduler.Internal;

namespace Dime.Scheduler
{
    /// <summary>
    /// Generic CRUD client. Same call surface for every import-shaped entity (~33 of them).
    /// </summary>
    public class CrudApi<T> where T : class
    {
        private protected readonly Dispatcher _dispatcher;
        private protected readonly string _route;

        internal CrudApi(Dispatcher dispatcher, string route)
        {
            _dispatcher = dispatcher;
            _route = route;
        }

        public Task<Result<DimeSchedulerApiResponse>> CreateAsync(T entity, CancellationToken ct = default)
            => _dispatcher.SendImportAsync(_route, HttpMethod.Post, entity, ct);

        public Task<Result<DimeSchedulerApiResponse>> CreateAsync(IEnumerable<T> entities, CancellationToken ct = default)
            => _dispatcher.SendImportAsync(_route, HttpMethod.Post, entities, ct);

        public Task<Result<DimeSchedulerApiResponse>> UpdateAsync(T entity, CancellationToken ct = default)
            => _dispatcher.SendImportAsync(_route, HttpMethod.Put, entity, ct);

        public Task<Result<DimeSchedulerApiResponse>> UpdateAsync(IEnumerable<T> entities, CancellationToken ct = default)
            => _dispatcher.SendImportAsync(_route, HttpMethod.Put, entities, ct);

        public Task<Result<DimeSchedulerApiResponse>> DeleteAsync(T entity, CancellationToken ct = default)
            => _dispatcher.SendImportAsync(_route, HttpMethod.Delete, entity, ct);

        public Task<Result<DimeSchedulerApiResponse>> DeleteAsync(IEnumerable<T> entities, CancellationToken ct = default)
            => _dispatcher.SendImportAsync(_route, HttpMethod.Delete, entities, ct);

        /// <summary>
        /// GET the list of records for this entity. The response type is whatever DTO the API returns
        /// for this route (e.g., <c>GetAllAsync&lt;ActionUrlDto&gt;()</c> on <c>ActionUris</c>).
        /// </summary>
        public Task<Result<ICollection<TDto>>> GetAllAsync<TDto>(CancellationToken ct = default)
            where TDto : class
            => _dispatcher.GetAsync<ICollection<TDto>>(_route, ct);
    }
}
