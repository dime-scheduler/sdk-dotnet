![Dime.Scheduler Logo](https://cdn.dimescheduler.com/dime-scheduler/v2/logo.png)

# Dime.Scheduler .NET SDK

This is the official SDK for Dime.Scheduler. The SDK is a gateway to connect *any* system to Dime.Scheduler through its extensive import pipeline and large collection of web APIs.

Check out the **[📚 docs »](https://docs.dimescheduler.com)** for more info.

## Prerequisites

In order to successfully use the SDK, make sure to comply with the following requirements:

- An active Dime.Scheduler subscription
- A valid Dime.Scheduler API key

## Installation

Use the package manager NuGet to install the base library of the SDK:

`dotnet add package Dime.Scheduler`

⚠️ Versions 2 and up are built for the cloud version of Dime.Scheduler. Use 1.x.x for on-premise versions.

## Usage

The example below fetches the resources available in Dime.Scheduler:

```csharp
DimeSchedulerClient client = new("key");
IEnumerable<Resource> resources = await client.Resources.GetAsync(new ResourceRequest());
foreach (Resource resource in resources)
    Console.WriteLine(resource.Email);
```

The `DimeSchedulerClient` class is the entry point and it is where all endpoints are exposed:

```csharp
DimeSchedulerClient client = new("my-api-key");
```

Just a valid API key is required. With these credentials, you can access any of the endpoints, whether it be fetching data or importing data into Dime.Scheduler.

```csharp
IEnumerable<Resource> resources = await resourceEndpoint.GetAsync(new ResourceRequest());
```

This example adds or updates a category:

```csharp
Category category = new("Category #1", "#6e62b5");

DimeSchedulerClient client = new("my-api-key");
var response = await client.Indicators.Categories.CreateAsync(category);
```

## Read more

Check out the **[📚 docs »](https://docs.dimescheduler.com)** for more info.
