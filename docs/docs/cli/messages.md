---
id: messages
title: Messages
sidebar_label: Messages
---

## Command 

`transientmessage`

## Parameters

| Name | Description |Short option | Long option
| --- | --- | --- | --- |
| Url | The full URI to Dime.Scheduler, e.g. https://www.mydimescheduler.io |-u | --URI |
| User | The e-mail address of the forms account | -c | --user |
| Password | The password of the forms account | -p | --password 
| Text | The name of the pin | -m  |  --message
| Severity | The severity of the message.  | -s | --severity |
| User | The user to publish the message to | -a | --to |

The severity value corresponds to an enum that accepts either value:
- Verbose, or 0
- Debug, or 1
- Info, or 2
- Warning, or 3
- Error, or 4
- Fatal, or 5

## Example

```cmd
dimescheduler transientMessage
-u https://mydimescheduler.io
-c myadministrator@mydimescheduler.com
-p mystrongpassword
-m Hello world
-s Info
-a Admin
```