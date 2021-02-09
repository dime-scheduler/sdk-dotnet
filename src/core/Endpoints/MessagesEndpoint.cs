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

        public async Task PostAsync(MessageRequest request) 
            => await Execute(Routes.Messages.Post, Method.POST, request);
    }
}