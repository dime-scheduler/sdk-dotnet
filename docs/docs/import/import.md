---
id: import
title: Import
sidebar_label: Import
---

Any class that implements the `IImportRequestable` interface is eligible to be processed by the import service in Dime.Scheduler. All import requests are done through `DimeSchedulerClient`'s Import property, which is an implementation of the `IImportEndpoint` interface. 

Import types are simple POCOs, decorated by internal mapping and validation information. Behind the covers, these POCOs are translated to a type which the import API in Dime.Scheduler can interpret and execute. The import API in Dime.Scheduler itself too is a simple and extensible framework which can be customized to your customer's needs.

This example adds or updates a category through the import pipeline:

```csharp
using Dime.Scheduler.Sdk.Import;

string uri = "http://mydimescheduler.com";
IAuthenticator authenticator = new FormsAuthenticator(uri, "admin", "admin");

DimeSchedulerClient client = new(uri, authenticator);

Category category = new("Category #1", "#6e62b5");
IImportEndpoint importEndpoint = await client.Import.Request();
await importEndpoint.ProcessAsync(category, TransactionType.Append);
```

This example adds or updates a filter group:

```csharp
using Dime.Scheduler.Sdk.Import;

string uri = "http://mydimescheduler.com";
IAuthenticator authenticator = new FormsAuthenticator(uri, "admin", "admin");

DimeSchedulerClient client = new(uri, authenticator);

FilterGroup filterGroup = new FilterGroup { Name = "Group 1" };
IImportEndpoint importEndpoint = await client.Import.Request();
await importEndpoint.ProcessAsync(filterGroup, TransactionType.Append);
```

As you can see, the experience is exactly the same. The only thing you need to worry about is the (correctness of) data.