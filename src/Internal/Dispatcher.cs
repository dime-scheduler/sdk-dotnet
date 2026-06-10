using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Dime.Scheduler.Entities;

namespace Dime.Scheduler.Internal
{
    /// <summary>
    /// Shared HTTP machinery for every API call the SDK makes.
    /// One instance per <see cref="DimeSchedulerClient"/>; passed to each <see cref="CrudApi{T}"/>.
    /// </summary>
    internal sealed class Dispatcher
    {
        private static readonly JsonSerializerOptions _json = new()
        {
            PropertyNameCaseInsensitive = true
        };

        private readonly HttpClient _http;

        internal Dispatcher(EndpointOptions opts)
        {
            _http = new HttpClient { BaseAddress = new Uri(opts.Uri.TrimEnd('/') + "/") };
            _http.DefaultRequestHeaders.Add("X-API-KEY", opts.Key);
            _http.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        internal Task<Result<DimeSchedulerApiResponse>> SendImportAsync(string route, HttpMethod method, object body, CancellationToken ct = default)
            => SendAsync<DimeSchedulerApiResponse>(route, method, body, ct);

        internal Task<Result<TResponse>> GetAsync<TResponse>(string route, CancellationToken ct = default)
            where TResponse : class
            => SendAsync<TResponse>(route, HttpMethod.Get, body: null, ct);

        internal async Task<Result<TResponse>> SendAsync<TResponse>(string route, HttpMethod method, object? body, CancellationToken ct = default)
            where TResponse : class
        {
            try
            {
                using HttpRequestMessage req = new(method, route);
                if (body is not null)
                    req.Content = JsonContent.Create(body, options: _json);

                using HttpResponseMessage resp = await _http.SendAsync(req, ct);
                string content = await resp.Content.ReadAsStringAsync(ct);

                if (!resp.IsSuccessStatusCode)
                    return Result.Fail<TResponse>(new Error((int)resp.StatusCode, content));

                TResponse? data = JsonSerializer.Deserialize<TResponse>(content, _json);
                return data is null
                    ? Result.Fail<TResponse>(new Error((int)System.Net.HttpStatusCode.InternalServerError, "Empty response."))
                    : Result.Ok(data);
            }
            catch (Exception ex)
            {
                return Result.Fail<TResponse>(new Error((int)System.Net.HttpStatusCode.InternalServerError, ex.Message));
            }
        }

        internal async Task<Result> SendAsync(string route, HttpMethod method, object? body, CancellationToken ct = default)
        {
            try
            {
                using HttpRequestMessage req = new(method, route);
                if (body is not null)
                    req.Content = JsonContent.Create(body, options: _json);

                using HttpResponseMessage resp = await _http.SendAsync(req, ct);
                if (resp.IsSuccessStatusCode)
                    return Result.Ok();

                string content = await resp.Content.ReadAsStringAsync(ct);
                return Result.Fail(new Error((int)resp.StatusCode, content));
            }
            catch (Exception ex)
            {
                return Result.Fail(new Error((int)System.Net.HttpStatusCode.InternalServerError, ex.Message));
            }
        }
    }
}
