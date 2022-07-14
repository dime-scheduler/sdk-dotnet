---
id: endpoints
title: Endpoints
sidebar_label: Endpoints
---

For an up to date list of the types and their properties, check out the [source code](https://github.com/dime-scheduler/sdk-dotnet/tree/master/src/core/Import).
All import types live in the ` Dime.Scheduler.Sdk.Import` namespace.

## Models

### Work items

Every task needs to have a job. A job is the equivalent to an order or job in Business Central, while a task would represent service item lines, job tasks. A task is at the lowest level and is the plannable unit of work. The job holds information such as customer information and coordinates, while the task is about the work that needs to be carried out.

| Endpoint          | Create/Update | Delete | Type                                                                                                           |
| ----------------- | ------------- | ------ | -------------------------------------------------------------------------------------------------------------- |
| Job               | ✅            | ✅     | [Job](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/Job.cs)                         |
| Task              | ✅            | ✅     | [Task](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/Task.cs)                       |
| Task container    | ✅            | ✅     | [TaskContainer](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/TaskContainer.cs)     |
| Task filter value | ✅            | ✅     | [TaskFilterValue](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/TaskFilterValue.cs) |
| Task locked       | ✅            | ❌     | [TaskLocked](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/TaskLocked.cs)           |

The **job** model is a metadata type that captures information about the work that needs to be done. It contains data about the customer, the shipping and billing address, and more. Thus it does not store information about the actual work itself, which is reserved for the task entity.

A job by itself has not much use as they're not displayed in the open tasks grid until at least one task has been assigned to the job. In almost all cases, a job import request will be succeeded by at least one task import request.

Because there is so much information stored in the jobs model, a special builder or job factory class was designed. Using a fluent interface, you can construct a job without much fuss:

```csharp

Job newServiceOrder = new JobBuilder()
    .WithJob("BC_CRONUS", "SERVICE", "SO001", "Update HVAC in Berlin office", "Maintain HVAC", "Simon Pecker")
    .WithCustomer(new Sdk.Import.Customer
    {
        Email = "hq@customer.com",
        Name = "HQ London",
        No = "HQ_LONDON",
        Phone = "123 423 091",
        Reference = "REF"
    })
    .WithBill(new Site
    {
        Email = "hq@customer.com",
        Name = "HQ London",
        No = "HQ_LONDON",
        Phone = "123 423 091",
        Address = new Address { FullAddress = "The Shard, Office 1234, London, United Kingdom" }
    })
    .WithContact(new Contact
    {
        Address = "Kommandantenstraße 18, 10969 Berlin, Germany",
        Name = "Contact 1",
        No = "CONTACT_001",
        Email = "contact1@customer.com",
    })
    .Create();
```

The produced item is a plain old `Job` import, which can be passed onto the import endpoint.

### Appointment

An appointment is merely an assignment of a task to a resource on a given date and time. An appointment is the base entity, and an assignment entity represents the allocation of a resource to an appointment.

| Endpoint                      | Append | Delete | Type                                                                                                                                   |
| ----------------------------- | ------ | ------ | -------------------------------------------------------------------------------------------------------------------------------------- |
| Appointment                   | ✅     | ✅     | [Appointment](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/Appointment.cs)                                 |
| Appointment category          | ✅     | ❌     | [AppointmentCategory](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/AppointmentCategory.cs)                 |
| Appointment time marker       | ✅     | ❌     | [AppointmentTimeMarker](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/AppointmentTimeMarker.cs)             |
| Appointment importance        | ✅     | ❌     | [AppointmentImportance](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/AppointmentImportance.cs)             |
| Appointment locked            | ✅     | ❌     | [AppointmentLocked](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/AppointmentLocked.cs)                     |
| Appointment planning quantity | ✅     | ❌     | [AppointmentPlanningQuantity](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/AppointmentPlanningQuantity.cs) |
| Appointment URL               | ✅     | ❌     | [AppointmentUri](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/AppointmentUri.cs)                           |
| Appointment Container         | ✅     | ✅     | [AppointmentContainer](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/AppointmentContainer.cs)               |
| Assignment                    | ✅     | ❌     | [Assignment](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/Assignment.cs)                                   |

### Resources

| Endpoint              | Append | Delete | Type                                                                                                                   |
| --------------------- | ------ | ------ | ---------------------------------------------------------------------------------------------------------------------- |
| Resource              | ✅     | ❌     | [Resource](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/Resource.cs)                       |
| Resource Calendar     | ✅     | ✅     | [ResourceCalendar](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/ResourceCalendar.cs)       |
| Resource Capacity     | ✅     | ❌     | [ResourceCapacity](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/ResourceCapacity.cs)       |
| Resource Filter Value | ✅     | ✅     | [ResourceFilterValue](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/ResourceFilterValue.cs) |
| Resource GPS Tracking | ✅     | ❌     | [ResourceGpsTracking](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/ResourceGpsTracking.cs) |
| Resource URL          | ✅     | ❌     | [ResourceUri](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/ResourceUri.cs)                 |

### Attributes & Requirements

| Endpoint     | Append | Delete | Type                                                                                                   |
| ------------ | ------ | ------ | ------------------------------------------------------------------------------------------------------ |
| Filter Group | ✅     | ✅     | [FilterGroup](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/FilterGroup.cs) |
| Filter Value | ✅     | ✅     | [FilterValue](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/FilterValue.cs) |

### Indicators

An indicator is essentially a color representing a certain status. Categories display the background colors of appointments, while time markers render a underscore and pins display the colors of the markers on the map.

| Endpoint    | Append | Delete | Type                                                                                                 |
| ----------- | ------ | ------ | ---------------------------------------------------------------------------------------------------- |
| Category    | ✅     | ✅     | [Category](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/Category.cs)     |
| Time marker | ✅     | ✅     | [TimeMarker](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/TimeMarker.cs) |
| Pin         | ✅     | ✅     | [Pin](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/Pin.cs)               |

### Other endpoints

| Endpoint     | Append | Delete | Type                                                                                                     |
| ------------ | ------ | ------ | -------------------------------------------------------------------------------------------------------- |
| Action URI   | ✅     | ❌     | [ActionUri](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/ActionUri.cs)       |
| Caption      | ✅     | ❌     | [Caption](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/Caption.cs)           |
| Notification | ✅     | ✅     | [Notification](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/Notification.cs) |
| Container    | ✅     | ✅     | [Container](https://github.com/dime-scheduler/sdk-dotnet/blob/master/src/core/Import/Container.cs)       |

## Using the import models

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
