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
                string uri = DimeSchedulerCredentials.Uri;
                DimeSchedulerClient client = new(uri);
                await client.Authenticate(DimeSchedulerCredentials.User, DimeSchedulerCredentials.Password);
                
                ResourcesEndpointService svc = client.CreateEndpointService<ResourcesEndpointService>();
                IEnumerable<Resource> resources = await svc.GetAsync(new ResourceRequest { Uri = uri, AuthenticationToken = client.AuthenticationToken });

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