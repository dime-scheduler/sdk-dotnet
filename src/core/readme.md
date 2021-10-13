# Dime.Scheduler SDK for .NET

This repository contains the .NET SDK for Dime.Scheduler's RESTful API services. The SDK is a gateway to connect *any* system to Dime.Scheduler through its extensive import pipeline and large collection of web APIs.

Check out the **[📚 docs »](https://dime-scheduler.github.io/sdk-dotnet)** for more info.

## Installation

Use the package manager NuGet to install the base library of the SDK:

`dotnet add package Dime.Scheduler.Sdk`

## Prerequisites

To clone and run this application, you'll need Visual Studio 16.7 or higher. The application is built with C# 9 and targets .NET Standard 2.0, .NET Standard 2.1 and .NET 5.

The SDK is currently only supported for the latest version of Dime.Scheduler.

## Usage

The example below fetches the resources available in Dime.Scheduler:

```csharp
string uri = "http://mydimescheduler.com";
IAuthenticator authenticator = new FormsAuthenticator(uri,"admin","admin");

DimeSchedulerClient client = new(uri, authenticator);

IResourceEndpoint resourceEndpoint = await client.Resources.Request();
IEnumerable<Resource> resources = await resourceEndpoint.GetAsync(new ResourceRequest());

foreach (Resource resource in resources)
    Console.WriteLine(resource.Email);
```

The `DimeSchedulerClient` class is the entry point and it is where all endpoints are exposed:

```csharp
DimeSchedulerClient client = new(uri, authenticator);
```

Two arguments are required: the URI to Dime.Scheduler and credentials to connect to it. The `IAuthenticator` (with `FormsAuthenticator` as the default implementation) interface is called when an endpoint is requested:

```csharp
IResourceEndpoint resourceEndpoint = await client.Resources.Request();
```

When the credentials are invalid, an exception is thrown. Otherwise, the user is authenticated and can access the endpoint:

```csharp
IEnumerable<Resource> resources = await resourceEndpoint.GetAsync(new ResourceRequest());
```

## Import

The import API is the entry point for external systems to feed data into Dime.Scheduler. The import endpoints expose a set of import pipelines to map and save data in the Dime.Scheduler database. Any class that implements the `IImportRequestable` interface is eligible to be processed by the import service in Dime.Scheduler.

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

## Read more

Check out the **[📚 docs »](https://dime-scheduler.github.io/sdk-dotnet)** for more info.
