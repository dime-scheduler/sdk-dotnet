﻿using System.ComponentModel;

namespace Dime.Scheduler.Entities.Exchange
{
    public enum Sensitivity
    {
        [Description("Normal")]
        Normal = 1,

        [Description("Personal")]
        Personal = 2,

        [Description("Private")]
        Private = 3,

        [Description("Confidential")]
        Confidential = 4
    }
}