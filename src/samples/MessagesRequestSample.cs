using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Samples
{
    public class MessagesRequestSample
    {
        public async Task Execute()
        {
            try
            {
                IAuthenticator authenticator = new FormsAuthenticator
                (DimeSchedulerCredentials.Uri,
                    DimeSchedulerCredentials.User,
                    DimeSchedulerCredentials.Password);

                DimeSchedulerClient client = new(DimeSchedulerCredentials.Uri, authenticator);
                IMessageEndpoint endpoint = await client.Messages.Request();
                await endpoint.PostAsync(new MessageRequest() { Text = "Danger!", User = "Admin", Severity = Severity.Warning });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}