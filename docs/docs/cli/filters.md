---
id: filters
title: Filters
sidebar_label: Filters
---

## Filter Groups

Filter groups are categories of filter values. A filter group holds a set of related values that make sense to an organization. Typical filter groups would be skills and regions, but there is no limit to what it means.

### Command 

`filtergroup`

### Parameters

| Name | Description |Short option | Long option
| --- | --- | --- | --- |
| Url | The full URI to Dime.Scheduler, e.g. https://www.mydimescheduler.io |-u | --URI |
| User | The e-mail address of the forms account | -c | --user |
| Password | The password of the forms account | -p | --password 
| Action | Append or delete | -a to append / -d to delete | --append or --delete |
| Name | The unique identifier to describe the job | |--name |

### Examples

Create or update a record:

```cmd
dimescheduler filtergroup
-a
-u https://mydimescheduler.io
-c myadministrator@mydimescheduler.com
-p mystrongpassword
--name Filter Group 1
```

## Filter Values

A filter value is simply an entry in the filter group. To add a filter value, simply specify the group and the value and it will be made available in the system. For example, you might add a skill `Dime.Scheduler` to the `Software` group, if that would make any sense.

Note that the resource and task filter system does not work automatically. Using the master data that you've specified here, you need to assign these values to the resources and tasks. Only then will the resource filters component be able to do its matching.

### Command 

`filtervalue`

### Parameters

| Name | Description |Short option | Long option
| --- | --- | --- | --- |
| Url | The full URI to Dime.Scheduler, e.g. https://www.mydimescheduler.io |-u | --URI |
| User | The e-mail address of the forms account | -c | --user |
| Password | The password of the forms account | -p | --password 
| Action | Append or delete | -a to append / -d to delete | --append or --delete |
| Group | The unique identifier of the filter group | |--group |
| Value | The filter value | |--value |

### Examples

Create or update a record:

```cmd
dimescheduler filtervalue
-a
-u https://mydimescheduler.io
-c myadministrator@mydimescheduler.com
-p mystrongpassword
--name Filter Group 1
--value Filter Value 1
```