using System;
using System.Collections.Generic;
using System.Net;
using Dime.Scheduler.Sdk.Import;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Samples
{
    public class ExchangeAppointmentImportRequestSample
    {
        public async t.Task Execute()
        {
            try
            {
                IAuthenticator authenticator = new FormsAuthenticator
                    (DimeSchedulerCredentials.Uri,
                    DimeSchedulerCredentials.User,
                    DimeSchedulerCredentials.Password);

                DimeSchedulerClient client = new(DimeSchedulerCredentials.Uri, authenticator);

                ExchangeAppointment importRequest = new()
                {
                    AppointmentId = 0,
                    Start = DateTime.Now.AddHours(1),
                    End = DateTime.Now.AddHours(2),
                    Subject = "Hello world",
                    Body = "Lorem ipsum",
                    Importance = "0",
                    ResourceEmail = "hendrik.bulens@dimenics.com",
                    Categories = new List<string> { "Category 1" },
                    ExchangeId = "1001",
                    ICalUId = "100"
                };

                IImportEndpoint importEndpoint = await client.Import.Request();
                await importEndpoint.ProcessAsync(importRequest, TransactionType.Append);
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public async t.Task<ImportSet> ExecuteWithResult()
        {
            try
            {
                IAuthenticator authenticator = new FormsAuthenticator
                   (DimeSchedulerCredentials.Uri,
                   DimeSchedulerCredentials.User,
                   DimeSchedulerCredentials.Password);

                DimeSchedulerClient client = new(DimeSchedulerCredentials.Uri, authenticator);

                ExchangeAppointment importRequest = new()
                {
                    AppointmentId = 0,
                    Start = DateTime.Now.AddHours(1),
                    End = DateTime.Now.AddHours(2),
                    Subject = "Hello world",
                    Body = "Lorem ipsum",
                    Importance = "0",
                    ResourceEmail = "hendrik.bulens@dimenics.com"
                };

                IImportEndpoint importEndpoint = await client.Import.Request();
                return await importEndpoint.ProcessAsync(importRequest, TransactionType.Append);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}