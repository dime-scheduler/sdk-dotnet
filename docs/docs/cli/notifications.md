---
id: notifications
title: Notifications
sidebar_label: Notifications
---

## Command 

`notification`

## Parameters

| Name | Description |Short option | Long option
| --- | --- | --- | --- |
| Url | The full URI to Dime.Scheduler, e.g. https://www.mydimescheduler.io |-u | --URI |
| User | The e-mail address of the forms account | -c | --user |
| Password | The password of the forms account | -p | --password 
| Action | Append or delete | -a to append / -d to delete | --append or --delete |
| Source App|  | |--sourceapp| 
| Source Type |  | |--sourcetype| 
| Appointment ID |  | |--appointmentid | 
| Connector ID |  | |--connectorid| 
| Type |  | |--type| 
| Code |  | |--code| 
| Text |  | |--text| 
| Date |  | |--date| 
| JobNo |  | |--jobno| 
| TaskNo |  | |--taskno| 
| Appointment GUID |  | |--appointmentguid| 
| Sent From Back Office |  | |--sentfrombackoffice| 

## Examples

Create or update a record:

```cmd
dimescheduler notification 
-a
-u https://mydimescheduler.io
-c myadministrator@mydimescheduler.com
-p mystrongpassword
--text CLI 
--code CLI 
--date 2021-11-30
--sourcetype CLI 
--sourceapp CLI
```