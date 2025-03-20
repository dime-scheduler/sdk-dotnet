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

        string sourceApp = "SOME_ERP_SYSTEM";
        string sourceType = "SOME_ORDER_TYPE";

        // Required fields in a task include Source App, Source Type, Job No, Task No, Short Description
        // By setting the CreateJob property to true, Dime.Scheduler will automatically create a job for this task
        Dime.Scheduler.Entities.Task task = new()
        {
            SourceApp = sourceApp,
            SourceType = sourceType,
            JobNo = name,
            TaskNo = name,
            Description = descr,
            ShortDescription = descr.Length < 50 ? descr : descr.Substring(0, 50),
            CreateJob = true
        };

        Dime.Scheduler.Entities.TaskUri taskUrl = new()
        {
            SourceApp = sourceApp,
            SourceType = sourceType,
            JobNo = name,
            TaskNo = name,
            Description = descr,
            Uri = "https://www.dimescheduler.com"
        };

        await AnsiConsole.Status().Start("Saving...", async ctx =>
        {
            Result taskResult = await client.Tasks.CreateAsync(task);

            if (taskResult.IsSuccess)
            {
                AnsiConsole.WriteLine("Task appended. Adding URL to entity now.");
                Result taskUrlResult = await client.Tasks.CreateAsync(taskUrl);

                AnsiConsole.WriteLine(taskUrlResult.IsSuccess ? "Task URL linked to task." : $"Something went wrong when appending the task URL: {taskUrlResult.Error}");
            }
            else
                AnsiConsole.WriteLine($"Something went wrong when appending the task: {taskResult.Error}");

            Thread.Sleep(2000);
        });
    }
}