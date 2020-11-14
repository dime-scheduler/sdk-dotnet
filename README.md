<p align="center"><img src="assets/connect.png?raw=true" width="350" alt="Logo provided by Flaticon"></p>

# Dime.Scheduler .NET REST SDK 

[![Build Status](https://dev.azure.com/dimenicsbe/Utilities/_apis/build/status/dimenics.ds-sdk?branchName=master)](https://dev.azure.com/dimenicsbe/Utilities/_build/latest?definitionId=175&branchName=master)

This repository contains the .NET SDK for Dime.Scheduler's RESTful API services.

## Installation

> 🚧 Warning: the packages listed here are not publicly available yet on NuGet.

Use the package manager NuGet to install the base library of the SDK:

`dotnet add package Dime.Scheduler.Sdk`

## Usage


```csharp
DimeSchedulerClient client = new DimeSchedulerClient("http://mydimescheduler.com");
await client.Authenticate("administrator@mycompany.com", "myadministratorpassword");

 ImportRequest importRequest = new ImportRequest(
    "mboc_upsertCategory",
    new List<string> { "Name", "Color" }.ToArray(),
    new List<string> { "Category #1","#6e62b5" }.ToArray()
);

ImportEndpointService importEndpoint = client.CreateEndpointService<ImportEndpointService>(); 
await importEndpoint.Create(importRequest);
```


## Contributing

![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square)

Pull requests are welcome. Please check out the contribution and code of conduct guidelines.

## License

![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)