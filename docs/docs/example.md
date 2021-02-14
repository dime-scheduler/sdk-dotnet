---
id: example
title: Example
sidebar_label: Example
---

Here is a simple console application that creates or updates a _job_ through the import endpoint. A job in Dime.Scheduler is the equivalent of an order (service, sales, project, production, etc.) in the real world.

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
