using System;
using CommandLine;

namespace Dime.Scheduler.Sdk.Samples
{
    public class Program
    {
        /// <summary>
        /// Choose a sample by passing an argument to this executable.
        /// Examples:
        /// - To run the resource import sample, run: Dime.Scheduler.Sdk.Samples.exe -r
        /// - To run the resource and task import samples, run: Dime.Scheduler.Sdk.Samples.exe -r -t
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Parser
                .Default
                .ParseArguments<SampleOptions>(args)
                .WithParsed(async o =>
                {
                    // If not using the command line, you can always set the options in the code
                    // Uncomment the line below to active the resource import sample
                    // o.Resource =  true;
                    if (o.Resource)
                    {
                        ResourceImportRequestSample resourceImportRequestSample = new();
                        await resourceImportRequestSample.ExecuteWithResult();

                        ResourcesRequestSample resourcesRequestSample = new();
                        await resourcesRequestSample.Execute();
                    }

                    if (o.Task)
                    {
                        TaskImportRequestSample taskImportSample = new();
                        await taskImportSample.ExecuteWithResult();
                    }

                    if (o.ExchangeAppointment)
                    {
                        ExchangeAppointmentImportRequestSample sample = new();
                        ImportSet set = await sample.ExecuteWithResult();
                    }

                    if (o.Message)
                    {
                        MessagesRequestSample messageRequestSample = new();
                        await messageRequestSample.Execute();
                    }

                    if (o.Filter)
                    {
                        FilterImportRequestSample filterSample = new();
                        await filterSample.ExecuteWithResult();
                    }

                    if (o.ResourceGpsTracking)
                    {
                        ResourceGpsTrackingImportRequestSample gpsTrackingSample = new();
                        await gpsTrackingSample.Execute();
                    }

                    if (o.Notification)
                    {
                        NotificationImportRequestSample gpsTrackingSample = new();
                        await gpsTrackingSample.Execute();
                    }

                    if (o.Project)
                    {
                        ProjectImportRequestSample projectImportRequestSample = new();
                        await projectImportRequestSample.Execute();
                    }
                });

            Console.ReadLine();
        }
    }
}