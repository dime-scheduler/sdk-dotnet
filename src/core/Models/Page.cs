using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Dime.Scheduler.Sdk
{
    [ExcludeFromCodeCoverage]
    public class Page<T>
    {
        public IEnumerable<T> Data { get; set; }

        public void Deconstruct(out IEnumerable<T> data) => data = Data;
    }
}