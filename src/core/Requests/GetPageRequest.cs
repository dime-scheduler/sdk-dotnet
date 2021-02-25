using System.Diagnostics.CodeAnalysis;

namespace Dime.Scheduler.Sdk
{
    [ExcludeFromCodeCoverage]
    public class GetPageRequest
    {
        public int page { get; set; } = 1;
        public int start { get; set; } = 100;
        public int limit { get; set; } = int.MaxValue;
        public string sort { get; set; }
        public string filter { get; set; }
    }
}