---
id: resources
title: Resources
sidebar_label: Resources
---

### Live Location

This endpoint allows you to update the live position of a resource on the map. Specify the resource number and the coordinates and you're a shoe-in.

## Command 

`resourcelivelocation`

### Parameters

| Name | Description |Short option | Long option
| --- | --- | --- | --- |
| Url | The full URI to Dime.Scheduler, e.g. https://www.mydimescheduler.io |-u | --URI |
| User | The e-mail address of the forms account | -c | --user |
| Password | The password of the forms account | -p | --password 
| Action | Append or delete | -a to append / -d to delete | --append or --delete |
| Resource number | The name of the category | -r  |  --resourceno
| Latitude | The latitude | -x | --latitude |
| Longitude | The longitude | -y | --longitude |

### Example

This example puts resource identified by number 'LINDA' on top of Mount Kilimanjaro:

```cmd
dimescheduler resourcelivelocation
-a
-u https://mydimescheduler.io
-c myadministrator@mydimescheduler.com
-p mystrongpassword
-r LINDA
-x -3.066873
-y 37.356252
```