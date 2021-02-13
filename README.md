<p align="center">
    <img src="assets/connect.svg?raw=true" width="350" alt="Logo provided by Flaticon">
</p>

<p align="center">
    <img src="https://dev.azure.com/dimenicsbe/Utilities/_apis/build/status/dimenics.ds-sdk?branchName=master" /> <img src="https://vsrm.dev.azure.com/dimenicsbe/_apis/public/Release/badge/3faeaf76-379c-4e0d-9078-1d71ee186ba5/2/2" /> <img src="https://img.shields.io/badge/License-MIT-blue.svg"/> <img src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square" />
</p>

<h1 align="center">Dime.Scheduler .NET SDK</h1>

This repository contains the .NET SDK for Dime.Scheduler's RESTful API services. Learn all about the project in the [docs 📚](https://dimenics.github.io/ds-sdk/). 

## Installation

[![Join the chat at https://gitter.im/ds-sdk/community](https://badges.gitter.im/ds-sdk/community.svg)](https://gitter.im/ds-sdk/community?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

> 🚧 Warning: the packages listed here are not publicly available yet on NuGet.

Use the package manager NuGet to install the base library of the SDK:

`dotnet add package Dime.Scheduler.Sdk`

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

The import API is the entry point for external systems to feed data into Dime.Scheduler. The list of supported endpoints below expose a set of import pipelines to map and save data in the Dime.Scheduler database.

### Usage

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

### Validation

Validation is done through the capabilities exposed in the `System.ComponentModel.DataAnnotations` namespace. Wrapped in the interface ` IValidatableImportRequest<out T>`, import objects are validated before the request is sent to Dime.Scheduler.

Take the `FilterGroup` class as an example:

```csharp
public class FilterGroup : IImportRequestable, IValidatableImportRequest<FilterGroup>
{
    [Required]
    public string Name { get; set; }
}
```

When invoking the following request, an exception will be thrown:

```csharp
FilterGroup model = new FilterGroup { ColumnNo = 1 };
((IImportRequestable) model).ToImportRequest(TransactionType.Append); // Will throw exception
```

### Supported endpoints

| Endpoint                      | Create/Update | Delete |
| ----------------------------- | ------------- | ------ |
| Task                          | ✅            | ✅     |
| Task container                | ✅            | ✅     |
| Task filter value             | ✅            | ✅     |
| Task locked                   | ✅            | ❌     |
| Appointment                   | ✅            | ✅     |
| Appointment category          | ✅            | ❌     |
| Appointment time marker       | ✅            | ❌     |
| Appointment importance        | ✅            | ❌     |
| Appointment locked            | ✅            | ❌     |
| Appointment planning quantity | ✅            | ❌     |
| Appointment URL               | ✅            | ❌     |
| Exchange Appointment          | ✅            | ✅     |
| Assignment                    | ✅            | ❌     |
| Action URL                    | ✅            | ❌     |
| Caption                       | ✅            | ❌     |
| Category                      | ✅            | ✅     |
| Time marker                   | ✅            | ✅     |
| Pin                           | ✅            | ✅     |
| Filter Group                  | ✅            | ✅     |
| Filter Value                  | ✅            | ✅     |
| Job                           | ✅            | ✅     |
| Notification                  | ✅            | ✅     |
| Resource                      | ✅            | ❌     |
| Resource Calendar             | ✅            | ✅     |
| Resource Capacity             | ✅            | ❌     |
| Resource Certificate          | ✅            | ✅     |
| Resource Filter Value         | ✅            | ✅     |
| Resource GPS Tracking         | ✅            | ❌     |
| Resource URL                  | ✅            | ❌     |
