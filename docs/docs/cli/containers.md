---
id: containers
title: Containers
sidebar_label: Containers
---

## Command 

`container`

## Parameters

| Name | Description |Short option | Long option
| --- | --- | --- | --- |
| Url | The full URI to Dime.Scheduler, e.g. https://www.mydimescheduler.io |-u | --URI |
| User | The e-mail address of the forms account | -c | --user |
| Password | The password of the forms account | -p | --password 
| Action | Append or delete | -a to append / -d to delete | --append or --delete |
| Name | The name of the category | -n  |  --name
| HandleDate | The date of the container handle | -d | --date |
| HandleLocked | The status of the container handle | -l | --locked |

## Example

```cmd
dimescheduler container
-a
-u https://mydimescheduler.io
-c myadministrator@mydimescheduler.com
-p mystrongpassword
-n "Container 1"
-d "2021-05-30T18:00"
-l True
```