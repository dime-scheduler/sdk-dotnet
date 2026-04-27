using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Dime.Scheduler.Entities;
using Dime.Scheduler.Internal;

namespace Dime.Scheduler
{
    /// <summary>
    /// Send a transient message to a user (or all users in the tenant).
    /// </summary>
    public sealed class MessageApi
    {
        private readonly Dispatcher _dispatcher;

        internal MessageApi(Dispatcher dispatcher) => _dispatcher = dispatcher;

        public Task<Result> SendAsync(Message message, CancellationToken ct = default)
            => _dispatcher.SendAsync("/message", HttpMethod.Post, message, ct);
    }

    /// <summary>
    /// Register and remove webhook-style connectors.
    /// </summary>
    public sealed class ConnectorApi
    {
        private readonly Dispatcher _dispatcher;

        internal ConnectorApi(Dispatcher dispatcher) => _dispatcher = dispatcher;

        public Task<Result> CreateAsync(NewConnectorRequest request, CancellationToken ct = default)
            => _dispatcher.SendAsync("/connector", HttpMethod.Post, request, ct);
    }
}
