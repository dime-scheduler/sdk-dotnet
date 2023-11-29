using Dime.Scheduler.Entities;
using RestSharp;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler
{
    public class MessagesEndpoint : Endpoint<Message>, IMessageEndpoint
    {
        public MessagesEndpoint(EndpointOptions opts)
            : base(opts)
        {
        }

        internal MessagesEndpoint(IDimeSchedulerRestClient<Message> restClient)
            : base(restClient)
        {
        }

        public async Task PostAsync(Message request)
            => await ExecuteAsync(Routes.Message, Method.Post, request);
    }
}