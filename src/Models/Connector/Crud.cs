using System.ComponentModel;

namespace Dime.Scheduler.Entities
{
    /// <summary>
    /// Represents CRUD (Create, Read, Update, Delete) operation types.
    /// </summary>
    public enum Crud
    {
        /// <summary>
        /// Create operation.
        /// </summary>
        [Description("I")]
        Create,

        /// <summary>
        /// Read operation.
        /// </summary>
        [Description("Read")]
        Read,

        /// <summary>
        /// Update operation.
        /// </summary>
        [Description("U")]
        Update,

        /// <summary>
        /// Delete operation.
        /// </summary>
        [Description("D")]
        Delete
    }
}