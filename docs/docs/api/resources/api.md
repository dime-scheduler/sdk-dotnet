---
id: resources
title: Using the Resources API
sidebar_label: Resource
---

The example below fetches the resources available in Dime.Scheduler:

```csharp
string uri = "http://mydimescheduler.com";
IAuthenticator authenticator = new FormsAuthenticator(uri,"admin","admin");

DimeSchedulerClient client = new(uri, authenticator);

IResourceEndpoint resourceEndpoint = await client.Resources.Request();
IEnumerable<Resource> resources = await resourceEndpoint.GetAsync(new ResourceRequest());

foreach (Resource resource in resources)
    Console.WriteLine(resource.Email);
```

The API looks very similar to the import API. The difference is the parameter and the return type. The API returns a list of `Resource` objects, and takes a `ResourceRequest` object as the parameter, which accepts the following parameters:

- Page
- Page Number
- Sort
- Filter
- Resource Filter

