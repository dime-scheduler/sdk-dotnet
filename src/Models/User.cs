namespace Dime.Scheduler.Entities
{
    /// <summary>
    /// Represents a user in the system.
    /// </summary>
    /// <param name="Name">The user name.</param>
    /// <param name="Type">The login type.</param>
    /// <param name="Email">The email address.</param>
    /// <param name="Password">The password.</param>
    /// <param name="Language">The language code.</param>
    /// <param name="TimeZone">The time zone.</param>
    public record User(string Name, LoginType Type, string Email, string Password, string Language, string TimeZone);
}