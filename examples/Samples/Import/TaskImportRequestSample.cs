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

                Job jobRequest = CreateJobRequest();
                ImportSet jobImport = await importEndpoint.ProcessAsync(jobRequest, TransactionType.Append);
                for (int i = 0; i < 10; i++)
                {
                    Task taskRequest = CreateTaskRequest(jobRequest, i);

                    Console.WriteLine($"Importing task {taskRequest.TaskNo} to DS");
                    ImportSet taskImport = await importEndpoint.ProcessAsync(taskRequest, TransactionType.Append);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private static Task CreateTaskRequest(Job jobRequest, int i)
        {
            Task taskRequest = new Faker<Task>()
                .RuleFor(x => x.SourceApp, f => jobRequest.SourceApp)
                .RuleFor(x => x.SourceType, f => jobRequest.SourceType)
                .RuleFor(x => x.JobNo, f => jobRequest.JobNo)
                .RuleFor(x => x.TaskNo, f => $"Task {i} {f.Company.CompanyName()}")
                .RuleFor(x => x.ShortDescription, f => $"Import task {i}")
                .RuleFor(x => x.Description, f => $"Import task {i}")
                .RuleFor(x => x.FreeText1, f => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                .RuleFor(x => x.FreeText2, f => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                .RuleFor(x => x.FreeText3, f => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                .RuleFor(x => x.FreeText4, f => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                .RuleFor(x => x.FreeText5, f => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                .RuleFor(x => x.FreeText6, f => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                .RuleFor(x => x.FreeText7, f => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                .RuleFor(x => x.FreeText9, f => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                .RuleFor(x => x.FreeText10, f => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                .RuleFor(x => x.FreeText11, f => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                .RuleFor(x => x.FreeText12, f => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                .RuleFor(x => x.FreeText13, f => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                .RuleFor(x => x.FreeText14, f => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                .RuleFor(x => x.FreeText15, f => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                .RuleFor(x => x.FreeText16, f => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                .RuleFor(x => x.FreeText17, f => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                .RuleFor(x => x.FreeText18, f => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                .RuleFor(x => x.FreeText19, f => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                .RuleFor(x => x.FreeText20, f => f.Rant.Review("Dime.Scheduler").ClampLength(0, 100))
                .RuleFor(x => x.FreeDate1, f => f.Date.Future())
                .RuleFor(x => x.FreeDate2, f => f.Date.Future())
                .RuleFor(x => x.FreeDate3, f => f.Date.Future())
                .RuleFor(x => x.FreeDate4, f => f.Date.Future())
                .RuleFor(x => x.FreeDate5, f => f.Date.Future())
                .RuleFor(x => x.FreeDecimal1, f => f.Random.Number())
                .RuleFor(x => x.FreeDecimal2, f => f.Random.Number())
                .RuleFor(x => x.FreeDecimal3, f => f.Random.Number())
                .RuleFor(x => x.FreeDecimal4, f => f.Random.Number())
                .RuleFor(x => x.FreeDecimal5, f => f.Random.Number())
                .RuleFor(x => x.FreeBit1, f => f.Random.Bool())
                .RuleFor(x => x.FreeBit2, f => f.Random.Bool())
                .RuleFor(x => x.FreeBit3, f => f.Random.Bool())
                .RuleFor(x => x.FreeBit4, f => f.Random.Bool())
                .RuleFor(x => x.FreeBit5, f => f.Random.Bool())
                .RuleFor(x => x.RequestedStartTime, f => new TimeSpan(0, f.Random.Number(0, 23), f.Random.Number(0, 59), 0))
                .RuleFor(x => x.RequestedEndTime, f => new TimeSpan(0, f.Random.Number(0, 23), f.Random.Number(0, 59), 0))
                .RuleFor(x => x.InfiniteTask, f => f.Random.Bool())
                .Generate();
            return taskRequest;
        }

        private static Job CreateJobRequest()
        {
            Job jobRequest = new Faker<Job>()
                .RuleFor(x => x.SourceApp, f => "IMPORT")
                .RuleFor(x => x.SourceType, f => "IMPORT")
                .RuleFor(x => x.JobNo, f => $"Job {f.Company.CompanyName().ClampLength(0, 50)}")
                .RuleFor(x => x.ShortDescription, f => $"{f.Rant.Review("Dime.Scheduler").ClampLength(0, 50)}")
                .RuleFor(x => x.CustomerName, f => f.Company.CompanyName())
                .RuleFor(x => x.CustomerEmail, f => f.Internet.Email())
                .RuleFor(x => x.CustomerNo, f => $"{f.Company.CompanyName()} {f.Company.CompanySuffix()}")
                .RuleFor(x => x.SiteStreet, f => f.Address.StreetName())
                .RuleFor(x => x.SiteStreetNo, f => "1")
                .RuleFor(x => x.SiteCity, f => f.Address.City())
                .RuleFor(x => x.SiteCountry, f => f.Address.Country())
                .RuleFor(x => x.SiteCountry, f => f.Address.CountryCode())
                .RuleFor(x => x.Responsible, f => f.Name.FullName())
                .RuleFor(x => x.Importance, f => f.Random.Number(0, 2).ToString())
                .RuleFor(x => x.FreeText1, f => f.Rant.Review("Dime.Scheduler").ClampLength(1, 100))
                .RuleFor(x => x.FreeText2, f => f.Rant.Review("Dime.Scheduler").ClampLength(1, 100))
                .RuleFor(x => x.FreeText3, f => f.Rant.Review("Dime.Scheduler").ClampLength(1, 100))
                .RuleFor(x => x.FreeText4, f => f.Rant.Review("Dime.Scheduler").ClampLength(1, 100))
                .RuleFor(x => x.FreeText5, f => f.Rant.Review("Dime.Scheduler").ClampLength(1, 100))
                .RuleFor(x => x.FreeText6, f => f.Rant.Review("Dime.Scheduler").ClampLength(1, 100))
                .RuleFor(x => x.FreeText7, f => f.Rant.Review("Dime.Scheduler").ClampLength(1, 100))
                .RuleFor(x => x.FreeText9, f => f.Rant.Review("Dime.Scheduler").ClampLength(1, 100))
                .RuleFor(x => x.FreeText10, f => f.Rant.Review("Dime.Scheduler").ClampLength(1, 100))
                .RuleFor(x => x.FreeText11, f => f.Rant.Review("Dime.Scheduler").ClampLength(1, 100))
                .RuleFor(x => x.FreeText12, f => f.Rant.Review("Dime.Scheduler").ClampLength(1, 100))
                .RuleFor(x => x.FreeText13, f => f.Rant.Review("Dime.Scheduler").ClampLength(1, 100))
                .RuleFor(x => x.FreeText14, f => f.Rant.Review("Dime.Scheduler").ClampLength(1, 100))
                .RuleFor(x => x.FreeText15, f => f.Rant.Review("Dime.Scheduler").ClampLength(1, 100))
                .RuleFor(x => x.FreeText16, f => f.Rant.Review("Dime.Scheduler").ClampLength(1, 100))
                .RuleFor(x => x.FreeText17, f => f.Rant.Review("Dime.Scheduler").ClampLength(1, 100))
                .RuleFor(x => x.FreeText18, f => f.Rant.Review("Dime.Scheduler").ClampLength(1, 100))
                .RuleFor(x => x.FreeText19, f => f.Rant.Review("Dime.Scheduler").ClampLength(1, 100))
                .RuleFor(x => x.FreeText20, f => f.Rant.Review("Dime.Scheduler").ClampLength(1, 100))
                .RuleFor(x => x.FreeDate1, f => f.Date.Future())
                .RuleFor(x => x.FreeDate2, f => f.Date.Future())
                .RuleFor(x => x.FreeDate3, f => f.Date.Future())
                .RuleFor(x => x.FreeDate4, f => f.Date.Future())
                .RuleFor(x => x.FreeDate5, f => f.Date.Future())
                .RuleFor(x => x.FreeDecimal1, f => f.Random.Number())
                .RuleFor(x => x.FreeDecimal2, f => f.Random.Number())
                .RuleFor(x => x.FreeDecimal3, f => f.Random.Number())
                .RuleFor(x => x.FreeDecimal4, f => f.Random.Number())
                .RuleFor(x => x.FreeDecimal5, f => f.Random.Number())
                .RuleFor(x => x.FreeBit1, f => f.Random.Bool())
                .RuleFor(x => x.FreeBit2, f => f.Random.Bool())
                .RuleFor(x => x.FreeBit3, f => f.Random.Bool())
                .RuleFor(x => x.FreeBit4, f => f.Random.Bool())
                .RuleFor(x => x.FreeBit5, f => f.Random.Bool())
                .Generate();
            return jobRequest;
        }
    }
}