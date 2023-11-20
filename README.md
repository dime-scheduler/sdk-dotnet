<div align="center">
<img src="https://cdn.dimescheduler.com/dime-scheduler/v2/logo.svg" height="75px" />
</div>

<p align="center">
    <img src="assets/connect.svg?raw=true" width="350px">
</p>

<p align="center">
    <img src="https://img.shields.io/azure-devops/build/dimesoftware/utilities/194?style=flat-square" /> <img src="https://img.shields.io/azure-devops/tests/dimesoftware/utilities/194?compact_message&style=flat-square" /> <img src='https://img.shields.io/nuget/vpre/dime.scheduler.sdk?style=flat-square' /> <img src="https://img.shields.io/azure-devops/coverage/dimesoftware/Utilities/194?style=flat-square" /> <img<img src="https://img.shields.io/nuget/v/Dime.Scheduler.Sdk?style=flat-square" /> <img src="https://github.com/dime-scheduler/sdk-dotnet/actions/workflows/codeql-analysis.yml/badge.svg" /> <img src='https://api.codeclimate.com/v1/badges/65852a78e1a9b7633574/maintainability' /> <img src="https://img.shields.io/badge/License-MIT-brightgreen.svg?style=flat-square"/> <img src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square" />    
    <a href="https://github.com/dime-scheduler/sdk-dotnet/discussions">
  <img src="https://img.shields.io/badge/chat-discussions-brightgreen?style=flat-square">
</a>
</p>

<p align="center">
  <a href="https://docs.dimescheduler.com">Documentation</a> |
  <a href="https://docs.dimescheduler.com/history">Changelog</a> |
  <a href="https://docs.dimescheduler.com/roadmap">Roadmap</a>
</p>

<h1 align="center">Dime.Scheduler SDK for .NET </h1>

This repository contains the .NET SDK for Dime.Scheduler's. The SDK is a gateway to connect _any_ system to Dime.Scheduler through its extensive import pipeline and large collection of web APIs.

## Installation

Use the package manager NuGet to install the SDK:

`dotnet add package Dime.Scheduler.Sdk`

> [!IMPORTANT]  
> Version 2 and onwards is only forwards compatible with Dime.Scheduler cloud.

## Prerequisites

To clone and run this application, you'll need Visual Studio 2022 or higher. It is built on the latest versions of .NET and C#.

## Usage

The `DimeSchedulerClient` class is the entry point and it is where all endpoints are exposed:

```csharp
DimeSchedulerClient client = new("key");
```

> [!TIP]  
> An optional argument is available to use the sandbox environment.

Instantiate the object of choice and run it by its corresponding endpoint in the SDK.

```csharp
Category category = new("Category #1", "#6e62b5");
await client.Categories.CreateAsync(category);
```

## Read more

Check out the **[📚 docs »](https://docs.dimescheduler.com)** for more info.

## Contributing

We welcome contributions. Please check out the contribution and code of conduct guidelines first.

To contribute:

1. Fork the project
2. Create a feature branch (`git checkout -b feature/mynewfeature`)
3. Commit your changes (`git commit -m 'Add mynewfeature'`)
4. Push to the branch (`git push origin feature/mynewfeature`)
5. Open a pull request
