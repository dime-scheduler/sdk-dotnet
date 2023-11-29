using Spectre.Console;

bool again = true;
do
{
    // Step 1: action selection
    string action = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("What would you like to try out?")
            .PageSize(10)
            .MoreChoicesText("[grey](Move up and down to show more examples)[/]")
            .AddChoices(new[] { "Task", "Resource" }));

    // Step 2: environment selection
    string environment = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("What environment should we be running the command on?")
        .PageSize(10)
        .AddChoices(new[] { "Production", "Sandbox" }));

    Dime.Scheduler.Environment env = environment == "Production" ? Dime.Scheduler.Environment.Production : Dime.Scheduler.Environment.Sandbox;

    // Step 3: API key
    string key = AnsiConsole.Ask<string>("Please share the API key to use:");

    switch (action)
    {
        case "Task":
            AppendTask taskCmd = new(env, key);
            await taskCmd.Run();
            break;

        case "Resource":
            AppendResource resourceCmd = new(env, key);
            await resourceCmd.Run();
            break;
    }

    if (!AnsiConsole.Confirm("Want to do anything else?"))
        again = false;
}
while (again);