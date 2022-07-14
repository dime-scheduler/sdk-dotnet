---
id: actionuri
title: Action URIs
sidebar_label: Action URIs
---

## Command 

`actionuri`

## Parameters

| Name | Description |Short option | Long option
| --- | --- | --- | --- |
| Url | The full URI to Dime.Scheduler, e.g. https://www.mydimescheduler.io |-u | --URI |
| User | The e-mail address of the forms account | -c | --user |
| Password | The password of the forms account | -p | --password 
| Action | Append or delete | -a to append / -d to delete | --append or --delete |
| Source App | | |--sourceapp|
| Source Type | | |--sourcetype|
| Uri Type | | |--uritype|
| Link  | | |--link|
| Description | | |--description|
| Default| | |--default|

## Examples

Create or update a record:

```cmd
dimescheduler actionuri
-a
-u https://mydimescheduler.io
-c myadministrator@mydimescheduler.com
-p mystrongpassword
```