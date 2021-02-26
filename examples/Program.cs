using System;
using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Samples
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            ResourceImportRequestSample resourceImportRequestSample = new();
            await resourceImportRequestSample.ExecuteWithResult();

            TaskImportRequestSample taskImportSample = new();
            await taskImportSample.ExecuteWithResult();

            ExchangeAppointmentImportRequestSample sample = new();
            ImportSet set = await sample.ExecuteWithResult();

            MessagesRequestSample messageRequestSample = new();
            await messageRequestSample.Execute();

            ResourcesRequestSample resourcesRequestSample = new();
            await resourcesRequestSample.Execute();

            Console.ReadLine();
        }
    }
}