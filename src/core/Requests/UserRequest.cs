namespace Dime.Scheduler.Sdk
{
    public class UserRequest
    {
        public string Name { get; set; }

        public LoginType Type { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Language { get; set; }

        public string TimeZone { get; set; }
    }
}