![Dime.Scheduler Logo](https://cdn.dimescheduler.com/dime-scheduler/logo.png)

# Dime.Scheduler .NET SDK

This is the official SDK for Dime.Scheduler. The SDK is a gateway to connect *any* system to Dime.Scheduler through its extensive import pipeline and large collection of web APIs.

Check out the **[📚 docs »](https://docs.dimescheduler.com)** for more info.

## Prerequisites

In order to successfully use the SDK, make sure to comply with the following requirements:

- An active Dime.Scheduler subscription
- A valid Dime.Scheduler API key

## Installation

Use the package manager NuGet to install the base library of the SDK:

`dotnet add package Dime.Scheduler.Sdk`

⚠️ Versions 2 and up are built for the cloud version of Dime.Scheduler. Use 1.x.x for on-premise versions.

## Usage

The example below fetches the resources available in Dime.Scheduler:

```csharp
DimeSchedulerClient client = new("http://mydimescheduler.com", "my-api-key");
IEnumerable<Resource> resources = await client.Resources.GetAsync(new ResourceRequest());
foreach (Resource resource in resources)
    Console.WriteLine(resource.Email);
```

The `DimeSchedulerClient` class is the entry point and it is where all endpoints are exposed:

```csharp
DimeSchedulerClient client = new(uri,  "my-api-key");
```

Two arguments are required: the URI to Dime.Scheduler and a valid API key. With these credentials, you can access any of the endpoints.

```csharp
IEnumerable<Resource> resources = await resourceEndpoint.GetAsync(new ResourceRequest());
```

## Import

The import API is the entry point for external systems to feed data into Dime.Scheduler. The import endpoints expose a set of import pipelines to map and save data in the Dime.Scheduler database. Any class that implements the `IImportRequestable` interface is eligible to be processed by the import service in Dime.Scheduler.

This example adds or updates a category:

```csharp
using Dime.Scheduler.Sdk.Import;

DimeSchedulerClient client = new(uri,  "my-api-key");
Category category = new("Category #1", "#6e62b5");
await client.Import.RunAsync(category, TransactionType.Append);
```

This example adds or updates a filter group:

```csharp
using Dime.Scheduler.Sdk.Import;

string uri = "http://mydimescheduler.com";
DimeSchedulerClient client = new(uri,  "my-api-key");

FilterGroup filterGroup = new FilterGroup { Name = "Group 1" };
await client.Import.RunAsync(filterGroup, TransactionType.Append);
```

## Read more

Check out the **[📚 docs »](https://docs.dimescheduler.com)** for more info.
