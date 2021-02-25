using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Dime.Scheduler.Sdk
{
    [ExcludeFromCodeCoverage]
    public class Page<T>
    {
        public IEnumerable<T> Data { get; set; }
    }
}