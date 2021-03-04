using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Dime.Scheduler.Sdk.Import;
using Dime.Scheduler.Sdk.Samples.Data;

namespace Dime.Scheduler.Sdk.Samples
{
    public class ResourceGpsTrackingImportRequestSample
    {
        public async System.Threading.Tasks.Task Execute()
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

                // Ensure the resource exists
                Import.Resource resourceRequest = ResourceFactory.Create();
                resourceRequest.ResourceGpsTrackingEnabled = true;

                Random random = new();
                string color = $"#{random.Next(0x1000000):X6}";

                Pin pin = new() { Name = "Pin for " + resourceRequest.ResourceNo, Color = color };
                await importEndpoint.ProcessAsync(pin, TransactionType.Append);

                resourceRequest.Pin = pin.Name;

                ImportSet resourceImport = await importEndpoint.ProcessAsync(resourceRequest, TransactionType.Append);

                List<(decimal, decimal)> coordinates = new()
                {
                    (40.779555M, -73.973577M), // Central Park West & W 77th
                    (40.785286M, -73.969350M), // Central Park West & W 86th
                    (40.794248M, -73.962958M), // Central Park West & W 100th
                    (40.800398M, -73.958047M), // Central Park West & Central Park North
                    (40.799518M, -73.955355M), // Central Park North & Adam Clayton Powell Jr Blvd
                    (40.798223M, -73.952388M), // Central Park North & Malcolm X Blvd
                    (40.796643M, -73.949432M), // Central Park North & 5th Ave
                    (40.794328M, -73.951068M), // 5th Ave & E 106th St
                    (40.794328M, -73.951068M), // 5th Ave & E 101th St
                    (40.786605M, -73.956753M), // 5th Ave & E 94th St
                    (40.780868M, -73.960957M), // 5th Ave & E 85th St
                    (40.773795M, -73.966148M), // 5th Ave & E 74th St
                    (40.769919M, -73.968967M), // 5th Ave & E 68th St
                    (40.765517M, -73.972142M), // 5th Ave & E 61th St
                    (40.764316M, -73.973075M), // 5th Ave & E 50th St
                };

                for (int i = 0; i < coordinates.Count; i++)
                {
                    Console.WriteLine("Updating GPS location " + (i + 1));

                    (decimal lat, decimal lng) = coordinates.ElementAt(i);
                    ResourceGpsTracking resourceGpsTrackingRequest = new()
                    {
                        ResourceNo = resourceRequest.ResourceNo,
                        Latitude = lat,
                        Longitude = lng
                    };

                    ImportSet resourceCoordinatesImport = await importEndpoint.ProcessAsync(resourceGpsTrackingRequest, TransactionType.Append);
                    Thread.Sleep(5000); // Sleep 2 seconds
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