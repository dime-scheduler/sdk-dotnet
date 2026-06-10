using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Dime.Scheduler.Entities;
using Dime.Scheduler.Internal;

namespace Dime.Scheduler
{
    /// <summary>
    /// Geocoding: convert addresses to coordinates.
    /// </summary>
    public sealed class GeocodeApi
    {
        private readonly Dispatcher _dispatcher;

        internal GeocodeApi(Dispatcher dispatcher) => _dispatcher = dispatcher;

        /// <summary>Convert a structured address to geographic coordinates.</summary>
        public Task<Result<GeoCoordinate>> GeocodeAsync(Address address, CancellationToken ct = default)
            => _dispatcher.SendAsync<GeoCoordinate>("/geocode", HttpMethod.Post, address, ct);

        /// <summary>Convert an address string to geographic coordinates.</summary>
        public Task<Result<GeoCoordinate>> GeocodeAsync(string address, string country, CancellationToken ct = default)
        {
            string query = $"/geocode?address={Uri.EscapeDataString(address)}&country={Uri.EscapeDataString(country)}";
            return _dispatcher.GetAsync<GeoCoordinate>(query, ct);
        }
    }

    /// <summary>
    /// Optimization solvers: VRP for field service, task assignment for professional services,
    /// TSP for daily routes.
    /// </summary>
    public sealed class OptimizationApi
    {
        private readonly Dispatcher _dispatcher;

        internal OptimizationApi(Dispatcher dispatcher) => _dispatcher = dispatcher;

        /// <summary>Optimize field service routes for the specified resources and date range.</summary>
        public Task<Result> OptimizeFieldServiceAsync(FieldServiceOptimizationRequest request, CancellationToken ct = default)
            => _dispatcher.SendAsync("/optimization/fieldService", HttpMethod.Post, request, ct);

        /// <summary>Optimize professional services schedules.</summary>
        public Task<Result> OptimizeProfessionalServicesAsync(ProfessionalServicesOptimizationRequest request, CancellationToken ct = default)
            => _dispatcher.SendAsync("/optimization/professionalServices", HttpMethod.Post, request, ct);

        /// <summary>Optimize the daily route for a specific resource.</summary>
        public Task<Result> OptimizeDailyRouteAsync(OptimizeDailyRouteRequest request, CancellationToken ct = default)
            => _dispatcher.SendAsync("/optimization/dailyRoute", HttpMethod.Post, request, ct);
    }

    /// <summary>
    /// Resource recommendation engine.
    /// </summary>
    public sealed class RecommendationApi
    {
        private readonly Dispatcher _dispatcher;

        internal RecommendationApi(Dispatcher dispatcher) => _dispatcher = dispatcher;

        /// <summary>Get recommended resources with available slots for a given date range.</summary>
        public Task<Result> GetRecommendationsAsync(RecommendationRequest request, CancellationToken ct = default)
            => _dispatcher.SendAsync("/recommendation", HttpMethod.Post, request, ct);

        /// <summary>List the scorer keys that can be weighted in a recommendation request.</summary>
        public Task<Result> GetScorersAsync(CancellationToken ct = default)
            => _dispatcher.SendAsync("/recommendation/scorers", HttpMethod.Get, body: null, ct);
    }

    /// <summary>
    /// User administration.
    /// </summary>
    public sealed class UserApi
    {
        private readonly Dispatcher _dispatcher;

        internal UserApi(Dispatcher dispatcher) => _dispatcher = dispatcher;

        /// <summary>Create a new user.</summary>
        public Task<Result> CreateAsync(ApiUser user, CancellationToken ct = default)
            => _dispatcher.SendAsync("/user", HttpMethod.Post, user, ct);
    }
}
