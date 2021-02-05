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

                Filter<Resource> resourceFilter = new Filter<Resource>()
                    .WithOperator(Operator.Eq)
                    .WithProperty(x => x.ExchangeIntegrationEnabled)
                    .WithValue(true.ToString().ToLower());

                string filter = new Filters<Resource> { resourceFilter }.ToString();
                IResourceEndpoint svc = await client.Resources.Request();
                IEnumerable<Resource> resources = await svc.GetAsync(new ResourceRequest { filter = filter });

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