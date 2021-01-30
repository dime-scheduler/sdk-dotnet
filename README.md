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

CategoryImportRequest importRequest = new("Category #1", "#6e62b5");
IImportEndpoint importEndpoint = await client.Import.Request();
await importEndpoint.RunAsync(importRequest);
```

The example below fetches the resources available in Dime.Scheduler:

```csharp
string uri = "http://mydimescheduler.com";
IAuthenticator authenticator = new FormsAuthenticator(uri,"admin","admin");

DimeSchedulerClient client = new(uri, authenticator);

IResourceEndpoint svc = await client.Resources.Request();
IEnumerable<Resource> resources = await svc.GetAsync(new ResourceRequest());

foreach (Resource resource in resources)
    Console.WriteLine(resource.Email);
```

## Supported import endpoints

| Endpoint                      | Create/Update | Delete |
| ----------------------------- | ------------- | ------ |
| Task                          | ❌            | ❌     |
| Task container                | ❌            | ❌     |
| Task filter value             | ❌            | ❌     |
| Task locked                   | ❌            | ❌     |
| Appointment                   | ❌            | ❌     |
| Appointment category          | ❌            | ❌     |
| Appointment importance        | ❌            | ❌     |
| Appointment locked            | ❌            | ❌     |
| Appointment planning quantity | ❌            | ❌     |
| Appointment URL               | ❌            | ❌     |
| Exchange Appointment          | ✅            | ✅     |
| Action URL                    | ✅            | ❌     |
| Caption                       | ❌            | ❌     |
| Category                      | ✅            | ❌     |
| Time marker                   | ✅            | ❌     |
| Pin                           | ✅            | ❌     |
| Filter Group                  | ✅            | ❌     |
| Filter Value                  | ✅            | ❌     |
| Job                           | ❌            | ❌     |
| Notification                  | ❌            | ❌     |
| Resource                      | ❌            | ❌     |
| Resource Calendar             | ❌            | ❌     |
| Resource Capacity             | ❌            | ❌     |
| Resource Certificate          | ❌            | ❌     |
| Resource Filter Value         | ❌            | ❌     |
| Resource GPS Tracking         | ❌            | ❌     |
| Resource URL                  | ❌            | ❌     |

## Contributing

![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square)

Pull requests are welcome. Please check out the contribution and code of conduct guidelines.

## License

![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)
