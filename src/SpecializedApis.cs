using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Dime.Scheduler.Entities;
using Dime.Scheduler.Internal;

namespace Dime.Scheduler
{
    /// <summary>
    /// CRUD for appointments plus the parameterized date-range query.
    /// </summary>
    public sealed class AppointmentApi : CrudApi<Appointment>
    {
        internal AppointmentApi(Dispatcher dispatcher) : base(dispatcher, "/appointment") { }

        /// <summary>
        /// Retrieve a list of appointments within the specified date range, optionally filtered by resources.
        /// </summary>
        public Task<Result<ICollection<AppointmentDto>>> GetAsync(
            DateTime startDate,
            DateTime endDate,
            string[]? resources = null,
            CancellationToken ct = default)
        {
            string query = $"?startDate={Uri.EscapeDataString(startDate.ToString("o"))}&endDate={Uri.EscapeDataString(endDate.ToString("o"))}";
            if (resources is { Length: > 0 })
                foreach (string r in resources)
                    query += $"&resources={Uri.EscapeDataString(r)}";

            return _dispatcher.GetAsync<ICollection<AppointmentDto>>(_route + query, ct);
        }
    }

    /// <summary>
    /// CRUD for resource capacity plus the date-range query.
    /// </summary>
    public sealed class ResourceCapacityApi : CrudApi<ResourceCapacity>
    {
        internal ResourceCapacityApi(Dispatcher dispatcher) : base(dispatcher, "/resourceCapacity") { }

        /// <summary>
        /// Retrieve a list of resource capacities within the specified date range.
        /// </summary>
        public Task<Result<ICollection<ResourceCapacityDto>>> GetAsync(DateTime start, DateTime end, CancellationToken ct = default)
        {
            string query = $"?start={Uri.EscapeDataString(start.ToString("o"))}&end={Uri.EscapeDataString(end.ToString("o"))}";
            return _dispatcher.GetAsync<ICollection<ResourceCapacityDto>>(_route + query, ct);
        }
    }

    /// <summary>
    /// CRUD for notifications plus the paginated query.
    /// </summary>
    public sealed class NotificationApi : CrudApi<Notification>
    {
        internal NotificationApi(Dispatcher dispatcher) : base(dispatcher, "/notification") { }

        /// <summary>
        /// Retrieve a paginated list of notifications with optional sorting, grouping, and filtering.
        /// </summary>
        public Task<Result<ICollection<NotificationDto>>> GetAsync(
            int page,
            int limit,
            string? sort = null,
            string? group = null,
            string? filter = null,
            CancellationToken ct = default)
        {
            string query = $"?page={page}&limit={limit}";
            if (!string.IsNullOrEmpty(sort)) query += $"&sort={Uri.EscapeDataString(sort)}";
            if (!string.IsNullOrEmpty(group)) query += $"&group={Uri.EscapeDataString(group)}";
            if (!string.IsNullOrEmpty(filter)) query += $"&filter={Uri.EscapeDataString(filter)}";

            return _dispatcher.GetAsync<ICollection<NotificationDto>>(_route + query, ct);
        }
    }

    /// <summary>
    /// Get appointment dependencies. Read-only, no CRUD entity.
    /// </summary>
    public sealed class AppointmentDependencyApi
    {
        private readonly Dispatcher _dispatcher;

        internal AppointmentDependencyApi(Dispatcher dispatcher) => _dispatcher = dispatcher;

        public Task<Result<ICollection<AppointmentDependencyDto>>> GetAllAsync(CancellationToken ct = default)
            => _dispatcher.GetAsync<ICollection<AppointmentDependencyDto>>("/appointmentDependency", ct);
    }

    /// <summary>
    /// Read-only list of calendars (no CRUD via the API).
    /// </summary>
    public sealed class CalendarApi
    {
        private readonly Dispatcher _dispatcher;

        internal CalendarApi(Dispatcher dispatcher) => _dispatcher = dispatcher;

        public Task<Result<ICollection<CalendarDto>>> GetAllAsync(CancellationToken ct = default)
            => _dispatcher.GetAsync<ICollection<CalendarDto>>("/calendar", ct);
    }

    /// <summary>
    /// Read-only list of resource types (no CRUD via the API).
    /// </summary>
    public sealed class ResourceTypeApi
    {
        private readonly Dispatcher _dispatcher;

        internal ResourceTypeApi(Dispatcher dispatcher) => _dispatcher = dispatcher;

        public Task<Result<ICollection<ResourceTypeDto>>> GetAllAsync(CancellationToken ct = default)
            => _dispatcher.GetAsync<ICollection<ResourceTypeDto>>("/resourcetype", ct);
    }

    /// <summary>
    /// Read-only list of appointment fields (no CRUD via the API).
    /// </summary>
    public sealed class AppointmentFieldApi
    {
        private readonly Dispatcher _dispatcher;

        internal AppointmentFieldApi(Dispatcher dispatcher) => _dispatcher = dispatcher;

        public Task<Result<ICollection<AppointmentFieldDto>>> GetAllAsync(CancellationToken ct = default)
            => _dispatcher.GetAsync<ICollection<AppointmentFieldDto>>("/appointmentField", ct);
    }
}
