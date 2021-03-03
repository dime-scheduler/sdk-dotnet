---
id: installation
title: Installation
sidebar_label: Installation
---

Dime.Scheduler was built on the .NET web stack. Most of the capabilities of the system are exposed through RESTful services, and as such, any technology that is able to send and receive web requests can interact with Dime.Scheduler

This project is the first step towards a suite of SDKs using various technologies and languages such as NodeJS, Dart and Java. For .NET developers, installing the SDK as simple as installing a NuGet package

`dotnet add package Dime.Scheduler.Sdk`

Besides that, you'll need three key pieces of information:
- The URI of your Dime.Scheduler instance
- The e-mail address (which serves as the user name) of a Forms user with administrative access
- The password of that account

These are reflected in the way you instantiate the relevant classes:

```cs
using Dime.Scheduler.Sdk

...

string uri = "http://mydimescheduler.com";
IAuthenticator authenticator = new FormsAuthenticator(uri, "admin", "admin");

DimeSchedulerClient client = new(uri, authenticator);
```