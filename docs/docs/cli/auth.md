---
id: auth
title: Authentication
sidebar_label: Authentication
---

Every request must be done in an authenticated context. Using the same set of roles and permissions enforced on the users through the graphical user interface, consumers of the command-line interface must also provide proof that they are who they claim to be. 

Users of the CLI, therefore, will not necessarily have elevated permissions. The business logic behind the CLI is equivalent to the functionality that consumers through other media (Dime.Scheduler's GUI, back-office systems such as Microsoft Dynamics 365 Business Central) have.

Currently, it is only possible to use the credentials of a forms user, or in other words, the user/password authentication mechanism.
Every request needs 3 key pieces of information:
- The URI to Dime.Scheduler
- The user's e-mail address
- The user's password

In the CLI, you can use `-u` or `--uri`, `-c` or `--user` and `-p` or `--password` for these properties. In case you forget, you can always ask the CLI for help by adding the `--help` switch.

Along with the `verb` and the `operation type`, these three properties are required.
The signature of any interaction with the Dime.Scheduler will look like this:

```bash
dimescheduler VERB
-a
-u https://mydimescheduler.io
-c myadministrator@mydimescheduler.com
-p MyStrongPassword
```