---
id: endpoints
title: Endpoints
sidebar_label: Endpoints
---

In Dime.Scheduler, there is a help section that enlists all the web APIs.

![Dime.Scheduler](../../static/img/api/ds-api-menu.png)

The [Dime.Scheduler docs](https://docs.dimescheduler.com/docs/en/developer-manual/developer-webapi) show how you can invoke these directly. Of course, the SDK's goal is to obfuscate such details and provide a easy to use programmatic interface to access those endpoints.

The ultimate target is to cover the entire list in the web api docs:

![Dime.Scheduler](../../static/img/api/ds-api-list.png)

See the table below for the current status of this endeavour.

## Supported endpoints

| Endpoint     | Status |
| ------------ | ------ |
| Import       | ✅     |
| Resources    | 🚧     |
| Categories   | ✅     |
| Time Markers | ✅     |
| Pins         | ✅     |
| Messages     | ✅     |

The import endpoint is available in the first version of the SDK.
The other endpoints are expected in version 3 of the SDK.
