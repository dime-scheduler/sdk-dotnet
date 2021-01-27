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
                        new DateTime(2021,1,15, 13, 0,0).ToString("s") + "",
                        new DateTime(2021,1,15, 14, 0,0).ToString("s") + "",
                        "Hello world",
                        "Lorem ipsum",
                        "0",
                        "hendrik.bulens@dimenics.com"
                    }.ToArray());

                IImportEndpointService importEndpoint = await client.Import.Request();
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
                IAuthenticator authenticator = new FormsAuthenticator
                   (DimeSchedulerCredentials.Uri,
                   DimeSchedulerCredentials.User,
                   DimeSchedulerCredentials.Password);

                DimeSchedulerClient client = new(DimeSchedulerCredentials.Uri, authenticator);

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
                        new DateTime(2021,1,15, 15, 0,0).ToString("s") + "",
                        new DateTime(2021,1,15, 17, 0,0).ToString("s") + "",
                        "Hello world",
                        "Lorem ipsum",
                        "0",
                        "hendrik.bulens@dimenics.com"
                    }.ToArray());

                IImportEndpointService importEndpoint = await client.Import.Request();
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