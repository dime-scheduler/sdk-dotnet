![Dime.Scheduler logo](https://raw.githubusercontent.com/dime-scheduler/sdk-dotnet/master/assets/ds.png) 

This is the official SDK for Dime.Scheduler. The SDK is a gateway to connect *any* system to Dime.Scheduler through its extensive import pipeline and large collection of web APIs.

Check out the **[📚 docs »](https://docs.dimescheduler.com)** for more info.

## Prerequisites

In order to successfully use the SDK, make sure to comply with the following requirements:

- An active Dime.Scheduler subscription
- A valid Dime.Scheduler API key

## Installation

Use the package manager NuGet to install the base library of the SDK:

`dotnet add package Dime.Scheduler`

## Usage

The example below fetches the resources available in Dime.Scheduler:

```csharp
DimeSchedulerClient client = new("key");

IEnumerable<Resource> resources = await client.Resources.GetAsync(new ResourceRequest());

foreach (Resource resource in resources)
    Console.WriteLine(resource.Email);
```

The `DimeSchedulerClient` class is the entry point and it is where all endpoints are exposed:

```csharp
DimeSchedulerClient client = new("my-api-key");
```

Just a valid API key is required. With these credentials, you can access any of the endpoints, whether it be fetching data or importing data into Dime.Scheduler.

```csharp
IEnumerable<Resource> resources = await resourceEndpoint.GetAsync(new ResourceRequest());
```

This example adds or updates a category:

```csharp
DimeSchedulerClient client = new("my-api-key");

Category category = new("Category #1", "#6e62b5");
var response = await client.Indicators.Categories.CreateAsync(category);
```

## Endpoints and models

The following endpoints are available in the `DimeSchedulerClient` class:

- **ActionUri**: invoke HTTP GET or POST requests on tasks and appointments.
- **Caption**: Override the standard localization
- **Indicators**
  - **Category**: Background color of appointments
  - **TimeMarker**: Underscore bar of appointments
  - **Pin**: Color of markers on the map
- **Connector**: Send planning data back to your backoffice system
- **Container**: Group tasks and appointments
- **Filters**: Find suitable resources for the task at hand
  - **Filter Group**
  - **Filter Value**
- **Message**: Send transient messages to the active users
- **Notification**: Persistent messages for tasks, appointments, jobs, or just a general message for everybody.
- **Resource**: The entity that can be planned. Can also be set:
  - **ResourceFilterValue**: Assign a filter value to this resource.
  - **ResourceCalendar**: Assign a calendar to a resource for a given date range.
  - **ResourceCapacity**: Used in the capacity pivot.
  - **ResourceGpsTracking**: Update the current location of the resource.
  - **ResourceCertificate**: obsolete
  - **ResourceUri**: Add a link to relevant documentation about this resource.
- **Job**: The parent entity of a task that contains data such as customer and contact info, addresses, etc. 
- **Task**: The unit of work that needs to be planned. Can also be set:
  - **TaskFilterValue**: Set requirements (i.e. filter value) for this task that a resources must contain to successfully execute the task.
  - **TaskLocked**: Lock/unlock appointments for this task.
  - **TaskUri**: Add a link to relevant documentation about this task.
  - **TaskContainer**: Link tasks via a container.
- **Appointment**: assigment of a task to a resource on a certain date and time. Can also be set:
  - **AppointmentCategory**: Change the background color
  - **AppointmentContent**: Change subject and body
  - **AppointmentLocked**: Lock/unlock appointment on the planning board
  - **AppointmentTimeMarker**: Change color of horizontal bar at the bottom
  - **AppointmentUri**: Add a link to relevant documentation about this planned task
  - **AppointmentContainer**: Link appointments via a container
  - **Assignment**: Add/remove resources 
  - **AppointmentImportance**: Change the priority of the appointment
  - **AppointmentPlanningQuantity**: Change the plannning quantity
  - **AppointmentFieldValue**: Add additional data via the open data model of Appointment Templates.
- **Import**: The raw endpoint that handles all of the above.

It is possible that an endpoint may accept more than one model, such as those that target specific functionalities.  For instance, in the appointment endpoint, an instance of `AppointmentLocked` can be invoked:

```csharp
 AppointmentLocked appointmentLock = new()
 {
     SourceApp = "BC_USA_BRANCH",
     SourceType = "SERVICE",

     // The GUID of the appointment we'd like to update
     AppointmentGuid = "2a77f6c6-c502-4ad2-9ee2-6fba0f9361a1"     
     
     Locked = true
 };

await dimeScheduler.Appointments.UpdateAsync(appointmentLock);
```

## Read more

Check out the **[📚 docs »](https://docs.dimescheduler.com)** for more info.
