using System;
using Bogus;
using Bogus.Extensions;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.Sdk.Samples
{
    public class TaskImportRequestSample
    {
        public async System.Threading.Tasks.Task ExecuteWithResult()
        {
            try
            {
                IAuthenticator authenticator = new FormsAuthenticator
                (DimeSchedulerCredentials.Uri,
                    DimeSchedulerCredentials.User,
                    DimeSchedulerCredentials.Password);

                DimeSchedulerClient client = new(DimeSchedulerCredentials.Uri, authenticator);
                IImportEndpoint importEndpoint = await client.Import.Request();

                Job jobRequest = new Faker<Job>()
                    .RuleFor(x => x.SourceApp, (f, u) => "IMPORT")
                    .RuleFor(x => x.SourceType, (f, u) => "IMPORT")
                    .RuleFor(x => x.JobNo, f => $"Job {f.Company.CompanyName().ClampLength(0, 50)}")
                    .RuleFor(x => x.ShortDescription, f => $"{f.Rant.Review("Dime.Scheduler").ClampLength(0, 50)}")
                    .RuleFor(x => x.CustomerName, (f, u) => f.Company.CompanyName())
                    .RuleFor(x => x.CustomerEmail, (f, u) => f.Internet.Email())
                    .RuleFor(x => x.CustomerNo, (f, u) => $"{f.Company.CompanyName()} {f.Company.CompanySuffix()}")
                    .RuleFor(x => x.SiteStreet, (f, u) => f.Address.StreetName())
                    .RuleFor(x => x.SiteStreetNo, (f, u) => "1")
                    .RuleFor(x => x.SiteCity, (f, u) => f.Address.City())
                    .RuleFor(x => x.SiteCountry, (f, u) => f.Address.Country())
                    .RuleFor(x => x.SiteCountry, (f, u) => f.Address.CountryCode())
                    .RuleFor(x => x.Responsible, (f, u) => f.Name.FullName())
                    .RuleFor(x => x.Importance, (f, u) => f.Random.Number(0, 2).ToString())
                    .RuleFor(x => x.FreeText1, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText2, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText3, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText4, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText5, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText6, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText7, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText9, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText10, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText11, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText12, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText13, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText14, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText15, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText16, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText17, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText18, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText19, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText20, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeDate1, (f, u) => f.Date.Future())
                    .RuleFor(x => x.FreeDate2, (f, u) => f.Date.Future())
                    .RuleFor(x => x.FreeDate3, (f, u) => f.Date.Future())
                    .RuleFor(x => x.FreeDate4, (f, u) => f.Date.Future())
                    .RuleFor(x => x.FreeDate5, (f, u) => f.Date.Future())
                    .RuleFor(x => x.FreeDecimal1, (f, u) => f.Random.Number())
                    .RuleFor(x => x.FreeDecimal2, (f, u) => f.Random.Number())
                    .RuleFor(x => x.FreeDecimal3, (f, u) => f.Random.Number())
                    .RuleFor(x => x.FreeDecimal4, (f, u) => f.Random.Number())
                    .RuleFor(x => x.FreeDecimal5, (f, u) => f.Random.Number())
                    .RuleFor(x => x.FreeBit1, (f, u) => f.Random.Bool())
                    .RuleFor(x => x.FreeBit2, (f, u) => f.Random.Bool())
                    .RuleFor(x => x.FreeBit3, (f, u) => f.Random.Bool())
                    .RuleFor(x => x.FreeBit4, (f, u) => f.Random.Bool())
                    .RuleFor(x => x.FreeBit5, (f, u) => f.Random.Bool())
                    .Generate();

                ImportSet jobImport = await importEndpoint.ProcessAsync(jobRequest, TransactionType.Append);

                for (int i = 0; i < 10; i++)
                {
                    Task taskRequest = new Faker<Task>()
                    .RuleFor(x => x.SourceApp, (f, u) => jobRequest.SourceApp)
                    .RuleFor(x => x.SourceType, (f, u) => jobRequest.SourceType)
                    .RuleFor(x => x.JobNo, (f, u) => jobRequest.JobNo)
                    .RuleFor(x => x.TaskNo, (f, u) => $"Task {i} {f.Company.CompanyName()}")
                    .RuleFor(x => x.ShortDescription, (f, u) => $"Import task {i}")
                    .RuleFor(x => x.Description, (f, u) => $"Import task {i}")
                    .RuleFor(x => x.FreeText1, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText2, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText3, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText4, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText5, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText6, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText7, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText9, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText10, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText11, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText12, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText13, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText14, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText15, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText16, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText17, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText18, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText19, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeText20, (f, u) => f.Rant.Review("Dime.Scheduler"))
                    .RuleFor(x => x.FreeDate1, (f, u) => f.Date.Future())
                    .RuleFor(x => x.FreeDate2, (f, u) => f.Date.Future())
                    .RuleFor(x => x.FreeDate3, (f, u) => f.Date.Future())
                    .RuleFor(x => x.FreeDate4, (f, u) => f.Date.Future())
                    .RuleFor(x => x.FreeDate5, (f, u) => f.Date.Future())
                    .RuleFor(x => x.FreeDecimal1, (f, u) => f.Random.Number())
                    .RuleFor(x => x.FreeDecimal2, (f, u) => f.Random.Number())
                    .RuleFor(x => x.FreeDecimal3, (f, u) => f.Random.Number())
                    .RuleFor(x => x.FreeDecimal4, (f, u) => f.Random.Number())
                    .RuleFor(x => x.FreeDecimal5, (f, u) => f.Random.Number())
                    .RuleFor(x => x.FreeBit1, (f, u) => f.Random.Bool())
                    .RuleFor(x => x.FreeBit2, (f, u) => f.Random.Bool())
                    .RuleFor(x => x.FreeBit3, (f, u) => f.Random.Bool())
                    .RuleFor(x => x.FreeBit4, (f, u) => f.Random.Bool())
                    .RuleFor(x => x.FreeBit5, (f, u) => f.Random.Bool())
                    .RuleFor(x => x.RequestedStartTime, (f, u) => new TimeSpan(0, f.Random.Number(0, 23), f.Random.Number(0, 59), 0))
                    .RuleFor(x => x.RequestedEndTime, (f, u) => new TimeSpan(0, f.Random.Number(0, 23), f.Random.Number(0, 59), 0))
                    .RuleFor(x => x.InfiniteTask, (f, u) => f.Random.Bool())
                    .Generate();

                    ImportSet taskImport = await importEndpoint.ProcessAsync(taskRequest, TransactionType.Append);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}