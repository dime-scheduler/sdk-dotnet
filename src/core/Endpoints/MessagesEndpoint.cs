using System.Threading.Tasks;
using RestSharp;

namespace Dime.Scheduler.Sdk
{
    public class MessagesEndpoint : Endpoint<MessageRequest>, IMessageEndpoint
    {
        public MessagesEndpoint(AuthenticationOptions opts)
            : base(opts)
        {
        }

        internal MessagesEndpoint(IDimeSchedulerRestClient<MessageRequest> restClient)
            : base(restClient)
        {
        }

        public async Task PostAsync(MessageRequest request)
            => await Execute(Routes.Message, Method.Post, request);
    }
}