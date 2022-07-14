---
id: captions
title: Captions
sidebar_label: Captions
---

## Command 

`caption`

## Parameters

| Name | Description |Short option | Long option
| --- | --- | --- | --- |
| Url | The full URI to Dime.Scheduler, e.g. https://www.mydimescheduler.io |-u | --URI |
| User | The e-mail address of the forms account | -c | --user |
| Password | The password of the forms account | -p | --password 
| Action | Append or delete | -a to append / -d to delete | --append or --delete |
| Context |  | |--context| 
| Source Table |  | |--sourcetable| 
| Field Name |  | |--fieldname| 
| Language |  | |--language| 
| Text |  | |--text| 

## Examples

Create or update a record:

```cmd
dimescheduler caption
-a
-u https://mydimescheduler.io
-c myadministrator@mydimescheduler.com
-p mystrongpassword
--context XXX
--sourcetable XXX
--fieldname XXX
--language en-us
--text Hello world
```