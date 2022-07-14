---
id: overview
title: The command-line interface
sidebar_label: Overview
---

The Dime.Scheduler CLI is a [.NET Tool](https://docs.microsoft.com/en-us/dotnet/core/tools/global-tools) that allows you to invoke the SDK through a **command-line interface**. For more information, see the [📚 repo's wiki](https://github.com/dime-scheduler/cli/wiki) for a list of all commands and their parameters.

## Installation

As mentioned, the CLI is a .NET tool, so in order to install and use the CLI you'll need to install the [.NET CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/) first. Once that's done, you can install Dime.Scheduler's CLI:

```cmd
dotnet tool install Dime.Scheduler.CLI --global --version {YOUR VERSION}
```

## Usage

The following example adds or updates a category in Dime.Scheduler:

```cmd
dimescheduler category
-a
-u https://mydimescheduler.io
-c myadministrator@mydimescheduler.com
-p mystrongpassword
-n Service order status
-h #32a852
```

The entry point of the global tool is the `dimescheduler` command.

![Dime.Scheduler CLI](../../static/img/cli.png)

See the [repo's wiki](https://github.com/dime-scheduler/cli/wiki) for a list of all commands and their parameters.

To see the parameters of a command, simply run `dimescheduler` + `verb` + `--help` command and you'll get all the information you need.