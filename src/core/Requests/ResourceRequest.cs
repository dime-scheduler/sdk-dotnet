using System.Diagnostics.CodeAnalysis;

namespace Dime.Scheduler.Sdk
{
    [ExcludeFromCodeCoverage]
    public class ResourceRequest : GetPageRequest
    {
        public string resourceFilter { get; set; }
    }
}