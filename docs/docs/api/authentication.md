---
id: authentication
title: Authentication
sidebar_label: Authentication
---

## How to authenticate 

Authentication is done with implementations of the `IAuthenticator` interface. The default authenticator that is shipped with the SDK is the one that authenticates a forms user in Dime.Scheduler. The authenticator is called when an *endpoint* is created, so when invalid credentials are used, an exception will be thrown at this stage. In other words, `IEndpoint` objects are always executed in the context of an authenticated user.

The authentication process is invisible to the user, all the system needs is a set of credentials at creation of the `DimeSchedulerClient` object.

```csharp
using Dime.Scheduler.Sdk.Import;

string uri = "http://mydimescheduler.com";
IAuthenticator authenticator = new FormsAuthenticator(uri, "validUserAccount", "validUserPassword");

DimeSchedulerClient client = new(uri, authenticator);

FilterGroup filterGroup = new FilterGroup { Name = "Group 1" };

 // Returns an endpoint with an authenticated user, or throws an exception when the user could not be logged in
IImportEndpoint importEndpoint = await client.Import.Request();
await importEndpoint.RunAsync(filterGroup, TransactionType.Append); 
```

## Authentication

The out-of-the-box mechanism is a relatively straightforward forms authentication. Simply pass a URI, e-mail address of the user name and the corresponding password, and the application returns a **OAuth 2.0 bearer token** that is valid for two days. Thus, the token is not reusable and must be refreshed from time to time. The current version of the SDK does not refresh tokens and requests a new token at each instantiation of the `DimeSchedulerClient` class.

## Caveats

Authorization is not yet included in the SDK. Therefore, it is recommended to use the credentials of a super user.