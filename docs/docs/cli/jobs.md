---
id: jobs
title: Jobs
sidebar_label: Jobs
---

A job is a meta entity that holds information about the work that needs to be scheduled. It is essentially the link to the entities in the back-office system such as service orders, jobs, production orders, etc.

In order to schedule any work, a job needs to exist first. Subsequently, tasks can be assigned to the job and the planner will be good to go and plan those work items.

## Command 

`job`

## Parameters

| Name | Description |Short option | Long option
| --- | --- | --- | --- |
| Url | The full URI to Dime.Scheduler, e.g. https://www.mydimescheduler.io |-u | --URI |
| User | The e-mail address of the forms account | -c | --user |
| Password | The password of the forms account | -p | --password 
| Action | Append or delete | -a to append / -d to delete | --append or --delete |
| JobNo | The unique identifier to describe the job | --jobno | 

## Examples

Create or update a category:

```cmd
dimescheduler job
-a
-u https://mydimescheduler.io
-c myadministrator@mydimescheduler.com
-p mystrongpassword
--jobno Hello World
```