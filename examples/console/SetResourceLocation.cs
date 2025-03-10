using Dime.Scheduler;
using Spectre.Console;

public class SetResourceLocation
{
    public SetResourceLocation(Dime.Scheduler.Environment environment, string key)
    {
        Environment = environment;
        Key = key;
    }

    private Dime.Scheduler.Environment Environment { get; }
    private string Key { get; }

    public async Task Run()
    {
        DimeSchedulerClient client = new(Key, Environment);

        string resourceNo = AnsiConsole.Ask<string>("Resource no:");
        string latLng = AnsiConsole.Ask<string>("Lat/lng (paste from Google Maps):");

        _ = decimal.TryParse(latLng.Split(',')[0].Trim(), out decimal lat);
        _ = decimal.TryParse(latLng.Split(',')[1].Trim(), out decimal lng);

        Dime.Scheduler.Entities.ResourceGpsTracking resourceLocation = new()
        {
            ResourceNo = resourceNo,
            Latitude = lat,
            Longitude = lng
        };

        await AnsiConsole.Status().Start("Saving...", async ctx =>
        {
            await client.Resources.CreateAsync(resourceLocation);
            Thread.Sleep(2000);
        });
    }
}