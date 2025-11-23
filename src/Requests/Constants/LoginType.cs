namespace Dime.Scheduler.Entities
{
    /// <summary>
    /// Represents the login type for a user.
    /// </summary>
    public enum LoginType
    {
        /// <summary>
        /// No login type specified.
        /// </summary>
        None = 0,
        /// <summary>
        /// Forms authentication.
        /// </summary>
        Forms = 1,
        /// <summary>
        /// Microsoft Entra ID authentication.
        /// </summary>
        Entra = 2
    }
}