using System;
using Bogus;
using Bogus.Extensions;
using Dime.Scheduler.Sdk.Import;
using Dime.Scheduler.Sdk.Samples.Data;

namespace Dime.Scheduler.Sdk.Samples
{
    public class ResourceImportRequestSample
    {
        public async System.Threading.Tasks.Task ExecuteWithResult()
        {
            try
            {
                Console.WriteLine("Running resource import sample");

                IAuthenticator authenticator = new FormsAuthenticator
                (DimeSchedulerCredentials.Uri,
                    DimeSchedulerCredentials.User,
                    DimeSchedulerCredentials.Password);

                DimeSchedulerClient client = new(DimeSchedulerCredentials.Uri, authenticator);
                IImportEndpoint importEndpoint = await client.Import.Request();

                string[] departments = { "Sales", "Marketing", "R&D", "IT", "Warehouse", "Planning", "Accounting" };
                string[] teams = { "Team A", "Team B", "Team C", "Team D", "Team E", "Team F" };

                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine("Importing resource " + i + 1);
                    Import.Resource resourceRequest = ResourceFactory.Create();
                    ImportSet resourceImport = await importEndpoint.ProcessAsync(resourceRequest, TransactionType.Append);
                }

                Console.WriteLine("All done!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}