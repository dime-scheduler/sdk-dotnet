using System.ComponentModel;

namespace Dime.Scheduler.Sdk
{
    public enum Operator
    {
        [Description("==")]
        Eq,

        [Description("like")]
        Like
    }
}