using Dime.Scheduler.Entities;
using RestSharp;
using t = System.Threading.Tasks;

namespace Dime.Scheduler
{
    internal class MessagesEndpoint : Endpoint<Message>, IMessageEndpoint
    {
        public MessagesEndpoint(EndpointOptions opts) : base(opts)
        {
        }

        public async t.Task<Result> PostAsync(Message request)
            => await ExecuteAsync(Routes.Message, Method.Post, request);
    }
}