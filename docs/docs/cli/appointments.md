---
id: appointments
title: Appointments
sidebar_label: Appointments
---

## Command 

`appointment`

## Parameters

| Name | Description |Short option | Long option
| --- | --- | --- | --- |
| Url | The full URI to Dime.Scheduler, e.g. https://www.mydimescheduler.io |-u | --URI |
| User | The e-mail address of the forms account | -c | --user |
| Password | The password of the forms account | -p | --password 
| Action | Append or delete | -a to append / -d to delete | --append or --delete |
| Source App|  | N/A  | --sourceapp |
| Source Type |  | N/A  | --source Type|
| Job number|  | N/A  | --jobno |
| Task number |  | N/A  | --taskno |
| Start date|  | N/A  | --start |
| End date |  | N/A  | --end |
| Subject |  | N/A  | --subject |
| Body |  | N/A  | --body|
| Resource number |  | N/A  | --resourceno |
| Locked|  | N/A  | --locked|
| Importance|  | N/A  | --importance|

## Example

```cmd
dimescheduler appointment
-a
-u https://mydimescheduler.io
-c myadministrator@mydimescheduler.com
-p mystrongpassword
--sourceapp CRONUSBE 
--sourcetype JOB 
--jobno J00001 
--taskno 00003 
--start 2021-03-20T18:30:00 
--end 2021-03-21T12:30 
--subject Hello world 
--body Test  
--resourceno BULENS
--locked false 
--importance 1
```