using System;
using System.Linq.Expressions;
using Bogus;
using Bogus.Extensions;
using Dime.Scheduler.Sdk.Import;
using Dime.Scheduler.Sdk.Samples.Data;

namespace Dime.Scheduler.Sdk.Samples.Samples.Import
{
    public class AppointmentImportRequestSample
    {
        public async System.Threading.Tasks.Task Execute()
        {
            try
            {
                Console.WriteLine("Running appointment import sample");

                IAuthenticator authenticator = new FormsAuthenticator
                (DimeSchedulerCredentials.Uri,
                    DimeSchedulerCredentials.User,
                    DimeSchedulerCredentials.Password);

                DimeSchedulerClient client = new(DimeSchedulerCredentials.Uri, authenticator);
                IImportEndpoint importEndpoint = await client.Import.Request();

                Appointment appointmentRequest = new Faker<Appointment>()
                    .RuleFor(x => x.SourceApp, f => "CRONUSBE")
                    .RuleFor(x => x.SourceType, f => "JOB")
                    .RuleFor(x => x.JobNo, f => "J00001")
                    .RuleFor(x => x.TaskNo, f => "00001")
                    .RuleFor(x => x.ResourceNo, f => "BULENS")
                    .RuleFor(x => x.Start, f => DateTime.Now)
                    .RuleFor(x => x.End, f => DateTime.Now.AddHours(4))
                    .RuleFor(x => x.Subject, f => f.Lorem.Paragraph().ClampLength(1, 100))
                    .RuleFor(x => x.Body, f => f.Lorem.Paragraph().ClampLength(1, 100))
                    .Generate();

                ImportSet appointmentImport = await importEndpoint.ProcessAsync(appointmentRequest, TransactionType.Append);

                Console.WriteLine("All done!");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}