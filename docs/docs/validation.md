---
id: validation
title: Validation
sidebar_label: Validation
---

Validation is done through the capabilities exposed in the `System.ComponentModel.DataAnnotations` namespace. Wrapped in the interface ` IValidatableImportRequest<out T>`, import objects are validated before the request is sent to Dime.Scheduler.

Take the `FilterGroup` class as an example:

```csharp
public class FilterGroup : IImportRequestable, IValidatableImportRequest<FilterGroup>
{
    [Required]
    public string Name { get; set; }
}
```

When invoking the following request, an exception will be thrown:

```csharp
FilterGroup model = new FilterGroup { ColumnNo = 1 };
((IImportRequestable) model).ToImportRequest(TransactionType.Append); // Will throw exception
```