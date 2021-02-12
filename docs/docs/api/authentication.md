---
id: authentication
title: Authentication
sidebar_label: Authentication
---



```csharp
using Dime.Scheduler.Sdk.Import;

string uri = "http://mydimescheduler.com";
IAuthenticator authenticator = new FormsAuthenticator(uri, "admin", "admin");

DimeSchedulerClient client = new(uri, authenticator);

FilterGroup filterGroup = new FilterGroup { Name = "Group 1" };
IImportEndpoint importEndpoint = await client.Import.Request();
await importEndpoint.RunAsync(filterGroup, TransactionType.Append);
```