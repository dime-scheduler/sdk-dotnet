using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    public class MessagesEndpoint : Endpoint<Message>, IMessageEndpoint
    {
        public MessagesEndpoint(AuthenticationOptions opts)
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