---
id: tasks
title: Tasks
sidebar_label: Tasks
---

A task is a loose term to describe work that needs to be scheduled and executed. In Dime.Scheduler nomenclature, there are two types of tasks: open tasks and planned tasks. 

Every task that you create through this endpoint is by default an open task, or a task that is yet to be planned. A planned task is nothing more than an open task that has been assigned a date and a resource. A planned task is also known as an appointment.

Open tasks appear in the open tasks lists while planned tasks are available in the planning board and the planned tasks list.

A task needs a link to a job. A job is the containing entity that holds the link to the back-office systems and are therefore essential. Jobs have information about high-level topics such as customers, while tasks hold the information about the work itself. Because of this data model, tasks can be very low-level and there can be many tasks for a given job.

## Command 

`task`

## Parameters

| Name | Description |Short option | Long option
| --- | --- | --- | --- |
| Url | The full URI to Dime.Scheduler, e.g. https://www.mydimescheduler.io |-u | --URI |
| User | The e-mail address of the forms account | -c | --user |
| Password | The password of the forms account | -p | --password 
| Action | Append or delete | -a to append / -d to delete | --append or --delete |
| JobNo | The unique identifier to describe the job | |--jobno | 
| TaskNo | The unique identifier to describe the task || --taskno |
| ShortDescription | A short description to describe the task|| --shortdescription |

## Examples

Create or update a category:

```cmd
dimescheduler task
-a
-u https://mydimescheduler.io
-c myadministrator@mydimescheduler.com
-p mystrongpassword
--jobno Hello World
--taskno Hello world
--shortdescription Joy to the world
```

