---
id: example
title: Sample code to insert a job 
sidebar_label: Example
---

Here is a simple console application that creates or updates a [_job_](https://docs.dimescheduler.com/docs/en/user-manual/user-glossary#from-job-to-appointment) through the import endpoint. A job in Dime.Scheduler is the equivalent of an order (service, sales, project, production, etc.) in the real world.

The **import endpoint** is arguably the most important element in the entire SDK. It's the entry point to push data into Dime.Scheduler. Through a single interface, you can manage pretty much all the data that is used in the planning tool.

See the inline comments for the steps required to complete a request successfully.

```cs
public class Program
{
  public static async Task Main(string[] args)
  {
    Console.WriteLine("Adding/updating a job to Dime.Scheduler");

    // Step #1 is to define the variables
    const string uri = "https://my-dimescheduler-uri";
    IAuthenticator authenticator = new FormsAuthenticator(
        uri,
        "dsserviceaccount@mycustomer.com",
        "My$trongP@$$w0rd"
    );

    // Step #2 is to instantiate and create an authenticated endpoint
    DimeSchedulerClient client = new(uri, authenticator);
    IImportEndpoint importEndpoint = await client.Import.Request();

    // Step #3 is to actually make and send the request
    Job order = new()
    {
        SourceApp = "MY APPLICATION",
        SourceType = "SERVICE_ORDER_0001",
        JobNo = "CUSTOMER_XYZ_REPAIRCODE_012",
        ShortDescription = "Repair HVAC Customer XYZ"
    };

    await importEndpoint.ProcessAsync(order, TransactionType.Append);

    Console.ReadLine();
  }
}
```

This will have inserted a job into Dime.Scheduler. The next step then would be to insert a task. You may reuse the instance of the import service:

```csharp
// Step #4: add additional data
Task jobTask = new()
{
    SourceApp = "MY APPLICATION",
    SourceType = "SERVICE_ORDER_0001",
    JobNo = "CUSTOMER_XYZ_REPAIRCODE_012",
    TaskNo = "Repair HVAC machine code 9900109 in storage room X",
    ShortDescription = "Repair HVAC Customer XYZ"
};

await importEndpoint.ProcessAsync(jobTask, TransactionType.Append);
```

More examples can be found on [Github](https://github.com/dime-scheduler/sdk-dotnet/tree/master/examples).
