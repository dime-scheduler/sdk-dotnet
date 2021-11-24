---
id: endpoints
title: Endpoints
sidebar_label: Endpoints
---

For an up to date list of the types and their properties, check out the [source code](https://github.com/dime-scheduler/sdk-dotnet/tree/master/src/core/Import).
All import types live in the ` Dime.Scheduler.Sdk.Import` namespace.

| Endpoint                      | Create/Update | Delete | Type name                   |
| ----------------------------- | ------------- | ------ | --------------------------- |
| Task                          | ✅            | ✅     | Task                        |
| Task container                | ✅            | ✅     | TaskContainer               |
| Task filter value             | ✅            | ✅     | TaskFilterValue             |
| Task locked                   | ✅            | ❌     | TaskLocked                  |
| Appointment                   | ✅            | ✅     | Appointment                 |
| Appointment category          | ✅            | ❌     | AppointmentCategory         |
| Appointment time marker       | ✅            | ❌     | AppointmentTimeMarker       |
| Appointment importance        | ✅            | ❌     | AppointmentImportance       |
| Appointment locked            | ✅            | ❌     | AppointmentLocked           |
| Appointment planning quantity | ✅            | ❌     | AppointmentPlanningQuantity |
| Appointment URL               | ✅            | ❌     | AppointmentUri              |
| Appointment Container         | ✅            | ✅     | AppointmentContainer        |
| Exchange Appointment          | ✅            | ✅     | ExchangeAppointment         |
| Assignment                    | ✅            | ❌     | Assignment                  |
| Action URI                    | ✅            | ❌     | ActionUri                   |
| Caption                       | ✅            | ❌     | Caption                     |
| Category                      | ✅            | ✅     | Category                    |
| Time marker                   | ✅            | ✅     | TimeMarker                  |
| Pin                           | ✅            | ✅     | Pin                         |
| Filter Group                  | ✅            | ✅     | FilterGroup                 |
| Filter Value                  | ✅            | ✅     | FilterValue                 |
| Job                           | ✅            | ✅     | Job                         |
| Notification                  | ✅            | ✅     | Notification                |
| Resource                      | ✅            | ❌     | Resource                    |
| Resource Calendar             | ✅            | ✅     | ResourceCalendar            |
| Resource Capacity             | ✅            | ❌     | ResourceCapacity            |
| Resource Certificate          | ✅            | ✅     | ResourceCertificate         |
| Resource Filter Value         | ✅            | ✅     | ResourceFilterValue         |
| Resource GPS Tracking         | ✅            | ❌     | ResourceGpsTracking         |
| Resource URL                  | ✅            | ❌     | ResourceUri                 |
| Container                     | ✅            | ✅     | Container                   |

Let's say you would like to insert a new resource into the system. As you know by now, this is easy. Simply create an instance of the `Resource` class and pass it on the import endpoint:

```csharp
using Dime.Scheduler.Sdk.Import;

string uri = "http://mydimescheduler.com";
IAuthenticator authenticator = new FormsAuthenticator(uri, "admin", "admin");

DimeSchedulerClient client = new(uri, authenticator);

Resource resource = new Resource { ... };
IImportEndpoint importEndpoint = await client.Import.Request();
await importEndpoint.ProcessAsync(resource, TransactionType.Append);
```
