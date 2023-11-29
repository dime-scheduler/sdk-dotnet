using Dime.Scheduler;
using Spectre.Console;

public class AppendResource
{
    public AppendResource(Dime.Scheduler.Environment environment, string key)
    {
        Environment = environment;
        Key = key;
    }

    private Dime.Scheduler.Environment Environment { get; }
    private string Key { get; }

    public async Task Run()
    {
        DimeSchedulerClient client = new(Key, Environment);

        string name = AnsiConsole.Ask<string>("What is the name of the resource?");
        string resourceNo = AnsiConsole.Ask<string>("What is their employee code?");

        Dime.Scheduler.Entities.Resource resource = new()
        {
            SourceApp = "EXAMPLE",
            SourceType = "EXAMPLE",
            DisplayName = name,
            ResourceNo = resourceNo
        };

        await AnsiConsole.Status().Start("Saving...", async ctx =>
        {
            await client.Resources.CreateAsync(resource);
            Thread.Sleep(2000);
        });
    }
}