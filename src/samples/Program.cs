using System;
using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Samples
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            MessagesRequestSample messageRequestSample = new();
            await messageRequestSample.Execute();

            ResourcesRequestSample resourcesRequestSample = new();
            await resourcesRequestSample.Execute();

            ImportRequestSample sample = new();
            ImportSet set = await sample.ExecuteWithResult();

            Console.ReadLine();
        }
    }
}