![Dime.Scheduler logo](https://raw.githubusercontent.com/dime-scheduler/sdk-dotnet/master/assets/ds.png) 

This is the official SDK for Dime.Scheduler. The SDK is a gateway to connect *any* system to Dime.Scheduler through its extensive import pipeline and large collection of web APIs.

Check out the **[📚 docs »](https://docs.dimescheduler.com)** for more info.

## Prerequisites

In order to successfully use the SDK, make sure to comply with the following requirements:

- An active Dime.Scheduler subscription
- A valid Dime.Scheduler API key

## Installation

Use the package manager NuGet to install the base library of the SDK:

`dotnet add package Dime.Scheduler`

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
DimeSchedulerClient client = new("my-api-key");

Category category = new("Category #1", "#6e62b5");
var response = await client.Indicators.Categories.CreateAsync(category);
```

## Read more

Check out the **[📚 docs »](https://docs.dimescheduler.com)** for more info.
