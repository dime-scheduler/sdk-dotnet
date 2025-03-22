using Dime.Scheduler.Entities;
using RestSharp;
using Task = System.Threading.Tasks.Task;

namespace Dime.Scheduler
{
    internal class MessagesEndpoint : Endpoint<Message>, IMessageEndpoint
    {
        public MessagesEndpoint(EndpointOptions opts) : base(opts)
        {
        }

        public async Task PostAsync(Message request)
            => await ExecuteAsync(Routes.Message, Method.Post, request);
    }
}