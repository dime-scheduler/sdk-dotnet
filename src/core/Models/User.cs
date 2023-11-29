namespace Dime.Scheduler.Entities
{
    public record User(string Name, LoginType Type, string Email, string Password, string Language, string TimeZone);
}