---
id: getting-started
title: Getting started
sidebar_label: Getting started
---

First things first: adding the NuGet package is the only thing you need to connect to Dime.Scheduler. That is, besides a running instance of Dime.Scheduler itself, which the client application can access, obviously.

`dotnet add package Dime.Scheduler.Sdk` 

Once that's done, you can do pretty much anything you want with it. Below is a very simple example that authenticates the user and adds a category named "Category #1" to the system.

```csharp
using Dime.Scheduler.Sdk;

string uri = "http://mydimescheduler.com";
IAuthenticator authenticator = new FormsAuthenticator(uri, "admin", "admin");

DimeSchedulerClient client = new(uri, authenticator);

Category category = new("Category #1", "#6e62b5");
IImportEndpoint importEndpoint = await client.Import.Request();
await importEndpoint.RunAsync(category, TransactionType.Append);
```