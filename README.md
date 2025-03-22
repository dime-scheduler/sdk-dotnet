<div align="center">
<img src="https://cdn.dimescheduler.com/dime-scheduler/v2/logo.svg" height="75px" />
</div>

<p align="center">
    <img src="assets/logo.png" width="350px">
</p>

<h1 align="center">Dime.Scheduler SDK for .NET </h1>

<p align="center">

  <img src="https://img.shields.io/nuget/v/Dime.Scheduler?style=flat-square&color=brightgreen" />
  <img src="https://img.shields.io/badge/License-MIT-brightgreen.svg?style=flat-square"/> <img src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square" />
</a>
</p>

<p align="center">
  <a href="https://docs.dimescheduler.com/develop/sdk">📚  <b>Docs</b></a>
</p>

This repository contains the .NET SDK for Dime.Scheduler. The SDK is a gateway to connect _any_ system to Dime.Scheduler through its extensive import pipeline and large collection of web APIs.

## Installation

Use the package manager NuGet to install the SDK:

`dotnet add package Dime.Scheduler`

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
var response = await client.Indicators.Categories.CreateAsync(category);
```

Check out the **[📚 docs »](https://docs.dimescheduler.com/develop/sdk)** for more info.

## Contributing

We welcome contributions. Please check out the contribution and code of conduct guidelines first.

To contribute:

1. Fork the project
2. Create a feature branch (`git checkout -b feature/mynewfeature`)
3. Commit your changes (`git commit -m 'Add mynewfeature'`)
4. Push to the branch (`git push origin feature/mynewfeature`)
5. Open a pull request

To clone and run this application, you'll need Visual Studio 2022 or higher. It is built on the latest versions of .NET and C#.