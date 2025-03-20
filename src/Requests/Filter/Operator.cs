using System.ComponentModel;

namespace Dime.Scheduler
{
    public enum Operator
    {
        [Description("==")]
        Eq,

        [Description("like")]
        Like
    }
}