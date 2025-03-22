using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Dime.Scheduler.Entities;
using RestSharp;
using RestSharp.Serializers.Json;

using t = System.Threading.Tasks;

namespace Dime.Scheduler
{
    internal class AppointmentEndpoint : Endpoint, IAppointmentEndpoint
    {
        internal AppointmentEndpoint(EndpointOptions opts)
            : base(opts)
        {
        }

        protected override async Task<Result> ExecuteAsync<TRequest>(string endpoint, Method method, TRequest requestParameters, bool expectsArray = false)
        {
            try
            {
                (string uri, string key) = _opts;

                Uri baseUri = new(uri);
                Uri endpointUri = new(baseUri, endpoint);

                JsonSerializerOptions options = new()
                {
                    PropertyNameCaseInsensitive = true
                };

                RestClient client = new(uri, configureSerialization: s => s.UseSystemTextJson(options));
                RestRequest request = new(endpointUri, method);
                request.AddHeader("accept-encoding", "gzip, deflate");
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("X-API-KEY", key);
                request.AddBody(expectsArray ? new List<TRequest> { requestParameters } : requestParameters);

                RestResponse<ImportResponse> response = await client.ExecuteAsync<ImportResponse>(request);
                return response.IsSuccessful && (response.Data?.IsSuccess ?? false)
                    ? AppointmentResult.Ok(response.Data.GetSuccessContent().Appointments)
                    : AppointmentResult.Fail(GetError(response));
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }

        t.Task<Result> ICrudEndpoint<Appointment>.CreateAsync(Appointment requestParameters)
            => ExecuteAsync(Routes.Appointment.Entity, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<Appointment>.UpdateAsync(Appointment requestParameters)
            => ExecuteAsync(Routes.Appointment.Entity, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<Appointment>.DeleteAsync(Appointment requestParameters)
            => ExecuteAsync(Routes.Appointment.Entity, Method.Delete, requestParameters);

        t.Task<Result> ICrudEndpoint<Assignment>.CreateAsync(Assignment requestParameters)
            => ExecuteAsync(Routes.Appointment.Assignment, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<Assignment>.UpdateAsync(Assignment requestParameters)
            => ExecuteAsync(Routes.Appointment.Assignment, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<Assignment>.DeleteAsync(Assignment requestParameters)
            => ExecuteAsync(Routes.Appointment.Assignment, Method.Delete, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentCategory>.CreateAsync(AppointmentCategory requestParameters)
            => ExecuteAsync(Routes.Appointment.Category, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentCategory>.UpdateAsync(AppointmentCategory requestParameters)
            => ExecuteAsync(Routes.Appointment.Category, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentCategory>.DeleteAsync(AppointmentCategory requestParameters)
            => ExecuteAsync(Routes.Appointment.Category, Method.Delete, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentContent>.CreateAsync(AppointmentContent requestParameters)
            => ExecuteAsync(Routes.Appointment.Content, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentContent>.UpdateAsync(AppointmentContent requestParameters)
            => ExecuteAsync(Routes.Appointment.Content, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentContent>.DeleteAsync(AppointmentContent requestParameters)
            => ExecuteAsync(Routes.Appointment.Content, Method.Delete, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentLocked>.CreateAsync(AppointmentLocked requestParameters)
            => ExecuteAsync(Routes.Appointment.Locked, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentLocked>.UpdateAsync(AppointmentLocked requestParameters)
            => ExecuteAsync(Routes.Appointment.Locked, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentLocked>.DeleteAsync(AppointmentLocked requestParameters)
            => ExecuteAsync(Routes.Appointment.Locked, Method.Delete, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentTimeMarker>.CreateAsync(AppointmentTimeMarker requestParameters)
            => ExecuteAsync(Routes.Appointment.TimeMarker, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentTimeMarker>.UpdateAsync(AppointmentTimeMarker requestParameters)
            => ExecuteAsync(Routes.Appointment.TimeMarker, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentTimeMarker>.DeleteAsync(AppointmentTimeMarker requestParameters)
            => ExecuteAsync(Routes.Appointment.TimeMarker, Method.Delete, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentUri>.CreateAsync(AppointmentUri requestParameters)
            => ExecuteAsync(Routes.Appointment.Uri, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentUri>.UpdateAsync(AppointmentUri requestParameters)
            => ExecuteAsync(Routes.Appointment.Uri, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentUri>.DeleteAsync(AppointmentUri requestParameters)
            => ExecuteAsync(Routes.Appointment.Uri, Method.Delete, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentContainer>.CreateAsync(AppointmentContainer requestParameters)
            => ExecuteAsync(Routes.Appointment.Container, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentContainer>.UpdateAsync(AppointmentContainer requestParameters)
            => ExecuteAsync(Routes.Appointment.Container, Method.Post, requestParameters);

        t.Task<Result> ICrudEndpoint<AppointmentContainer>.DeleteAsync(AppointmentContainer requestParameters)
            => ExecuteAsync(Routes.Appointment.Container, Method.Delete, requestParameters);

        Task<Result> ICrudEndpoint<AppointmentImportance>.CreateAsync(AppointmentImportance requestParameters)
              => ExecuteAsync(Routes.Appointment.Importance, Method.Post, requestParameters);

        Task<Result> ICrudEndpoint<AppointmentImportance>.UpdateAsync(AppointmentImportance requestParameters)
                => ExecuteAsync(Routes.Appointment.Importance, Method.Post, requestParameters);

        Task<Result> ICrudEndpoint<AppointmentImportance>.DeleteAsync(AppointmentImportance requestParameters)
              => ExecuteAsync(Routes.Appointment.Importance, Method.Delete, requestParameters);

        Task<Result> ICrudEndpoint<AppointmentPlanningQuantity>.CreateAsync(AppointmentPlanningQuantity requestParameters)
               => ExecuteAsync(Routes.Appointment.PlanningQuantity, Method.Post, requestParameters);

        Task<Result> ICrudEndpoint<AppointmentPlanningQuantity>.UpdateAsync(AppointmentPlanningQuantity requestParameters)
            => ExecuteAsync(Routes.Appointment.PlanningQuantity, Method.Post, requestParameters);

        Task<Result> ICrudEndpoint<AppointmentPlanningQuantity>.DeleteAsync(AppointmentPlanningQuantity requestParameters)
            => ExecuteAsync(Routes.Appointment.PlanningQuantity, Method.Delete, requestParameters);

        Task<Result> ICrudEndpoint<AppointmentFieldValue>.CreateAsync(AppointmentFieldValue requestParameters)
            => ExecuteAsync(Routes.Appointment.FieldValue, Method.Post, requestParameters);

        Task<Result> ICrudEndpoint<AppointmentFieldValue>.UpdateAsync(AppointmentFieldValue requestParameters)
            => ExecuteAsync(Routes.Appointment.FieldValue, Method.Post, requestParameters);

        Task<Result> ICrudEndpoint<AppointmentFieldValue>.DeleteAsync(AppointmentFieldValue requestParameters)
            => ExecuteAsync(Routes.Appointment.FieldValue, Method.Delete, requestParameters);
    }
}