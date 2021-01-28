using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Samples
{
    public class ImportRequestSample
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

                ExchangeImportRequest importRequest = new()
                {
                    AppointmentId = 0,
                    Start = new DateTime(2021, 1, 15, 13, 0, 0),
                    End = new DateTime(2021, 1, 15, 14, 0, 0),
                    Subject = "Hello world",
                    Body = "Lorem ipsum",
                    Importance = "0",
                    ResourceEmail = "hendrik.bulens@dimenics.com"
                };

                IImportEndpointService importEndpoint = await client.Import.Request();
                await importEndpoint.ProcessAsync(importRequest);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public async Task<ImportSet> ExecuteWithResult()
        {
            try
            {
                IAuthenticator authenticator = new FormsAuthenticator
                   (DimeSchedulerCredentials.Uri,
                   DimeSchedulerCredentials.User,
                   DimeSchedulerCredentials.Password);

                DimeSchedulerClient client = new(DimeSchedulerCredentials.Uri, authenticator);

                ExchangeImportRequest importRequest = new()
                {
                    AppointmentId = 0,
                    Start = new DateTime(2021, 1, 15, 13, 0, 0),
                    End = new DateTime(2021, 1, 15, 14, 0, 0),
                    Subject = "Hello world",
                    Body = "Lorem ipsum",
                    Importance = "0",
                    ResourceEmail = "hendrik.bulens@dimenics.com"
                };

                IImportEndpointService importEndpoint = await client.Import.Request();
                return await importEndpoint.ProcessAsync(importRequest);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}