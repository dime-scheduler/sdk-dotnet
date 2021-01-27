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
                string uri = DimeSchedulerCredentials.Uri;
                DimeSchedulerClient client = new(uri);
                await client.Authenticate(DimeSchedulerCredentials.User, DimeSchedulerCredentials.Password);

                ImportRequest importRequest = new(
                    "mboc_upsertExchangeAppointment",
                    new List<string>
                    {
                        "AppointmentId",
                        "Start",
                        "End",
                        "Subject",
                        "Body",
                        "Importance",
                        "ResourceEmail"
                    }.ToArray(),
                    new List<string>
                    {
                        "0",
                        new DateTime(2021,1,15, 10, 0,0).ToString("s") + "",
                        new DateTime(2021,1,15, 12, 0,0).ToString("s") + "",
                        "Hello world",
                        "Lorem ipsum",
                        "0",
                        "hendrik.bulens@dimenics.com"
                    }.ToArray())
                {
                    Uri = uri,
                    AuthenticationToken = client.AuthenticationToken
                };

                ImportEndpointService importEndpoint = client.CreateEndpointService<ImportEndpointService>();
                await importEndpoint.InsertData(importRequest);
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
                string uri = DimeSchedulerCredentials.Uri;
                DimeSchedulerClient client = new(uri);
                await client.Authenticate(DimeSchedulerCredentials.User, DimeSchedulerCredentials.Password);

                ImportRequest importRequest = new(
                    "mboc_upsertExchangeAppointment",
                    new List<string>
                    {
                        "AppointmentId",
                        "AppointmentGuid",
                        "Start",
                        "End",
                        "Subject",
                        "Body",
                        "Importance",
                        "ResourceEmail"
                    }.ToArray(),
                    new List<string>
                    {
                        "0",
                        Guid.NewGuid().ToString(),
                        new DateTime(2021,1,15, 10, 0,0).ToString("s") + "",
                        new DateTime(2021,1,15, 12, 0,0).ToString("s") + "",
                        "Hello world",
                        "Lorem ipsum",
                        "0",
                        "hendrik.bulens@dimenics.com"
                    }.ToArray())
                {
                    Uri = uri,
                    AuthenticationToken = client.AuthenticationToken
                };

                ImportEndpointService importEndpoint = client.CreateEndpointService<ImportEndpointService>();
                return await importEndpoint.Insert(importRequest);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
