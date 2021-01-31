<p align="center"><img src="assets/connect.png?raw=true" width="350" alt="Logo provided by Flaticon"></p>

# Dime.Scheduler .NET SDK

[![Build Status](https://dev.azure.com/dimenicsbe/Utilities/_apis/build/status/dimenics.ds-sdk?branchName=master)](https://dev.azure.com/dimenicsbe/Utilities/_build/latest?definitionId=175&branchName=master)

This repository contains the .NET SDK for Dime.Scheduler's RESTful API services.

## Installation

> 🚧 Warning: the packages listed here are not publicly available yet on NuGet.

Use the package manager NuGet to install the base library of the SDK:

`dotnet add package Dime.Scheduler.Sdk`

## Usage

This example adds or updates categories in Dime.Scheduler through the import pipeline.

```csharp
string uri = "http://mydimescheduler.com";
IAuthenticator authenticator = new FormsAuthenticator(uri, "admin", "admin");

DimeSchedulerClient client = new(uri, authenticator);

Category newCategory = new("Category #1", "#6e62b5");
IImportEndpoint importEndpoint = await client.Import.Request();
await importEndpoint.RunAsync(newCategory, TransactionType.Append);
```

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

## Supported import endpoints

| Endpoint                      | Create/Update | Delete |
| ----------------------------- | ------------- | ------ |
| Task                          | ❌            | ❌     |
| Task container                | ✅            | ✅     |
| Task filter value             | ✅            | ✅     |
| Task locked                   | ✅            | N/A    |
| Appointment                   | ❌            | ❌     |
| Appointment category          | ✅            | N/A    |
| Appointment time marker       | ✅            | N/A    |
| Appointment importance        | ✅            | N/A    |
| Appointment locked            | ✅            | N/A    |
| Appointment planning quantity | ✅            | N/A    |
| Appointment URL               | ✅            | N/A    |
| Exchange Appointment          | ✅            | ✅     |
| Action URL                    | ✅            | N/A    |
| Caption                       | ✅            | N/A    |
| Category                      | ✅            | ✅     |
| Time marker                   | ✅            | ✅     |
| Pin                           | ✅            | ✅     |
| Filter Group                  | ✅            | ✅     |
| Filter Value                  | ✅            | ✅     |
| Job                           | ✅            | ❌     |
| Notification                  | ✅            | ✅     |
| Resource                      | ❌            | N/A    |
| Resource Calendar             | ✅            | ✅     |
| Resource Capacity             | ✅            | N/A    |
| Resource Certificate          | ✅            | ✅     |
| Resource Filter Value         | ✅            | ✅     |
| Resource GPS Tracking         | ✅            | N/A    |
| Resource URL                  | ✅            | N/A    |

## Contributing

![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square)

Pull requests are welcome. Please check out the contribution and code of conduct guidelines.

## License

![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)
