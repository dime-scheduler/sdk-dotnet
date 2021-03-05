using System;
using System.Collections.Generic;
using System.Net;
using Bogus;
using Bogus.Extensions;
using Dime.Scheduler.Sdk.Import;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Samples
{
    public class NotificationImportRequestSample
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

                Notification notificationRequest = new Faker<Notification>()
                    .RuleFor(x => x.SourceApp, f => "IMPORT")
                    .RuleFor(x => x.SourceType, f => "IMPORT")
                    .RuleFor(x => x.Text, f => f.Rant.Review("Dime.Scheduler").ClampLength())
                    .RuleFor(x => x.Code, f => f.Finance.AccountName())
                    .RuleFor(x => x.Date, f => f.Date.Soon(10))
                    .RuleFor(x => x.Type, f => f.PickRandom<NotificationType>())
                    .Generate();

                IImportEndpoint importEndpoint = await client.Import.Request();
                await importEndpoint.ProcessAsync(notificationRequest, TransactionType.Append);
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
    }
}