---
id: example
title: Example
sidebar_label: Example
---

```csharp
string uri = "http://mydimescheduler.com";
IAuthenticator authenticator = new FormsAuthenticator(uri,"admin","admin");

DimeSchedulerClient client = new(uri, authenticator);

IResourceEndpoint resourceEndpoint = await client.Resources.Request();
IEnumerable<Resource> resources = await resourceEndpoint.GetAsync(new ResourceRequest());

foreach (Resource resource in resources)
    Console.WriteLine(resource.Email);
```