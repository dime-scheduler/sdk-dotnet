namespace Dime.Scheduler.Sdk
{
    public class ResourceRequest
    {
        public int page { get; set; } = 1;
        public int start { get; set; } = 100;
        public int limit { get; set; } = int.MaxValue;

        public string sort { get; set; }
        public string group { get; set; }
        public string filter { get; set; }
        public string resourceFilter { get; set; }
    }
}