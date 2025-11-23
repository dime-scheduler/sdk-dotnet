namespace Dime.Scheduler.Entities
{
    /// <summary>
    /// Represents a user in the system.
    /// </summary>
    /// <param name="Name">Gets or sets the user name.</param>
    /// <param name="Type">Gets or sets the login type.</param>
    /// <param name="Email">Gets or sets the email address.</param>
    /// <param name="Password">Gets or sets the password.</param>
    /// <param name="Language">Gets or sets the language code.</param>
    /// <param name="TimeZone">Gets or sets the time zone.</param>
    public record User(string Name, LoginType Type, string Email, string Password, string Language, string TimeZone);
}