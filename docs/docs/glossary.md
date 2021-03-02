---
id: glossary
title: Glossary
sidebar_label: Glossary
---

To understand the SDK, it is probably a good idea to get a grasp of the concepts and entities in Dime.Scheduler. It isn't rocket science but it is *slightly* abstract. Nonetheless, they are easy to understand and soon you'll see a world of oppportunities with a flexible data model.

## Resource

A resource is an entity that is subjected to planning. That is a very broad definition but it is meant to be like that, because a resource can be *anything* in Dime.Scheduler. For example, a resource can be a technician, consultant, vehicle, production line, equipment, and many more.

Resources are displayed as rows in the planning board of Dime.Scheduler.

## Task

The second key element of planning are the tasks, or the units of work that need to be executed. Just like with resources, a task can be *anything*. Some examples are maintenance of HVAC installations, project stakeholder meeting, placing rat traps in the ceiling, printing the third edition of a book, etc.

Tasks are initially displayed in the open tasks component in Dime.Scheduler. Of course, tasks need to be assigned a time slot and a resource so it can be carried out. When a task is scheduled, it will appear in both the planning board and planned tasks component.

## Job

A job is a meta entity that holds a number of related tasks. In the real world, there are many names for a job: a project, a service order, production order, sales order, assembly order, etc. Jobs describe the assignment on a high level and contain data that is true for all the underlying tasks. 

As the highest possible level for a work order, jobs capture information about the following entities:

- Customer
- Contact 
- Billing
- Addresses

Tasks cannot exist without a job. In other words, in order to send tasks to Dime.Scheduler, a task always needs to be preceeded by a job import run.

## Filter group / value

Dime.Scheduler filters provide a simple and flexible framework to define requirements for tasks and qualifications for resources. This allows planners to find the right resource for the task. For example, in order to execute the "Translate user manual to Spanish" task, a resource would for instance need to possess a C2 CEFR level for Spanish.

## Indicator

At present, there are three indicators which visually mark appointments in Dime.Scheduler:

- Category
- Time marker
- Pin

They share the same purpose and as such, they have the same data model. Indicators can obviously be mapped to 
fields in the back office system that actually have a meaning because the indicator's data model is extremely simple and does not expose any business logic; it merely htas a name and a color.

For example, a category can serve as a status indicator. When a resource starts the task, he can then update the task through a mobile app and set the status to 'In Progress'. Through real-time synchronization, the appointment in the planning board will be updated and the planner will see - through the color of the modified indicator - that the resource has arrived at the client's site and has started the activity.