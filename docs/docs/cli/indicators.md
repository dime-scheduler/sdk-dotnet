---
id: indicators
title: Indicators
sidebar_label: Indicators
---

## Categories

A category is used to render the background of the appointment in the planning board. 

### Command 

`category`

### Parameters

| Name | Description |Short option | Long option
| --- | --- | --- | --- |
| Url | The full URI to Dime.Scheduler, e.g. https://www.mydimescheduler.io |-u | --URI |
| User | The e-mail address of the forms account | -c | --user |
| Password | The password of the forms account | -p | --password 
| Action | Append or delete | -a to append / -d to delete | --append or --delete |
| Name | The name of the category | -n  |  --name
| Color | The hex color e.g. #6e62b5 | -h | --hex |

### Examples

Create or update a category:

```cmd
dimescheduler category
-a
-u https://mydimescheduler.io
-c myadministrator@mydimescheduler.com
-p mystrongpassword
-n Service order status
-h #32a852
```

Remove a category:

```cmd
dimescheduler category
-d
-u https://mydimescheduler.io
-c myadministrator@mydimescheduler.com
-p mystrongpassword
-n Service order status
-h #32a852
```

## Time Markers

## Poins