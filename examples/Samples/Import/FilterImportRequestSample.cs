using System;
using System.Collections.Generic;
using Bogus;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.Sdk.Samples
{
    public class FilterImportRequestSample
    {
        public async System.Threading.Tasks.Task ExecuteWithResult()
        {
            try
            {
                Console.WriteLine("Importing filter groups");

                IAuthenticator authenticator = new FormsAuthenticator
                (DimeSchedulerCredentials.Uri,
                    DimeSchedulerCredentials.User,
                    DimeSchedulerCredentials.Password);

                DimeSchedulerClient client = new(DimeSchedulerCredentials.Uri, authenticator);

                List<string> groups = new() { "Department", "Skill", "Language", "Drivers License", "Region", "Contract Type" };

                for (int i = 0; i < 3; i++)
                {
                    FilterGroup filterGroup = new Faker<FilterGroup>()
                        .RuleFor(x => x.Name, (f, u) => f.PickRandom(groups) + " " + i)
                        .Generate();

                    IImportEndpoint importEndpoint = await client.Import.Request();
                    await importEndpoint.ProcessAsync(filterGroup, TransactionType.Append);

                    for (int y = 0; y < 5; y++)
                    {
                        FilterValue filterValue = new Faker<FilterValue>()
                            .RuleFor(x => x.Group, (f, u) => filterGroup.Name)
                            .RuleFor(x => x.Value, (f, u) => filterGroup.Name + " " + y)
                            .Generate();

                        await importEndpoint.ProcessAsync(filterValue, TransactionType.Append);
                    }
                }

                Console.WriteLine("All done importing filter groups");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}