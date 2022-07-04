---
id: api-overview
title: Overview
sidebar_label: Overview
default: true
---

In essence, the SDK is merely a wrapper around the web APIs that Dime.Scheduler exposes. Most of the APIs are intended for internal use, and should ideally not be invoked directly, but there's one exception: the **import** API. This API is at the core of the integration with systems such as BC. Through a single API, you can insert pretty much any kind of data into the system:

- Jobs and tasks
- Resources
- Attributes and requirements
- Appointments
- Nomenclature
- Notifications
- Action URIs,
- ... and more

There's nothing from stopping you calling the import API directly, but the SDK makes it just a little bit easier to get started. All it takes is a few lines of code - and little knowledge about the internals of the product - to get started.