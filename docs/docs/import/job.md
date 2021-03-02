---
id: jobs
title: Jobs
sidebar_label: Jobs
---

The jobs model is a metadata type that captures information about the work that needs to be done. It contains data about the customer, the shipping and billing address, and more. Thus it does not store information about the actual work itself, which is reserved for the task entity.

A job by itself has not much use as they're not displayed in the open tasks grid until at least one task has been assigned to the job. In almost all cases, a job import request will be succeeded by at least one task import request.

Because there is so much information stored in the jobs model, a special builder or job factory class was designed. Using a fluent interface, you can construct a job without much fuss:

```csharp

Job newServiceOrder = new JobBuilder()
    .WithJob("MYERPSYSTEM", "SERVICEORDER", "SO001", "Maintain HVAC in Berlin hotel", "Maintain HVAC", "Simon Pecker")
    .WithCustomer(new Sdk.Import.Customer
    {
        Email = "hq@customer.com",
        Name = "HQ London",
        No = "HQ_LONDON",
        Phone = "123 423 091",
        Reference = "REF"
    })
    .WithBill(new Site
    {
        Email = "hq@customer.com",
        Name = "HQ London",
        No = "HQ_LONDON",
        Phone = "123 423 091",
        Address = new Address { FullAddress = "The Shard, Office 1234, London, United Kingdom" }
    })
    .WithContact(new Contact
    {
        Address = "Kommandantenstraße 18, 10969 Berlin, Germany",
        Name = "Contact 1",
        No = "CONTACT_001",
        Email = "contact1@customer.com",
    })
    .Create()
```

The produced item is a plain old `Job` import, which can be passed onto the import endpoint:

```csharp
const string uri = "https://my-dimescheduler-uri";
IAuthenticator authenticator = new FormsAuthenticator(
    uri,
    "dsserviceaccount@mycustomer.com",
    "My$trongP@$$w0rd"
);

DimeSchedulerClient client = new(uri, authenticator);
IImportEndpoint importEndpoint = await client.Import.Request();
await importEndpoint.ProcessAsync(newServiceOrder, TransactionType.Append);
```