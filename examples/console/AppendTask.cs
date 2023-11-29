using Dime.Scheduler;
using Spectre.Console;

public class AppendTask
{
    public AppendTask(Dime.Scheduler.Environment environment, string key)
    {
        Environment = environment;
        Key = key;
    }

    private Dime.Scheduler.Environment Environment { get; }
    private string Key { get; }

    public async Task Run()
    {
        DimeSchedulerClient client = new(Key, Environment);

        string name = AnsiConsole.Ask<string>("Name of this task:");
        string descr = AnsiConsole.Ask<string>("Short description:");

        // Required fields in a task include Source App, Source Type, Job No, Task No, Short Description
        // By setting the CreateJob property to true, Dime.Scheduler will automatically create a job for this task
        Dime.Scheduler.Entities.Task task = new()
        {
            SourceApp = "EXAMPLE",
            SourceType = "EXAMPLE",
            JobNo = name,
            TaskNo = name,
            Description = descr,
            ShortDescription = descr.Length < 50 ? descr : descr.Substring(0, 50),
            CreateJob = true
        };

        await AnsiConsole.Status().Start("Saving...", async ctx =>
        {
            await client.Tasks.CreateAsync(task);
            Thread.Sleep(2000);
        });
    }
}