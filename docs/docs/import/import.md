---
id: import
title: Import
sidebar_label: Import
---


Any class that implements the `IImportRequestable` interface is eligible to be processed by the import service in Dime.Scheduler.

This example adds or updates a category:

```csharp
using Dime.Scheduler.Sdk.Import;

string uri = "http://mydimescheduler.com";
IAuthenticator authenticator = new FormsAuthenticator(uri, "admin", "admin");

DimeSchedulerClient client = new(uri, authenticator);

Category category = new("Category #1", "#6e62b5");
IImportEndpoint importEndpoint = await client.Import.Request();
await importEndpoint.RunAsync(category, TransactionType.Append);
```

This example adds or updates a filter group:

```csharp
using Dime.Scheduler.Sdk.Import;

string uri = "http://mydimescheduler.com";
IAuthenticator authenticator = new FormsAuthenticator(uri, "admin", "admin");

DimeSchedulerClient client = new(uri, authenticator);

FilterGroup filterGroup = new FilterGroup { Name = "Group 1" };
IImportEndpoint importEndpoint = await client.Import.Request();
await importEndpoint.RunAsync(filterGroup, TransactionType.Append);
```