using System.ComponentModel;

namespace Dime.Scheduler.Entities
{
    public enum Crud
    {
        [Description("I")]
        Create,
        [Description("Read")]
        Read,
        [Description("U")]
        Update,
        [Description("D")]
        Delete
    }
}