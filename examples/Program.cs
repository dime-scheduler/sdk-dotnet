using System;
using CommandLine;
using Dime.Scheduler.Sdk.Samples.Samples.Import;

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

                    if (o.Appointment)
                    {
                        AppointmentImportRequestSample appointmentImportRequestSample = new();
                        await appointmentImportRequestSample.Execute();
                    }
                });

            Console.ReadLine();
        }
    }
}