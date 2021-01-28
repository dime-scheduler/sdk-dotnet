using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Samples
{
    public class ResourcesRequestSample
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

                IResourceEndpoint svc = await client.Resources.Request();
                IEnumerable<Resource> resources = await svc.GetAsync(new ResourceRequest());

                foreach (Resource resource in resources)
                    Console.WriteLine(resource.Email);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}